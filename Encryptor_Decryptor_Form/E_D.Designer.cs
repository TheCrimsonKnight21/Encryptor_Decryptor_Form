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
            Message_Sent_Title = new Label();
            Message_Senf = new TextBox();
            Message_TickMark = new Button();
            SuspendLayout();
            // 
            // Message_Sent_Title
            // 
            Message_Sent_Title.AutoSize = true;
            Message_Sent_Title.Enabled = false;
            Message_Sent_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_Sent_Title.ForeColor = Color.White;
            Message_Sent_Title.Location = new Point(614, 118);
            Message_Sent_Title.Name = "Message_Sent_Title";
            Message_Sent_Title.Size = new Size(493, 55);
            Message_Sent_Title.TabIndex = 93;
            Message_Sent_Title.Text = "MESSAGE TO SEND";
            Message_Sent_Title.TextAlign = ContentAlignment.MiddleCenter;
            Message_Sent_Title.Visible = false;
            // 
            // Message_Senf
            // 
            Message_Senf.Enabled = false;
            Message_Senf.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_Senf.Location = new Point(350, 267);
            Message_Senf.Name = "Message_Senf";
            Message_Senf.Size = new Size(895, 48);
            Message_Senf.TabIndex = 95;
            Message_Senf.Visible = false;
            // 
            // Message_TickMark
            // 
            Message_TickMark.BackColor = Color.White;
            Message_TickMark.BackgroundImage = (Image)resources.GetObject("Message_TickMark.BackgroundImage");
            Message_TickMark.BackgroundImageLayout = ImageLayout.Center;
            Message_TickMark.Enabled = false;
            Message_TickMark.FlatStyle = FlatStyle.Popup;
            Message_TickMark.ForeColor = Color.Transparent;
            Message_TickMark.ImageAlign = ContentAlignment.TopCenter;
            Message_TickMark.Location = new Point(1266, 266);
            Message_TickMark.Name = "Message_TickMark";
            Message_TickMark.Size = new Size(48, 48);
            Message_TickMark.TabIndex = 94;
            Message_TickMark.UseVisualStyleBackColor = false;
            Message_TickMark.Visible = false;
            // 
            // E_D
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1664, 1011);
            Controls.Add(Message_Senf);
            Controls.Add(Message_TickMark);
            Controls.Add(Message_Sent_Title);
            Name = "E_D";
            Text = "E_D";
            Load += E_D_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Message_Sent_Title;
        private TextBox Message_Senf;
        private Button Message_TickMark;
    }
}