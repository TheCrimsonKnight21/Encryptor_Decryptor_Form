namespace Encryptor_Decryptor_Form
{
    partial class E_D
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(E_D));
            File_Symmetric_Decryption_Title = new Label();
            File_Decryption_Path = new TextBox();
            File_Key_Out = new Label();
            Success_File_Title = new Label();
            File_Decription_Title = new Label();
            File_Decryption_Key = new TextBox();
            File_Decryption_Tickmark = new Button();
            SuspendLayout();
            // 
            // File_Symmetric_Decryption_Title
            // 
            File_Symmetric_Decryption_Title.AutoSize = true;
            File_Symmetric_Decryption_Title.Enabled = false;
            File_Symmetric_Decryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Symmetric_Decryption_Title.ForeColor = Color.White;
            File_Symmetric_Decryption_Title.Location = new Point(447, 119);
            File_Symmetric_Decryption_Title.Name = "File_Symmetric_Decryption_Title";
            File_Symmetric_Decryption_Title.Size = new Size(814, 55);
            File_Symmetric_Decryption_Title.TabIndex = 36;
            File_Symmetric_Decryption_Title.Text = "PATH OF FILE FOR DECRYPTION:";
            File_Symmetric_Decryption_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Symmetric_Decryption_Title.Visible = false;
            // 
            // File_Decryption_Path
            // 
            File_Decryption_Path.Enabled = false;
            File_Decryption_Path.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decryption_Path.Location = new Point(385, 207);
            File_Decryption_Path.Name = "File_Decryption_Path";
            File_Decryption_Path.Size = new Size(895, 48);
            File_Decryption_Path.TabIndex = 38;
            File_Decryption_Path.Visible = false;
            // 
            // File_Key_Out
            // 
            File_Key_Out.Enabled = false;
            File_Key_Out.Font = new Font("Arial Rounded MT Bold", 30F);
            File_Key_Out.ForeColor = Color.White;
            File_Key_Out.Location = new Point(405, 626);
            File_Key_Out.Name = "File_Key_Out";
            File_Key_Out.Size = new Size(730, 55);
            File_Key_Out.TabIndex = 39;
            File_Key_Out.Visible = false;
            // 
            // Success_File_Title
            // 
            Success_File_Title.AutoSize = true;
            Success_File_Title.Enabled = false;
            Success_File_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Success_File_Title.ForeColor = Color.White;
            Success_File_Title.Location = new Point(385, 550);
            Success_File_Title.Name = "Success_File_Title";
            Success_File_Title.Size = new Size(842, 55);
            Success_File_Title.TabIndex = 41;
            Success_File_Title.Text = "FILE SUCCESSFULLY DECRIPTED!";
            Success_File_Title.Visible = false;
            Success_File_Title.Click += Success_Title_Click;
            // 
            // File_Decription_Title
            // 
            File_Decription_Title.AutoSize = true;
            File_Decription_Title.Enabled = false;
            File_Decription_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decription_Title.ForeColor = Color.White;
            File_Decription_Title.Location = new Point(447, 316);
            File_Decription_Title.Name = "File_Decription_Title";
            File_Decription_Title.Size = new Size(469, 55);
            File_Decription_Title.TabIndex = 42;
            File_Decription_Title.Text = "ENCRYPTION KEY:";
            File_Decription_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Decription_Title.Visible = false;
            // 
            // File_Decryption_Key
            // 
            File_Decryption_Key.Enabled = false;
            File_Decryption_Key.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decryption_Key.Location = new Point(385, 408);
            File_Decryption_Key.Name = "File_Decryption_Key";
            File_Decryption_Key.Size = new Size(895, 48);
            File_Decryption_Key.TabIndex = 43;
            File_Decryption_Key.Visible = false;
            // 
            // File_Decryption_Tickmark
            // 
            File_Decryption_Tickmark.BackColor = Color.White;
            File_Decryption_Tickmark.BackgroundImage = (Image)resources.GetObject("File_Decryption_Tickmark.BackgroundImage");
            File_Decryption_Tickmark.BackgroundImageLayout = ImageLayout.Center;
            File_Decryption_Tickmark.Enabled = false;
            File_Decryption_Tickmark.FlatStyle = FlatStyle.Popup;
            File_Decryption_Tickmark.ForeColor = Color.Transparent;
            File_Decryption_Tickmark.ImageAlign = ContentAlignment.TopCenter;
            File_Decryption_Tickmark.Location = new Point(668, 474);
            File_Decryption_Tickmark.Name = "File_Decryption_Tickmark";
            File_Decryption_Tickmark.Size = new Size(328, 48);
            File_Decryption_Tickmark.TabIndex = 44;
            File_Decryption_Tickmark.UseVisualStyleBackColor = false;
            File_Decryption_Tickmark.Visible = false;
            // 
            // E_D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1664, 1011);
            Controls.Add(File_Decryption_Tickmark);
            Controls.Add(File_Decription_Title);
            Controls.Add(File_Decryption_Key);
            Controls.Add(Success_File_Title);
            Controls.Add(File_Symmetric_Decryption_Title);
            Controls.Add(File_Decryption_Path);
            Controls.Add(File_Key_Out);
            Name = "E_D";
            Text = "E_D";
            Load += E_D_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label File_Symmetric_Decryption_Title;
        private TextBox File_Decryption_Path;
        private Label File_Key_Out;
        private Label Success_File_Title;
        private Label File_Decription_Title;
        private TextBox File_Decryption_Key;
        private Button File_Decryption_Tickmark;
    }
}