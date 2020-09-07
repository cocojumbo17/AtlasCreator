namespace ImagePacker
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.trim_checkBox = new System.Windows.Forms.CheckBox();
            this.log_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.open_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folder_textBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.atlasfile_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.generate_button = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.gmm_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.save_button = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.top_panel = new System.Windows.Forms.Panel();
            this.result_panel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.result_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trim_checkBox
            // 
            this.trim_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trim_checkBox.AutoSize = true;
            this.trim_checkBox.Location = new System.Drawing.Point(728, 23);
            this.trim_checkBox.Name = "trim_checkBox";
            this.trim_checkBox.Size = new System.Drawing.Size(155, 17);
            this.trim_checkBox.TabIndex = 5;
            this.trim_checkBox.Text = "Cut off all transparent pixels";
            this.trim_checkBox.UseVisualStyleBackColor = true;
            this.trim_checkBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // log_textBox
            // 
            this.log_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_textBox.Location = new System.Drawing.Point(3, 16);
            this.log_textBox.Multiline = true;
            this.log_textBox.Name = "log_textBox";
            this.log_textBox.ReadOnly = true;
            this.log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_textBox.Size = new System.Drawing.Size(439, 234);
            this.log_textBox.TabIndex = 6;
            this.log_textBox.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.open_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.folder_textBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.MinimumSize = new System.Drawing.Size(300, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(896, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select folder with images";
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.Location = new System.Drawing.Point(819, 20);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(64, 20);
            this.open_button.TabIndex = 2;
            this.open_button.Text = "Open...";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.Open_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder with images";
            // 
            // folder_textBox
            // 
            this.folder_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.folder_textBox.Location = new System.Drawing.Point(108, 20);
            this.folder_textBox.Name = "folder_textBox";
            this.folder_textBox.Size = new System.Drawing.Size(705, 20);
            this.folder_textBox.TabIndex = 1;
            this.folder_textBox.TextChanged += new System.EventHandler(this.Folder_textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.atlasfile_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trim_checkBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(10, 64);
            this.groupBox2.MinimumSize = new System.Drawing.Size(300, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox2.Size = new System.Drawing.Size(896, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Settings";
            // 
            // atlasfile_textBox
            // 
            this.atlasfile_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.atlasfile_textBox.Location = new System.Drawing.Point(104, 20);
            this.atlasfile_textBox.Name = "atlasfile_textBox";
            this.atlasfile_textBox.Size = new System.Drawing.Size(618, 20);
            this.atlasfile_textBox.TabIndex = 7;
            this.atlasfile_textBox.Text = "atlas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name of atlas-file";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.log_textBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 253);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.generate_button);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(10, 118);
            this.groupBox4.MinimumSize = new System.Drawing.Size(300, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(896, 61);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "3. Generate atlas and gmm code";
            // 
            // generate_button
            // 
            this.generate_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generate_button.Location = new System.Drawing.Point(10, 23);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(876, 28);
            this.generate_button.TabIndex = 0;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.gmm_textBox);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(445, 133);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4. Generated gmm code";
            // 
            // gmm_textBox
            // 
            this.gmm_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmm_textBox.Location = new System.Drawing.Point(3, 16);
            this.gmm_textBox.Multiline = true;
            this.gmm_textBox.Name = "gmm_textBox";
            this.gmm_textBox.ReadOnly = true;
            this.gmm_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gmm_textBox.Size = new System.Drawing.Size(439, 114);
            this.gmm_textBox.TabIndex = 6;
            this.gmm_textBox.WordWrap = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(5, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(436, 339);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // save_button
            // 
            this.save_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save_button.Location = new System.Drawing.Point(193, 364);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(64, 20);
            this.save_button.TabIndex = 13;
            this.save_button.Text = "Save as...";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pictureBox);
            this.groupBox6.Controls.Add(this.save_button);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(447, 390);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "5. Save atlas file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Png files|*.png";
            this.saveFileDialog1.Title = "Save atlas file as...";
            // 
            // top_panel
            // 
            this.top_panel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.top_panel.Controls.Add(this.groupBox4);
            this.top_panel.Controls.Add(this.groupBox2);
            this.top_panel.Controls.Add(this.groupBox1);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Padding = new System.Windows.Forms.Padding(10);
            this.top_panel.Size = new System.Drawing.Size(916, 184);
            this.top_panel.TabIndex = 15;
            // 
            // result_panel
            // 
            this.result_panel.Controls.Add(this.splitContainer1);
            this.result_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_panel.Location = new System.Drawing.Point(0, 184);
            this.result_panel.MinimumSize = new System.Drawing.Size(300, 300);
            this.result_panel.Name = "result_panel";
            this.result_panel.Padding = new System.Windows.Forms.Padding(10);
            this.result_panel.Size = new System.Drawing.Size(916, 410);
            this.result_panel.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
            this.splitContainer1.Size = new System.Drawing.Size(896, 390);
            this.splitContainer1.SplitterDistance = 445;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer2.Size = new System.Drawing.Size(445, 390);
            this.splitContainer2.SplitterDistance = 133;
            this.splitContainer2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 594);
            this.Controls.Add(this.result_panel);
            this.Controls.Add(this.top_panel);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagePacker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.result_panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox trim_checkBox;
        private System.Windows.Forms.TextBox log_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.TextBox folder_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox atlasfile_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox gmm_textBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

