using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Text;

namespace ImagePacker
{
    class ImageInfo
    {
        private Bitmap m_bmp;
        private string m_filename;
        private bool m_is_trim = false;

        public ImageInfo(bool is_trim)
        {
            m_is_trim = is_trim;
        }

        public string FileName { 
            get => m_filename;
            set 
            {
                m_filename = value;
                m_bmp = new Bitmap(m_filename);
                Rect = new Rectangle(0,0,m_bmp.Width,m_bmp.Height);
                ActualRect = new Rectangle(0, 0, m_bmp.Width, m_bmp.Height);
                if (m_is_trim)
                    CalculateActualRect();
            } 
        }
        public Rectangle Rect { get; set; }
        public Rectangle ActualRect { get; private set; }
        public Image Img { get => m_bmp; }

        private void CalculateActualRect()
        {
            BitmapData bmp_data = null;
            try
            {
                bmp_data = m_bmp.LockBits(new Rectangle(0, 0, Rect.Width, Rect.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte[] buffer = new byte[bmp_data.Height * bmp_data.Stride];
                Marshal.Copy(bmp_data.Scan0, buffer, 0, buffer.Length);

                int xMin = int.MaxValue,
                    xMax = int.MinValue,
                    yMin = int.MaxValue,
                    yMax = int.MinValue;

                for (int x = 0; x < bmp_data.Width; x++)
                {
                    for (int y = 0; y < bmp_data.Height; y++)
                    {
                        byte alpha = buffer[y * bmp_data.Stride + 4 * x + 3];
                        if (alpha != 0)
                        {
                            if (x < xMin) xMin = x;
                            if (x > xMax) xMax = x;
                            if (y < yMin) yMin = y;
                            if (y > yMax) yMax = y;
                        }
                    }
                }
                if (xMax > xMin && yMax > yMin)
                {
                    ActualRect = Rectangle.FromLTRB(xMin, yMin, xMax+1, yMax+1);
                }
            }
            finally
            {
                if (bmp_data != null)
                    m_bmp.UnlockBits(bmp_data);
            }
        }
    }
}
