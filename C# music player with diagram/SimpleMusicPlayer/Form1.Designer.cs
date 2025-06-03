namespace SimpleMusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnplay = new System.Windows.Forms.Button();
            this.btnrewind = new System.Windows.Forms.Button();
            this.btnfastforward = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnpause = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.q3 = new System.Windows.Forms.PictureBox();
            this.q2 = new System.Windows.Forms.PictureBox();
            this.q1 = new System.Windows.Forms.PictureBox();
            this.q0 = new System.Windows.Forms.PictureBox();
            this.buo = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.Color.White;
            this.btnplay.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(82, 613);
            this.btnplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(415, 48);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "Find Music";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrewind
            // 
            this.btnrewind.BackColor = System.Drawing.Color.White;
            this.btnrewind.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrewind.Location = new System.Drawing.Point(264, 685);
            this.btnrewind.Margin = new System.Windows.Forms.Padding(4);
            this.btnrewind.Name = "btnrewind";
            this.btnrewind.Size = new System.Drawing.Size(97, 48);
            this.btnrewind.TabIndex = 2;
            this.btnrewind.Text = "Rewind";
            this.btnrewind.UseVisualStyleBackColor = false;
            this.btnrewind.Click += new System.EventHandler(this.btnrewind_Click);
            // 
            // btnfastforward
            // 
            this.btnfastforward.BackColor = System.Drawing.Color.White;
            this.btnfastforward.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfastforward.ForeColor = System.Drawing.Color.Black;
            this.btnfastforward.Location = new System.Drawing.Point(379, 685);
            this.btnfastforward.Margin = new System.Windows.Forms.Padding(4);
            this.btnfastforward.Name = "btnfastforward";
            this.btnfastforward.Size = new System.Drawing.Size(104, 48);
            this.btnfastforward.TabIndex = 2;
            this.btnfastforward.Text = "Fast Forward";
            this.btnfastforward.UseVisualStyleBackColor = false;
            this.btnfastforward.Click += new System.EventHandler(this.btnfastforward_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnpause);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnrewind);
            this.panel1.Controls.Add(this.btnplay);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Controls.Add(this.btnfastforward);
            this.panel1.Location = new System.Drawing.Point(118, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 968);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.Color.White;
            this.btnpause.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpause.ForeColor = System.Drawing.Color.Black;
            this.btnpause.Location = new System.Drawing.Point(82, 685);
            this.btnpause.Margin = new System.Windows.Forms.Padding(4);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(174, 48);
            this.btnpause.TabIndex = 7;
            this.btnpause.Text = "Play, Pause\r\n";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(82, 758);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SimpleMusicPlayer.Properties.Resources._75f4f69f370f3ca59d7f4bd640e4ebd4;
            this.pictureBox1.Location = new System.Drawing.Point(-144, -42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 658);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-2, 4);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(274, 248);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // q3
            // 
            this.q3.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_212727;
            this.q3.Location = new System.Drawing.Point(24, 4);
            this.q3.Margin = new System.Windows.Forms.Padding(4);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(961, 413);
            this.q3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q3.TabIndex = 23;
            this.q3.TabStop = false;
            // 
            // q2
            // 
            this.q2.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_212531;
            this.q2.Location = new System.Drawing.Point(24, 4);
            this.q2.Margin = new System.Windows.Forms.Padding(4);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(961, 413);
            this.q2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q2.TabIndex = 21;
            this.q2.TabStop = false;
            // 
            // q1
            // 
            this.q1.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_212613;
            this.q1.Location = new System.Drawing.Point(24, 4);
            this.q1.Margin = new System.Windows.Forms.Padding(4);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(961, 413);
            this.q1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q1.TabIndex = 20;
            this.q1.TabStop = false;
            // 
            // q0
            // 
            this.q0.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_212442;
            this.q0.Location = new System.Drawing.Point(24, 4);
            this.q0.Margin = new System.Windows.Forms.Padding(4);
            this.q0.Name = "q0";
            this.q0.Size = new System.Drawing.Size(961, 413);
            this.q0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.q0.TabIndex = 18;
            this.q0.TabStop = false;
            this.q0.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // buo
            // 
            this.buo.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_212652;
            this.buo.Location = new System.Drawing.Point(24, 4);
            this.buo.Margin = new System.Windows.Forms.Padding(4);
            this.buo.Name = "buo";
            this.buo.Size = new System.Drawing.Size(961, 413);
            this.buo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buo.TabIndex = 15;
            this.buo.TabStop = false;
            this.buo.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_225106;
            this.pictureBox8.Location = new System.Drawing.Point(764, 576);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(720, 382);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox5);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.q2);
            this.panel4.Controls.Add(this.q3);
            this.panel4.Controls.Add(this.q1);
            this.panel4.Controls.Add(this.q0);
            this.panel4.Controls.Add(this.buo);
            this.panel4.Location = new System.Drawing.Point(59, 8);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1003, 434);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_230427;
            this.pictureBox5.Location = new System.Drawing.Point(690, 264);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(91, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_225700;
            this.pictureBox4.Location = new System.Drawing.Point(717, 300);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1806, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 17;
            this.button1.Text = "exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(755, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1112, 460);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SimpleMusicPlayer.Properties.Resources.Screenshot_2025_05_28_225155;
            this.pictureBox2.Location = new System.Drawing.Point(1492, 576);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(375, 387);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SimpleMusicPlayer.Properties.Resources.Scqsqqreenshot_2025_05_17_213647;
            this.pictureBox3.Location = new System.Drawing.Point(755, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1106, 97);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = global::SimpleMusicPlayer.Properties.Resources.Festival;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1893, 929);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "music player";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnrewind;
        private System.Windows.Forms.Button btnfastforward;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.PictureBox buo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox q0;
        private System.Windows.Forms.PictureBox q1;
        private System.Windows.Forms.PictureBox q2;
        private System.Windows.Forms.PictureBox q3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

