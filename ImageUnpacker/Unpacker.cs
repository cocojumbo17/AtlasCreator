using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace ImageUnpacker
{
    class Unpacker
    {
        private string gmm_text;
        private string folder_name;
        private Bitmap atlas_bitmap;
        
        public Unpacker(string image_file_name, string gmm_file_name)
        {
            try
            {
                gmm_text = File.ReadAllText(gmm_file_name);
                folder_name = Path.Combine(Path.GetDirectoryName(image_file_name), Path.GetFileNameWithoutExtension(image_file_name));
                atlas_bitmap = new Bitmap(image_file_name);
            }
            catch
            {
                atlas_bitmap = null;
                Console.WriteLine("ERROR: incorrect file format");
                Console.WriteLine("ImageUnpacker.exe <png-filename to unpack> <gmm-file with slices>");
            }
        }
        public void Unpack()
        {
            if (atlas_bitmap == null)
                return;
            string[] lines = gmm_text.Split('\n');
            string pattern = @"""|\]|\[|,";
            foreach (string line in lines)
            {
                string str = line.Trim();
                if (str.Length < 20)
                {
                    Console.WriteLine("WARNING: Strange line in gmm-file:");
                    Console.WriteLine("\t" + str);
                    continue;
                }
                try
                {
                    string[] parts = Regex.Split(str, pattern);
                    string bmp_name = parts[1];
                    Rectangle rect = new Rectangle(Int32.Parse(parts[5]), Int32.Parse(parts[6]), Int32.Parse(parts[8]), Int32.Parse(parts[9]));
                    CreateImage(bmp_name, rect);
                }
                catch
                {
                    Console.WriteLine("ERROR: cannot parse string in gmm-file:");
                    Console.WriteLine("\t" + str);
                    continue;
                }
            }
        }
        private void CreateImage(string bmp_name, Rectangle rect)
        {
            string full_bmp_name = Path.Combine(folder_name, bmp_name+".png");
            try
            {
                Directory.CreateDirectory(folder_name);
                Bitmap image = new Bitmap(rect.Width, rect.Height);
                image.SetResolution(atlas_bitmap.HorizontalResolution, atlas_bitmap.VerticalResolution);
                Graphics gr = Graphics.FromImage(image);
                gr.DrawImage(atlas_bitmap, 0, 0, rect, GraphicsUnit.Pixel);
                gr.Dispose();
                image.Save(full_bmp_name);
                image.Dispose();
            }
            catch
            {
                Console.WriteLine("ERROR: cannot create file: " + bmp_name);
            }
        }
    }
}
