namespace Encryptor_Decryptor_Form
{
    partial class Settings
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
            Back = new Button();
            English_Button = new Button();
            Bulgarian_Button = new Button();
            Settings_Title = new Label();
            language_Label = new Label();
            Resolution_Label = new Label();
            Resolution_TrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Resolution_TrackBar).BeginInit();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Black;
            Back.Location = new Point(315, 402);
            Back.Name = "Back";
            Back.Size = new Size(194, 42);
            Back.TabIndex = 37;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // English_Button
            // 
            English_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            English_Button.ForeColor = Color.Black;
            English_Button.Location = new Point(195, 329);
            English_Button.Name = "English_Button";
            English_Button.Size = new Size(194, 42);
            English_Button.TabIndex = 38;
            English_Button.Text = "ENGLISH";
            English_Button.UseVisualStyleBackColor = true;
            English_Button.Click += English_Button_Click;
            // 
            // Bulgarian_Button
            // 
            Bulgarian_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bulgarian_Button.ForeColor = Color.Black;
            Bulgarian_Button.Location = new Point(436, 329);
            Bulgarian_Button.Name = "Bulgarian_Button";
            Bulgarian_Button.Size = new Size(194, 42);
            Bulgarian_Button.TabIndex = 40;
            Bulgarian_Button.Text = "BULGARIAN";
            Bulgarian_Button.UseVisualStyleBackColor = true;
            Bulgarian_Button.Click += Bulgarian_Button_Click;
            // 
            // Settings_Title
            // 
            Settings_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Settings_Title.ForeColor = Color.White;
            Settings_Title.Location = new Point(278, 9);
            Settings_Title.Name = "Settings_Title";
            Settings_Title.Size = new Size(269, 55);
            Settings_Title.TabIndex = 102;
            Settings_Title.Text = "SETTINGS";
            Settings_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // language_Label
            // 
            language_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            language_Label.ForeColor = Color.White;
            language_Label.Location = new Point(289, 262);
            language_Label.Name = "language_Label";
            language_Label.Size = new Size(246, 43);
            language_Label.TabIndex = 103;
            language_Label.Text = "LANGUAGE:";
            language_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resolution_Label
            // 
            Resolution_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Resolution_Label.ForeColor = Color.White;
            Resolution_Label.Location = new Point(273, 102);
            Resolution_Label.Name = "Resolution_Label";
            Resolution_Label.Size = new Size(279, 43);
            Resolution_Label.TabIndex = 104;
            Resolution_Label.Text = "RESOLUTION:";
            Resolution_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resolution_TrackBar
            // 
            Resolution_TrackBar.Location = new Point(195, 148);
            Resolution_TrackBar.Maximum = 3;
            Resolution_TrackBar.Minimum = 1;
            Resolution_TrackBar.Name = "Resolution_TrackBar";
            Resolution_TrackBar.Size = new Size(435, 45);
            Resolution_TrackBar.TabIndex = 105;
            Resolution_TrackBar.Value = 2;
            //Resolution_TrackBar.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(351, 181);
            label1.Name = "label1";
            label1.Size = new Size(127, 24);
            label1.TabIndex = 106;
            label1.Text = "1680 x 1050";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(147, 181);
            label2.Name = "label2";
            label2.Size = new Size(115, 24);
            label2.TabIndex = 107;
            label2.Text = "1280 x 720";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(555, 181);
            label3.Name = "label3";
            label3.Size = new Size(127, 24);
            label3.TabIndex = 108;
            label3.Text = "1980 x 1020";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(824, 486);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resolution_TrackBar);
            Controls.Add(Resolution_Label);
            Controls.Add(language_Label);
            Controls.Add(Settings_Title);
            Controls.Add(Bulgarian_Button);
            Controls.Add(English_Button);
            Controls.Add(Back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ((System.ComponentModel.ISupportInitialize)Resolution_TrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Button English_Button;
        private Button Bulgarian_Button;
        private Label Settings_Title;
        private Label language_Label;
        private Label Resolution_Label;
        private TrackBar Resolution_TrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}