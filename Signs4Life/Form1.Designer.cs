namespace Signs4Life
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Logo = new PictureBox();
            label1 = new Label();
            LSMtoText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Sound = new Button();
            Settings = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.Image = Properties.Resources.ls4l_removebg_preview;
            Logo.Location = new Point(693, 12);
            Logo.Margin = new Padding(4, 3, 3, 4);
            Logo.Name = "Logo";
            Logo.Size = new Size(76, 67);
            Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(446, 99);
            label1.Name = "label1";
            label1.Size = new Size(211, 18);
            label1.TabIndex = 1;
            label1.Text = "Traducción de LSM a texto";
            label1.Click += label1_Click;
            // 
            // LSMtoText
            // 
            LSMtoText.BackColor = Color.FromArgb(255, 192, 192);
            LSMtoText.Location = new Point(446, 129);
            LSMtoText.Multiline = true;
            LSMtoText.Name = "LSMtoText";
            LSMtoText.Size = new Size(287, 77);
            LSMtoText.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(506, 224);
            button1.Name = "button1";
            button1.Size = new Size(189, 35);
            button1.TabIndex = 3;
            button1.Text = "Responder";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Location = new Point(67, 346);
            button2.Name = "button2";
            button2.Size = new Size(138, 41);
            button2.TabIndex = 4;
            button2.Text = "Iniciar traducción";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.Location = new Point(237, 346);
            button3.Name = "button3";
            button3.Size = new Size(138, 41);
            button3.TabIndex = 5;
            button3.Text = "Detener traducción";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Sound
            // 
            Sound.BackgroundImage = (Image)resources.GetObject("Sound.BackgroundImage");
            Sound.BackgroundImageLayout = ImageLayout.Stretch;
            Sound.Location = new Point(586, 383);
            Sound.Name = "Sound";
            Sound.Size = new Size(59, 45);
            Sound.TabIndex = 6;
            Sound.Text = "\r\n";
            Sound.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            Settings.BackgroundImage = Properties.Resources.Conf_removebg_preview;
            Settings.BackgroundImageLayout = ImageLayout.Stretch;
            Settings.Location = new Point(665, 383);
            Settings.Name = "Settings";
            Settings.Size = new Size(61, 45);
            Settings.TabIndex = 7;
            Settings.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Settings);
            Controls.Add(Sound);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LSMtoText);
            Controls.Add(label1);
            Controls.Add(Logo);
            Name = "Form1";
            Text = "Logo";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Logo;
        private Label label1;
        private TextBox LSMtoText;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Sound;
        private Button Settings;
    }
}