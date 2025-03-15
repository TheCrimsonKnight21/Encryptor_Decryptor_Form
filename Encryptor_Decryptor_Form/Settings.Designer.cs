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
            English_Button.Location = new Point(195, 162);
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
            Bulgarian_Button.Location = new Point(436, 162);
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
            Settings_Title.Location = new Point(203, 9);
            Settings_Title.Name = "Settings_Title";
            Settings_Title.Size = new Size(418, 55);
            Settings_Title.TabIndex = 102;
            Settings_Title.Text = "SETTINGS";
            Settings_Title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // language_Label
            // 
            language_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            language_Label.ForeColor = Color.White;
            language_Label.Location = new Point(289, 95);
            language_Label.Name = "language_Label";
            language_Label.Size = new Size(246, 43);
            language_Label.TabIndex = 103;
            language_Label.Text = "LANGUAGE:";
            language_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Display_Label
            // 
            Display_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Display_Label.ForeColor = Color.White;
            Display_Label.Location = new Point(246, 222);
            Display_Label.Name = "Display_Label";
            Display_Label.Size = new Size(332, 43);
            Display_Label.TabIndex = 104;
            Display_Label.Text = "DISPLAY MODE:";
            Display_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Fullscreen_Button
            // 
            Fullscreen_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fullscreen_Button.ForeColor = Color.Black;
            Fullscreen_Button.Location = new Point(436, 286);
            Fullscreen_Button.Name = "Fullscreen_Button";
            Fullscreen_Button.Size = new Size(194, 42);
            Fullscreen_Button.TabIndex = 106;
            Fullscreen_Button.Text = "FULLSCREEN";
            Fullscreen_Button.UseVisualStyleBackColor = true;
            Fullscreen_Button.Click += Fullscreen_Button_Click;
            // 
            // Windowed_Button
            // 
            Windowed_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Windowed_Button.ForeColor = Color.Black;
            Windowed_Button.Location = new Point(195, 286);
            Windowed_Button.Name = "Windowed_Button";
            Windowed_Button.Size = new Size(194, 42);
            Windowed_Button.TabIndex = 105;
            Windowed_Button.Text = "WINDOWED";
            Windowed_Button.UseVisualStyleBackColor = true;
            Windowed_Button.Click += Windowed_Button_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(824, 486);
            Controls.Add(Fullscreen_Button);
            Controls.Add(Windowed_Button);
            Controls.Add(Display_Label);
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
            ResumeLayout(false);
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