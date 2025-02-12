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
            File_Send_TickMark = new Button();
            Reset_Repository = new Button();
            SuspendLayout();
            // 
            // File_Send_TickMark
            // 
            File_Send_TickMark.BackColor = Color.White;
            File_Send_TickMark.BackgroundImage = (Image)resources.GetObject("File_Send_TickMark.BackgroundImage");
            File_Send_TickMark.BackgroundImageLayout = ImageLayout.Center;
            File_Send_TickMark.Enabled = false;
            File_Send_TickMark.FlatStyle = FlatStyle.Popup;
            File_Send_TickMark.ForeColor = Color.Transparent;
            File_Send_TickMark.ImageAlign = ContentAlignment.TopCenter;
            File_Send_TickMark.Location = new Point(1266, 266);
            File_Send_TickMark.Name = "File_Send_TickMark";
            File_Send_TickMark.Size = new Size(48, 48);
            File_Send_TickMark.TabIndex = 94;
            File_Send_TickMark.UseVisualStyleBackColor = false;
            File_Send_TickMark.Visible = false;
            // 
            // Reset_Repository
            // 
            Reset_Repository.Enabled = false;
            Reset_Repository.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reset_Repository.ForeColor = SystemColors.ActiveCaptionText;
            Reset_Repository.Location = new Point(639, 419);
            Reset_Repository.Name = "Reset_Repository";
            Reset_Repository.Size = new Size(387, 172);
            Reset_Repository.TabIndex = 98;
            Reset_Repository.TabStop = false;
            Reset_Repository.Text = "RESET REPOSITORY";
            Reset_Repository.UseVisualStyleBackColor = true;
            Reset_Repository.Visible = false;
            // 
            // E_D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1664, 1011);
            Controls.Add(Reset_Repository);
            Controls.Add(File_Send_TickMark);
            Name = "E_D";
            Text = "E_D";
            Load += E_D_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button File_Send_TickMark;
        private Button Reset_Repository;
    }
}