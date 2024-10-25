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

        private Button GetSettings()
        {
            return Settings;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Button settings)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Logo = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Sound = new Button();
            Settings = new Button();
            LBLSM = new ListBox();
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
            // button1
            // 
            button1.BackColor = Color.LightPink;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(494, 219);
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
            Sound.BackColor = Color.Transparent;
            Sound.BackgroundImage = (Image)resources.GetObject("Sound.BackgroundImage");
            Sound.BackgroundImageLayout = ImageLayout.Stretch;
            Sound.FlatAppearance.BorderColor = Color.DarkSeaGreen;
            Sound.FlatStyle = FlatStyle.Flat;
            Sound.Location = new Point(670, 511);
            Sound.Margin = new Padding(3, 4, 3, 4);
            Sound.Name = "Sound";
            Sound.Padding = new Padding(10, 2, 2, 10);
            Sound.Size = new Size(59, 45);
            Sound.TabIndex = 6;
            Sound.Text = "\r\n";
            Sound.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            Settings.BackColor = Color.Transparent;
            Settings.BackgroundImage = Properties.Resources.Conf_removebg_preview;
            Settings.BackgroundImageLayout = ImageLayout.Stretch;
            settings.Location = new Point(665, 383);
            NewMethod();
            Settings.Size = new Size(61, 45);
            Settings.TabIndex = 7;
            Settings.UseVisualStyleBackColor = false;
            // 
            // LBLSM
            // 
            LBLSM.BackColor = Color.LightPink;
            LBLSM.FormattingEnabled = true;
            LBLSM.ItemHeight = 15;
            LBLSM.Location = new Point(446, 125);
            LBLSM.Margin = new Padding(3, 2, 3, 2);
            LBLSM.Name = "LBLSM";
            LBLSM.Size = new Size(287, 79);
            LBLSM.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(LBLSM);
            Controls.Add(Settings);
            Controls.Add(Sound);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Logo);
            Name = "Form1";
            Text = "Traductor de LSM";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            Settings.Name = "Settings";
        }

        #endregion

        private PictureBox Logo;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Sound;
        private Button Settings;
        private ListBox LBLSM;
    }
}