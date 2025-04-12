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
            Display_Label = new Label();
            Fullscreen_Button = new Button();
            Windowed_Button = new Button();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Back.ForeColor = Color.Black;
            Back.Location = new Point(360, 536);
            Back.Margin = new Padding(3, 4, 3, 4);
            Back.Name = "Back";
            Back.Size = new Size(222, 56);
            Back.TabIndex = 37;
            Back.Text = "BACK";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // English_Button
            // 
            English_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            English_Button.ForeColor = Color.Black;
            English_Button.Location = new Point(212, 216);
            English_Button.Margin = new Padding(3, 4, 3, 4);
            English_Button.Name = "English_Button";
            English_Button.Size = new Size(233, 56);
            English_Button.TabIndex = 38;
            English_Button.Text = "ENGLISH";
            English_Button.UseVisualStyleBackColor = true;
            English_Button.Click += English_Button_Click;
            // 
            // Bulgarian_Button
            // 
            Bulgarian_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Bulgarian_Button.ForeColor = Color.Black;
            Bulgarian_Button.Location = new Point(498, 216);
            Bulgarian_Button.Margin = new Padding(3, 4, 3, 4);
            Bulgarian_Button.Name = "Bulgarian_Button";
            Bulgarian_Button.Size = new Size(233, 56);
            Bulgarian_Button.TabIndex = 40;
            Bulgarian_Button.Text = "BULGARIAN";
            Bulgarian_Button.UseVisualStyleBackColor = true;
            Bulgarian_Button.Click += Bulgarian_Button_Click;
            // 
            // Settings_Title
            // 
            Settings_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Settings_Title.ForeColor = Color.White;
            Settings_Title.Location = new Point(232, 12);
            Settings_Title.Name = "Settings_Title";
            Settings_Title.Size = new Size(478, 73);
            Settings_Title.TabIndex = 102;
            Settings_Title.Text = "SETTINGS";
            Settings_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // language_Label
            // 
            language_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            language_Label.ForeColor = Color.White;
            language_Label.Location = new Point(330, 127);
            language_Label.Name = "language_Label";
            language_Label.Size = new Size(281, 57);
            language_Label.TabIndex = 103;
            language_Label.Text = "LANGUAGE:";
            language_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Display_Label
            // 
            Display_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display_Label.ForeColor = Color.White;
            Display_Label.Location = new Point(281, 296);
            Display_Label.Name = "Display_Label";
            Display_Label.Size = new Size(379, 57);
            Display_Label.TabIndex = 104;
            Display_Label.Text = "DISPLAY MODE:";
            Display_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fullscreen_Button
            // 
            Fullscreen_Button.AutoSize = true;
            Fullscreen_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fullscreen_Button.ForeColor = Color.Black;
            Fullscreen_Button.Location = new Point(498, 377);
            Fullscreen_Button.Margin = new Padding(3, 4, 3, 4);
            Fullscreen_Button.Name = "Fullscreen_Button";
            Fullscreen_Button.Size = new Size(260, 56);
            Fullscreen_Button.TabIndex = 106;
            Fullscreen_Button.Text = "FULLSCREEN";
            Fullscreen_Button.UseVisualStyleBackColor = true;
            Fullscreen_Button.Click += Fullscreen_Button_Click;
            // 
            // Windowed_Button
            // 
            Windowed_Button.AutoSize = true;
            Windowed_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Windowed_Button.ForeColor = Color.Black;
            Windowed_Button.Location = new Point(185, 377);
            Windowed_Button.Margin = new Padding(3, 4, 3, 4);
            Windowed_Button.Name = "Windowed_Button";
            Windowed_Button.Size = new Size(260, 56);
            Windowed_Button.TabIndex = 105;
            Windowed_Button.Text = "WINDOWED";
            Windowed_Button.UseVisualStyleBackColor = true;
            Windowed_Button.Click += Windowed_Button_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(942, 648);
            Controls.Add(Fullscreen_Button);
            Controls.Add(Windowed_Button);
            Controls.Add(Display_Label);
            Controls.Add(language_Label);
            Controls.Add(Settings_Title);
            Controls.Add(Bulgarian_Button);
            Controls.Add(English_Button);
            Controls.Add(Back);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Button English_Button;
        private Button Bulgarian_Button;
        private Label Settings_Title;
        private Label language_Label;
        private Label Display_Label;
        private Button Fullscreen_Button;
        private Button Windowed_Button;
    }
}