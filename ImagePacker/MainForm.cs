using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImagePacker
{
    public partial class MainForm : Form
    {
        private string m_folder_path;
        private string m_atlas_name;
        private bool m_is_trim = false;
        private bool m_is_folder_good = false;
        private List<ImageInfo> m_images;
        Bitmap m_atlas;
        public MainForm()
        {
            InitializeComponent();
            m_images = new List<ImageInfo>();
            Cleanup();
        }

        private void Cleanup()
        {
            generate_button.Enabled = false;
            log_textBox.Clear();
            gmm_textBox.Clear();
            m_images.Clear();
            m_folder_path = "";
            m_is_folder_good = false;
            pictureBox.Image = null;
            if(m_atlas != null)
                m_atlas.Dispose();
        }

        private void Open_button_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                folder_textBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Folder_textBox_TextChanged(object sender, EventArgs e)
        {
            Cleanup();
            m_folder_path = folder_textBox.Text;
            m_is_trim = trim_checkBox.Checked;
            if (AnalizeFolder())
            {
                if (ReadImages())
                    generate_button.Enabled = true;
                else
                    Log("Cannot read any file", true);
            }
        }

        private bool AnalizeFolder()
        {
            if (!Directory.Exists(m_folder_path))
            {
                Log("Selected folder does not exist", true);
                return false;
            }
            if (Directory.GetFiles(m_folder_path, "*.png").Length == 0)
            {
                Log("Selected folder does not have png-files", true);
                return false;
            }
            m_is_folder_good = true;
            return true;
        }

        private void Log(string str, bool is_error = false)
        {
            if (is_error)
                log_textBox.AppendText("ERROR: ");
            log_textBox.AppendText(str + "\r\n");
        }

        private bool ReadImages()
        {
            m_images.Clear();
            foreach (string filename in Directory.EnumerateFiles(m_folder_path, "*.png"))
            {
                ImageInfo info = new ImageInfo(m_is_trim);
                info.FileName = filename;
                m_images.Add(info);
                Log(filename + " [" + info.ActualRect.Width + "x" + info.ActualRect.Height + "]");
            }
            return m_images.Count > 0;
        }

        private void PlaceImages()
        {
            string temp_file = m_folder_path + "\\temp.txt";
            CreateFileWithRectangles(temp_file);
            Size atlas_size = GetPositions(temp_file);
            File.Delete(temp_file);
            if (atlas_size.IsEmpty)
            {
                Log("Images cannot be placed into one file", true);
                return;
            }
            else
            {
                CreateAtlasImage(atlas_size);
                CreateAtlasGmm();
            }
        }

        private void CreateFileWithRectangles(string filename)
        {
            StreamWriter txt_writer = File.CreateText(filename);
            foreach (ImageInfo info in m_images)
            {
                txt_writer.Write(info.ActualRect.Width);
                txt_writer.Write(" ");
                txt_writer.WriteLine(info.ActualRect.Height);
            }
            txt_writer.Close();
            Log("File with sizes of rectangles is created");
        }

        private Size GetPositions(string filename_with_rectangles)
        {
            Process process = new Process();
            process.StartInfo.FileName = "RectPack2D.exe";
            process.StartInfo.Arguments = filename_with_rectangles;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            string atlas_data = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            process.Close();
            process.Dispose();
            Log("Atlas data is obtained from RectPack2D.exe:");
            log_textBox.AppendText("ImageSize: ");
            Log(atlas_data);
            Log("-------------------------------");
            return ParseAtlasData(atlas_data);
        }

        private Size ParseAtlasData(string atlas_data)
        {
            String[] pairs = atlas_data.Split('\n');
            String[] atlas_size = pairs[0].Split(' ');
            Size res = new Size(Int32.Parse(atlas_size[0]), Int32.Parse(atlas_size[1]));
            if (!res.IsEmpty)
            {
                int index = 1;
                foreach (ImageInfo info in m_images)
                {
                    String[] rect_data= pairs[index].Split(' ');
                    Point rect_pos = new Point(Int32.Parse(rect_data[0]), Int32.Parse(rect_data[1]));
                    Rectangle image_rect = info.Rect;
                    image_rect.Location = rect_pos;
                    info.Rect = image_rect;
                    ++index;
                }
            }
            return res;
        }
        private void CreateAtlasImage(Size atlas_size)
        {
            pictureBox.Image = null;
            if(m_atlas != null)
                m_atlas.Dispose();
            m_atlas = new Bitmap(atlas_size.Width, atlas_size.Height);
            float hor_resolution = m_images[0].Img.HorizontalResolution;
            float ver_resolution = m_images[0].Img.VerticalResolution;
            m_atlas.SetResolution(hor_resolution, ver_resolution);
            Graphics gr = Graphics.FromImage(m_atlas);
            foreach (ImageInfo info in m_images)
            {
                info.Img.SetResolution(hor_resolution, ver_resolution);
                gr.DrawImage(info.Img, info.Rect.X, info.Rect.Y, info.ActualRect, GraphicsUnit.Pixel);
            }
            gr.Dispose();
            pictureBox.Image = m_atlas;
        }

        private void CreateAtlasGmm()
        {
            gmm_textBox.AppendText("bitmaps: [\r\n");
            gmm_textBox.AppendText("\t{ id: \"" + m_atlas_name + "\"; file: \"bitmaps/" + m_atlas_name + ".png\"; memmode: \"disk\"; },\r\n");
            gmm_textBox.AppendText("]\r\n\r\n");
            gmm_textBox.AppendText("slices: [\r\n");
            foreach(ImageInfo info in m_images)
            {
                gmm_textBox.AppendText("\t{ id: \"");
                gmm_textBox.AppendText(Path.GetFileNameWithoutExtension(info.FileName));
                gmm_textBox.AppendText("\"; bitmap: \"" + m_atlas_name + "\"; pos:[");
                gmm_textBox.AppendText(info.Rect.X + ", " + info.Rect.Y + "]; size:[");
                gmm_textBox.AppendText(info.ActualRect.Width + ", " + info.ActualRect.Height + "]; },\r\n");
            }
            gmm_textBox.AppendText("]\r\n\r\n");
        }

        private void Generate_button_Click(object sender, EventArgs e)
        {
            gmm_textBox.Clear();
            m_atlas_name = atlasfile_textBox.Text;
            if (m_atlas_name.Length == 0)
            {
                Log("Set correct atlas name", true);
                atlasfile_textBox.Focus();
            }
            else
                PlaceImages();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            m_is_trim = trim_checkBox.Checked;
            if (m_is_folder_good)
            {
                if (ReadImages())
                    generate_button.Enabled = true;
                else
                    generate_button.Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = m_atlas_name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_atlas.Save(saveFileDialog1.FileName);
            }
        }
    }
}
