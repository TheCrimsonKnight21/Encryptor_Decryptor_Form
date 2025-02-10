
namespace Encryptor_Decryptor_Form
{
    partial class StartUp_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp_Form));
            Title_Symmetric = new Label();
            Encrypt_Symmetric = new Button();
            Decrypt_Symmetric = new Button();
            ToStart = new Button();
            Symmetric_Encryption_Title = new Label();
            Direct_Symmetric = new Button();
            File_Symmetric = new Button();
            Direct_TextBox = new TextBox();
            Direct_Title = new Label();
            Direct_TickMark = new Button();
            Encrypted_message_label = new Label();
            Direct_Decryption_Message_Out = new Label();
            Encryption_key_label = new Label();
            Encryption_Key_Out = new Label();
            Copy_key = new Button();
            Copy_messge = new Button();
            Symmetric_Decryption_Title = new Label();
            Symmetric_Direct_Decryption = new Button();
            Symmetric_File_Decription = new Button();
            Direct_Decryption_Message = new TextBox();
            Direct_Decryption_Title3 = new Label();
            Copy_Decrypted = new Button();
            Direct_Decryption_Title = new Label();
            Direct_Decryption_Tickmark = new Button();
            Direct_Decryption_Key = new TextBox();
            Direct_Decryption_Title2 = new Label();
            Encrypt_Message_Out = new Label();
            Quit = new Button();
            GoBack = new Button();
            Asymmetric_StartUp = new Button();
            Symmetric_StartUp = new Button();
            Title_StartUp = new Label();
            Success_Title = new Label();
            File_Encryption_TickMark = new Button();
            File_Symmetric_Encryption_Title = new Label();
            File_Encryption_Path = new TextBox();
            File_Key_title = new Label();
            File_Key_Out = new Label();
            Copy_File_Key = new Button();
            File_Decryption_Tickmark = new Button();
            File_Decription_Title = new Label();
            File_Decryption_Key = new TextBox();
            Success_File_Title = new Label();
            File_Symmetric_Decryption_Title = new Label();
            File_Decryption_Path = new TextBox();
            SuspendLayout();
            // 
            // Title_Symmetric
            // 
            Title_Symmetric.AutoSize = true;
            Title_Symmetric.Enabled = false;
            Title_Symmetric.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_Symmetric.Location = new Point(493, 63);
            Title_Symmetric.Name = "Title_Symmetric";
            Title_Symmetric.Size = new Size(679, 55);
            Title_Symmetric.TabIndex = 7;
            Title_Symmetric.Text = "ENCYTION OR DECRIPTION";
            Title_Symmetric.TextAlign = ContentAlignment.MiddleCenter;
            Title_Symmetric.Visible = false;
            // 
            // Encrypt_Symmetric
            // 
            Encrypt_Symmetric.Enabled = false;
            Encrypt_Symmetric.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Encrypt_Symmetric.ForeColor = Color.Black;
            Encrypt_Symmetric.Location = new Point(313, 408);
            Encrypt_Symmetric.Name = "Encrypt_Symmetric";
            Encrypt_Symmetric.Size = new Size(387, 172);
            Encrypt_Symmetric.TabIndex = 9;
            Encrypt_Symmetric.Text = "ENCRYPTION";
            Encrypt_Symmetric.UseVisualStyleBackColor = true;
            Encrypt_Symmetric.Visible = false;
            Encrypt_Symmetric.Click += Encrypt_Symmetric_Click;
            // 
            // Decrypt_Symmetric
            // 
            Decrypt_Symmetric.Enabled = false;
            Decrypt_Symmetric.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Decrypt_Symmetric.ForeColor = SystemColors.ActiveCaptionText;
            Decrypt_Symmetric.Location = new Point(965, 408);
            Decrypt_Symmetric.Name = "Decrypt_Symmetric";
            Decrypt_Symmetric.Size = new Size(387, 172);
            Decrypt_Symmetric.TabIndex = 8;
            Decrypt_Symmetric.Text = "DECRYTION";
            Decrypt_Symmetric.UseVisualStyleBackColor = true;
            Decrypt_Symmetric.Visible = false;
            Decrypt_Symmetric.Click += Decrypt_Symmetric_Click;
            // 
            // ToStart
            // 
            ToStart.Enabled = false;
            ToStart.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ToStart.ForeColor = Color.Black;
            ToStart.Location = new Point(246, 724);
            ToStart.Name = "ToStart";
            ToStart.Size = new Size(387, 83);
            ToStart.TabIndex = 10;
            ToStart.Text = "TO START";
            ToStart.UseVisualStyleBackColor = true;
            ToStart.Visible = false;
            ToStart.Click += ToStart_Click;
            // 
            // Symmetric_Encryption_Title
            // 
            Symmetric_Encryption_Title.AutoSize = true;
            Symmetric_Encryption_Title.Enabled = false;
            Symmetric_Encryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symmetric_Encryption_Title.Location = new Point(461, 67);
            Symmetric_Encryption_Title.Name = "Symmetric_Encryption_Title";
            Symmetric_Encryption_Title.Size = new Size(742, 55);
            Symmetric_Encryption_Title.TabIndex = 11;
            Symmetric_Encryption_Title.Text = "DIRECT OR FILE ENCRPYTION";
            Symmetric_Encryption_Title.TextAlign = ContentAlignment.MiddleCenter;
            Symmetric_Encryption_Title.Visible = false;
            // 
            // Direct_Symmetric
            // 
            Direct_Symmetric.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Symmetric.ForeColor = Color.Black;
            Direct_Symmetric.Location = new Point(313, 408);
            Direct_Symmetric.Name = "Direct_Symmetric";
            Direct_Symmetric.Size = new Size(387, 172);
            Direct_Symmetric.TabIndex = 13;
            Direct_Symmetric.TabStop = false;
            Direct_Symmetric.Text = "DIRECT ENCRYPTION";
            Direct_Symmetric.UseVisualStyleBackColor = true;
            Direct_Symmetric.Visible = false;
            Direct_Symmetric.Click += Direct_Symmetric_Click;
            // 
            // File_Symmetric
            // 
            File_Symmetric.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Symmetric.ForeColor = SystemColors.ActiveCaptionText;
            File_Symmetric.Location = new Point(965, 408);
            File_Symmetric.Name = "File_Symmetric";
            File_Symmetric.Size = new Size(387, 172);
            File_Symmetric.TabIndex = 12;
            File_Symmetric.TabStop = false;
            File_Symmetric.Text = "FILE ENCRYPTION";
            File_Symmetric.UseVisualStyleBackColor = true;
            File_Symmetric.Visible = false;
            File_Symmetric.Click += File_Symmetric_Click;
            // 
            // Direct_TextBox
            // 
            Direct_TextBox.Enabled = false;
            Direct_TextBox.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_TextBox.Location = new Point(399, 195);
            Direct_TextBox.Name = "Direct_TextBox";
            Direct_TextBox.Size = new Size(895, 48);
            Direct_TextBox.TabIndex = 15;
            Direct_TextBox.Visible = false;
            // 
            // Direct_Title
            // 
            Direct_Title.AutoSize = true;
            Direct_Title.Enabled = false;
            Direct_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Title.ForeColor = Color.White;
            Direct_Title.Location = new Point(399, 67);
            Direct_Title.Name = "Direct_Title";
            Direct_Title.Size = new Size(895, 55);
            Direct_Title.TabIndex = 14;
            Direct_Title.Text = "WRITE MESSAGE FOR ENCRYPTING:";
            Direct_Title.Visible = false;
            // 
            // Direct_TickMark
            // 
            Direct_TickMark.BackColor = Color.White;
            Direct_TickMark.BackgroundImage = (Image)resources.GetObject("Direct_TickMark.BackgroundImage");
            Direct_TickMark.BackgroundImageLayout = ImageLayout.Center;
            Direct_TickMark.Enabled = false;
            Direct_TickMark.FlatStyle = FlatStyle.Popup;
            Direct_TickMark.ForeColor = Color.Transparent;
            Direct_TickMark.ImageAlign = ContentAlignment.TopCenter;
            Direct_TickMark.Location = new Point(1318, 195);
            Direct_TickMark.Name = "Direct_TickMark";
            Direct_TickMark.Size = new Size(48, 48);
            Direct_TickMark.TabIndex = 16;
            Direct_TickMark.UseVisualStyleBackColor = false;
            Direct_TickMark.Visible = false;
            Direct_TickMark.Click += Direct_TickMark_Click;
            // 
            // Encrypted_message_label
            // 
            Encrypted_message_label.AutoSize = true;
            Encrypted_message_label.Enabled = false;
            Encrypted_message_label.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Encrypted_message_label.ForeColor = Color.White;
            Encrypted_message_label.Location = new Point(399, 309);
            Encrypted_message_label.Name = "Encrypted_message_label";
            Encrypted_message_label.Size = new Size(591, 55);
            Encrypted_message_label.TabIndex = 17;
            Encrypted_message_label.Text = "ENCRYPTED MESSAGE:";
            Encrypted_message_label.Visible = false;
            // 
            // Direct_Decryption_Message_Out
            // 
            Direct_Decryption_Message_Out.Enabled = false;
            Direct_Decryption_Message_Out.Font = new Font("Arial Rounded MT Bold", 30F);
            Direct_Decryption_Message_Out.ForeColor = Color.White;
            Direct_Decryption_Message_Out.Location = new Point(419, 547);
            Direct_Decryption_Message_Out.Name = "Direct_Decryption_Message_Out";
            Direct_Decryption_Message_Out.Size = new Size(730, 55);
            Direct_Decryption_Message_Out.TabIndex = 18;
            Direct_Decryption_Message_Out.Visible = false;
            // 
            // Encryption_key_label
            // 
            Encryption_key_label.AutoSize = true;
            Encryption_key_label.Enabled = false;
            Encryption_key_label.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Encryption_key_label.ForeColor = Color.White;
            Encryption_key_label.Location = new Point(399, 500);
            Encryption_key_label.Name = "Encryption_key_label";
            Encryption_key_label.Size = new Size(469, 55);
            Encryption_key_label.TabIndex = 19;
            Encryption_key_label.Text = "ENCRYPTION KEY:";
            Encryption_key_label.Visible = false;
            // 
            // Encryption_Key_Out
            // 
            Encryption_Key_Out.Enabled = false;
            Encryption_Key_Out.Font = new Font("Arial Rounded MT Bold", 30F);
            Encryption_Key_Out.ForeColor = Color.White;
            Encryption_Key_Out.Location = new Point(399, 555);
            Encryption_Key_Out.Name = "Encryption_Key_Out";
            Encryption_Key_Out.Size = new Size(730, 55);
            Encryption_Key_Out.TabIndex = 20;
            Encryption_Key_Out.Visible = false;
            // 
            // Copy_key
            // 
            Copy_key.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copy_key.ForeColor = Color.Black;
            Copy_key.Location = new Point(399, 613);
            Copy_key.Name = "Copy_key";
            Copy_key.Size = new Size(452, 45);
            Copy_key.TabIndex = 21;
            Copy_key.TabStop = false;
            Copy_key.Text = "COPY KEY TO CLIPBOARD";
            Copy_key.UseVisualStyleBackColor = true;
            Copy_key.Visible = false;
            Copy_key.Click += Copy_key_Click;
            // 
            // Copy_messge
            // 
            Copy_messge.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copy_messge.ForeColor = Color.Black;
            Copy_messge.Location = new Point(399, 433);
            Copy_messge.Name = "Copy_messge";
            Copy_messge.Size = new Size(452, 45);
            Copy_messge.TabIndex = 22;
            Copy_messge.TabStop = false;
            Copy_messge.Text = "COPY MESSAGE TO CLIPBOARD";
            Copy_messge.UseVisualStyleBackColor = true;
            Copy_messge.Visible = false;
            Copy_messge.Click += Copy_messge_Click;
            // 
            // Symmetric_Decryption_Title
            // 
            Symmetric_Decryption_Title.AutoSize = true;
            Symmetric_Decryption_Title.Enabled = false;
            Symmetric_Decryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symmetric_Decryption_Title.Location = new Point(461, 67);
            Symmetric_Decryption_Title.Name = "Symmetric_Decryption_Title";
            Symmetric_Decryption_Title.Size = new Size(742, 55);
            Symmetric_Decryption_Title.TabIndex = 23;
            Symmetric_Decryption_Title.Text = "DIRECT OR FILE DECRPYTION";
            Symmetric_Decryption_Title.TextAlign = ContentAlignment.MiddleCenter;
            Symmetric_Decryption_Title.Visible = false;
            // 
            // Symmetric_Direct_Decryption
            // 
            Symmetric_Direct_Decryption.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symmetric_Direct_Decryption.ForeColor = Color.Black;
            Symmetric_Direct_Decryption.Location = new Point(313, 408);
            Symmetric_Direct_Decryption.Name = "Symmetric_Direct_Decryption";
            Symmetric_Direct_Decryption.Size = new Size(387, 172);
            Symmetric_Direct_Decryption.TabIndex = 25;
            Symmetric_Direct_Decryption.TabStop = false;
            Symmetric_Direct_Decryption.Text = "DIRECT DECRYPTION";
            Symmetric_Direct_Decryption.UseVisualStyleBackColor = true;
            Symmetric_Direct_Decryption.Visible = false;
            Symmetric_Direct_Decryption.Click += Symmetric_Direct_Decryption_Click;
            // 
            // Symmetric_File_Decription
            // 
            Symmetric_File_Decription.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symmetric_File_Decription.ForeColor = SystemColors.ActiveCaptionText;
            Symmetric_File_Decription.Location = new Point(965, 408);
            Symmetric_File_Decription.Name = "Symmetric_File_Decription";
            Symmetric_File_Decription.Size = new Size(387, 172);
            Symmetric_File_Decription.TabIndex = 24;
            Symmetric_File_Decription.TabStop = false;
            Symmetric_File_Decription.Text = "FILE DECRYPTION";
            Symmetric_File_Decription.UseVisualStyleBackColor = true;
            Symmetric_File_Decription.Visible = false;
            Symmetric_File_Decription.Click += Symmetric_File_Decription_Click;
            // 
            // Direct_Decryption_Message
            // 
            Direct_Decryption_Message.Enabled = false;
            Direct_Decryption_Message.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Decryption_Message.Location = new Point(399, 180);
            Direct_Decryption_Message.Name = "Direct_Decryption_Message";
            Direct_Decryption_Message.Size = new Size(895, 48);
            Direct_Decryption_Message.TabIndex = 28;
            Direct_Decryption_Message.Visible = false;
            // 
            // Direct_Decryption_Title3
            // 
            Direct_Decryption_Title3.AutoSize = true;
            Direct_Decryption_Title3.Enabled = false;
            Direct_Decryption_Title3.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Decryption_Title3.ForeColor = Color.White;
            Direct_Decryption_Title3.Location = new Point(399, 481);
            Direct_Decryption_Title3.Name = "Direct_Decryption_Title3";
            Direct_Decryption_Title3.Size = new Size(591, 55);
            Direct_Decryption_Title3.TabIndex = 30;
            Direct_Decryption_Title3.Text = "DECRYPTED MESSAGE:";
            Direct_Decryption_Title3.Visible = false;
            // 
            // Copy_Decrypted
            // 
            Copy_Decrypted.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copy_Decrypted.ForeColor = Color.Black;
            Copy_Decrypted.Location = new Point(399, 605);
            Copy_Decrypted.Name = "Copy_Decrypted";
            Copy_Decrypted.Size = new Size(452, 45);
            Copy_Decrypted.TabIndex = 31;
            Copy_Decrypted.TabStop = false;
            Copy_Decrypted.Text = "COPY MESSAGE TO CLIPBOARD";
            Copy_Decrypted.UseVisualStyleBackColor = true;
            Copy_Decrypted.Visible = false;
            Copy_Decrypted.Click += Copy_Decrypted_Click;
            // 
            // Direct_Decryption_Title
            // 
            Direct_Decryption_Title.AutoSize = true;
            Direct_Decryption_Title.Enabled = false;
            Direct_Decryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Decryption_Title.ForeColor = Color.White;
            Direct_Decryption_Title.Location = new Point(399, 67);
            Direct_Decryption_Title.Name = "Direct_Decryption_Title";
            Direct_Decryption_Title.Size = new Size(895, 55);
            Direct_Decryption_Title.TabIndex = 27;
            Direct_Decryption_Title.Text = "WRITE MESSAGE FOR DECRYPTING:";
            Direct_Decryption_Title.Visible = false;
            // 
            // Direct_Decryption_Tickmark
            // 
            Direct_Decryption_Tickmark.BackColor = Color.White;
            Direct_Decryption_Tickmark.BackgroundImage = (Image)resources.GetObject("Direct_Decryption_Tickmark.BackgroundImage");
            Direct_Decryption_Tickmark.BackgroundImageLayout = ImageLayout.Center;
            Direct_Decryption_Tickmark.Enabled = false;
            Direct_Decryption_Tickmark.FlatStyle = FlatStyle.Popup;
            Direct_Decryption_Tickmark.ForeColor = Color.Transparent;
            Direct_Decryption_Tickmark.ImageAlign = ContentAlignment.TopCenter;
            Direct_Decryption_Tickmark.Location = new Point(668, 412);
            Direct_Decryption_Tickmark.Name = "Direct_Decryption_Tickmark";
            Direct_Decryption_Tickmark.Size = new Size(328, 48);
            Direct_Decryption_Tickmark.TabIndex = 34;
            Direct_Decryption_Tickmark.UseVisualStyleBackColor = false;
            Direct_Decryption_Tickmark.Visible = false;
            Direct_Decryption_Tickmark.Click += Direct_Decryption_Tickmark_Click;
            // 
            // Direct_Decryption_Key
            // 
            Direct_Decryption_Key.Enabled = false;
            Direct_Decryption_Key.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Decryption_Key.Location = new Point(399, 358);
            Direct_Decryption_Key.Name = "Direct_Decryption_Key";
            Direct_Decryption_Key.Size = new Size(895, 48);
            Direct_Decryption_Key.TabIndex = 33;
            Direct_Decryption_Key.Visible = false;
            // 
            // Direct_Decryption_Title2
            // 
            Direct_Decryption_Title2.AutoSize = true;
            Direct_Decryption_Title2.Enabled = false;
            Direct_Decryption_Title2.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Direct_Decryption_Title2.ForeColor = Color.White;
            Direct_Decryption_Title2.Location = new Point(405, 245);
            Direct_Decryption_Title2.Name = "Direct_Decryption_Title2";
            Direct_Decryption_Title2.Size = new Size(638, 55);
            Direct_Decryption_Title2.TabIndex = 32;
            Direct_Decryption_Title2.Text = "WRITE DECRYPTION KEY:";
            Direct_Decryption_Title2.Visible = false;
            // 
            // Encrypt_Message_Out
            // 
            Encrypt_Message_Out.Enabled = false;
            Encrypt_Message_Out.Font = new Font("Arial Rounded MT Bold", 30F);
            Encrypt_Message_Out.ForeColor = Color.White;
            Encrypt_Message_Out.Location = new Point(419, 364);
            Encrypt_Message_Out.Name = "Encrypt_Message_Out";
            Encrypt_Message_Out.Size = new Size(730, 55);
            Encrypt_Message_Out.TabIndex = 35;
            Encrypt_Message_Out.Visible = false;
            // 
            // Quit
            // 
            Quit.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.Black;
            Quit.Location = new Point(639, 724);
            Quit.Name = "Quit";
            Quit.Size = new Size(387, 83);
            Quit.TabIndex = 36;
            Quit.Text = "QUIT";
            Quit.UseVisualStyleBackColor = true;
            Quit.Click += Quit_Click;
            // 
            // GoBack
            // 
            GoBack.Enabled = false;
            GoBack.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoBack.ForeColor = Color.Black;
            GoBack.Location = new Point(1032, 724);
            GoBack.Name = "GoBack";
            GoBack.Size = new Size(387, 83);
            GoBack.TabIndex = 37;
            GoBack.Text = "GO BACK";
            GoBack.UseVisualStyleBackColor = true;
            GoBack.Visible = false;
            GoBack.Click += GoBack_Click;
            // 
            // Asymmetric_StartUp
            // 
            Asymmetric_StartUp.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Asymmetric_StartUp.ForeColor = SystemColors.ActiveCaptionText;
            Asymmetric_StartUp.Location = new Point(965, 408);
            Asymmetric_StartUp.Name = "Asymmetric_StartUp";
            Asymmetric_StartUp.Size = new Size(387, 172);
            Asymmetric_StartUp.TabIndex = 2;
            Asymmetric_StartUp.Text = "ASYMMETRIC ENCRYPTION/DECRYTION";
            Asymmetric_StartUp.UseVisualStyleBackColor = true;
            Asymmetric_StartUp.Click += Asymmetric_Click;
            // 
            // Symmetric_StartUp
            // 
            Symmetric_StartUp.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Symmetric_StartUp.ForeColor = Color.Black;
            Symmetric_StartUp.Location = new Point(313, 408);
            Symmetric_StartUp.Name = "Symmetric_StartUp";
            Symmetric_StartUp.Size = new Size(387, 172);
            Symmetric_StartUp.TabIndex = 3;
            Symmetric_StartUp.Text = "SYMMETRIC ENCRYPTION/DECRYTION";
            Symmetric_StartUp.UseVisualStyleBackColor = true;
            Symmetric_StartUp.Click += Symmetric_Click;
            // 
            // Title_StartUp
            // 
            Title_StartUp.AutoSize = true;
            Title_StartUp.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_StartUp.Location = new Point(399, 67);
            Title_StartUp.Name = "Title_StartUp";
            Title_StartUp.Size = new Size(866, 110);
            Title_StartUp.TabIndex = 0;
            Title_StartUp.Text = "WELCOME TO \r\nTHE ENCRYPTOR/DECRYPTOR APP";
            Title_StartUp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Success_Title
            // 
            Success_Title.AutoSize = true;
            Success_Title.Enabled = false;
            Success_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Success_Title.ForeColor = Color.White;
            Success_Title.Location = new Point(399, 354);
            Success_Title.Name = "Success_Title";
            Success_Title.Size = new Size(842, 55);
            Success_Title.TabIndex = 47;
            Success_Title.Text = "FILE SUCCESSFULLY ENCRIPTED!";
            Success_Title.Visible = false;
            // 
            // File_Encryption_TickMark
            // 
            File_Encryption_TickMark.BackColor = Color.White;
            File_Encryption_TickMark.BackgroundImage = (Image)resources.GetObject("File_Encryption_TickMark.BackgroundImage");
            File_Encryption_TickMark.BackgroundImageLayout = ImageLayout.Center;
            File_Encryption_TickMark.Enabled = false;
            File_Encryption_TickMark.FlatStyle = FlatStyle.Popup;
            File_Encryption_TickMark.ForeColor = Color.Transparent;
            File_Encryption_TickMark.ImageAlign = ContentAlignment.TopCenter;
            File_Encryption_TickMark.Location = new Point(1315, 194);
            File_Encryption_TickMark.Name = "File_Encryption_TickMark";
            File_Encryption_TickMark.Size = new Size(48, 48);
            File_Encryption_TickMark.TabIndex = 46;
            File_Encryption_TickMark.UseVisualStyleBackColor = false;
            File_Encryption_TickMark.Visible = false;
            File_Encryption_TickMark.Click += File_Encryption_TickMark_Click;
            // 
            // File_Symmetric_Encryption_Title
            // 
            File_Symmetric_Encryption_Title.AutoSize = true;
            File_Symmetric_Encryption_Title.Enabled = false;
            File_Symmetric_Encryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Symmetric_Encryption_Title.ForeColor = Color.White;
            File_Symmetric_Encryption_Title.Location = new Point(461, 81);
            File_Symmetric_Encryption_Title.Name = "File_Symmetric_Encryption_Title";
            File_Symmetric_Encryption_Title.Size = new Size(814, 55);
            File_Symmetric_Encryption_Title.TabIndex = 42;
            File_Symmetric_Encryption_Title.Text = "PATH OF FILE FOR ENCRYPTION:";
            File_Symmetric_Encryption_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Symmetric_Encryption_Title.Visible = false;
            // 
            // File_Encryption_Path
            // 
            File_Encryption_Path.Enabled = false;
            File_Encryption_Path.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Encryption_Path.Location = new Point(399, 194);
            File_Encryption_Path.Name = "File_Encryption_Path";
            File_Encryption_Path.Size = new Size(895, 48);
            File_Encryption_Path.TabIndex = 44;
            File_Encryption_Path.Visible = false;
            // 
            // File_Key_title
            // 
            File_Key_title.AutoSize = true;
            File_Key_title.Enabled = false;
            File_Key_title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Key_title.ForeColor = Color.White;
            File_Key_title.Location = new Point(399, 533);
            File_Key_title.Name = "File_Key_title";
            File_Key_title.Size = new Size(469, 55);
            File_Key_title.TabIndex = 43;
            File_Key_title.Text = "ENCRYPTION KEY:";
            File_Key_title.Visible = false;
            // 
            // File_Key_Out
            // 
            File_Key_Out.Enabled = false;
            File_Key_Out.Font = new Font("Arial Rounded MT Bold", 30F);
            File_Key_Out.ForeColor = Color.White;
            File_Key_Out.Location = new Point(419, 588);
            File_Key_Out.Name = "File_Key_Out";
            File_Key_Out.Size = new Size(730, 55);
            File_Key_Out.TabIndex = 45;
            File_Key_Out.Visible = false;
            // 
            // Copy_File_Key
            // 
            Copy_File_Key.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Copy_File_Key.ForeColor = Color.Black;
            Copy_File_Key.Location = new Point(419, 646);
            Copy_File_Key.Name = "Copy_File_Key";
            Copy_File_Key.Size = new Size(452, 45);
            Copy_File_Key.TabIndex = 48;
            Copy_File_Key.TabStop = false;
            Copy_File_Key.Text = "COPY KEY TO CLIPBOARD";
            Copy_File_Key.UseVisualStyleBackColor = true;
            Copy_File_Key.Visible = false;
            Copy_File_Key.Click += Copy_File_Key_Click;
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
            File_Decryption_Tickmark.Location = new Point(668, 412);
            File_Decryption_Tickmark.Name = "File_Decryption_Tickmark";
            File_Decryption_Tickmark.Size = new Size(328, 48);
            File_Decryption_Tickmark.TabIndex = 54;
            File_Decryption_Tickmark.UseVisualStyleBackColor = false;
            File_Decryption_Tickmark.Visible = false;
            File_Decryption_Tickmark.Click += File_Decryption_Tickmark_Click;
            // 
            // File_Decription_Title
            // 
            File_Decription_Title.AutoSize = true;
            File_Decription_Title.Enabled = false;
            File_Decription_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decription_Title.ForeColor = Color.White;
            File_Decription_Title.Location = new Point(405, 246);
            File_Decription_Title.Name = "File_Decription_Title";
            File_Decription_Title.Size = new Size(638, 55);
            File_Decription_Title.TabIndex = 52;
            File_Decription_Title.Text = "WRITE DECRYPTION KEY:";
            File_Decription_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Decription_Title.Visible = false;
            // 
            // File_Decryption_Key
            // 
            File_Decryption_Key.Enabled = false;
            File_Decryption_Key.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decryption_Key.Location = new Point(399, 358);
            File_Decryption_Key.Name = "File_Decryption_Key";
            File_Decryption_Key.Size = new Size(895, 48);
            File_Decryption_Key.TabIndex = 53;
            File_Decryption_Key.Visible = false;
            // 
            // Success_File_Title
            // 
            Success_File_Title.AutoSize = true;
            Success_File_Title.Enabled = false;
            Success_File_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Success_File_Title.ForeColor = Color.White;
            Success_File_Title.Location = new Point(399, 500);
            Success_File_Title.Name = "Success_File_Title";
            Success_File_Title.Size = new Size(842, 55);
            Success_File_Title.TabIndex = 51;
            Success_File_Title.Text = "FILE SUCCESSFULLY DECRIPTED!";
            Success_File_Title.Visible = false;
            // 
            // File_Symmetric_Decryption_Title
            // 
            File_Symmetric_Decryption_Title.AutoSize = true;
            File_Symmetric_Decryption_Title.Enabled = false;
            File_Symmetric_Decryption_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Symmetric_Decryption_Title.ForeColor = Color.White;
            File_Symmetric_Decryption_Title.Location = new Point(461, 81);
            File_Symmetric_Decryption_Title.Name = "File_Symmetric_Decryption_Title";
            File_Symmetric_Decryption_Title.Size = new Size(814, 55);
            File_Symmetric_Decryption_Title.TabIndex = 49;
            File_Symmetric_Decryption_Title.Text = "PATH OF FILE FOR DECRYPTION:";
            File_Symmetric_Decryption_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Symmetric_Decryption_Title.Visible = false;
            // 
            // File_Decryption_Path
            // 
            File_Decryption_Path.Enabled = false;
            File_Decryption_Path.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Decryption_Path.Location = new Point(399, 195);
            File_Decryption_Path.Name = "File_Decryption_Path";
            File_Decryption_Path.Size = new Size(895, 48);
            File_Decryption_Path.TabIndex = 50;
            File_Decryption_Path.Visible = false;
            // 
            // StartUp_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1664, 1011);
            Controls.Add(File_Decryption_Tickmark);
            Controls.Add(File_Decription_Title);
            Controls.Add(File_Decryption_Key);
            Controls.Add(Success_File_Title);
            Controls.Add(File_Symmetric_Decryption_Title);
            Controls.Add(File_Decryption_Path);
            Controls.Add(Copy_File_Key);
            Controls.Add(Success_Title);
            Controls.Add(File_Encryption_TickMark);
            Controls.Add(File_Symmetric_Encryption_Title);
            Controls.Add(File_Encryption_Path);
            Controls.Add(File_Key_title);
            Controls.Add(File_Key_Out);
            Controls.Add(Symmetric_Encryption_Title);
            Controls.Add(GoBack);
            Controls.Add(Quit);
            Controls.Add(ToStart);
            Controls.Add(Direct_TickMark);
            Controls.Add(Direct_Title);
            Controls.Add(Direct_Decryption_Title);
            Controls.Add(Title_Symmetric);
            Controls.Add(Symmetric_Decryption_Title);
            Controls.Add(Direct_Decryption_Message);
            Controls.Add(Symmetric_File_Decription);
            Controls.Add(Encrypted_message_label);
            Controls.Add(Direct_Decryption_Title2);
            Controls.Add(Direct_Decryption_Key);
            Controls.Add(Direct_TextBox);
            Controls.Add(Symmetric_StartUp);
            Controls.Add(Symmetric_Direct_Decryption);
            Controls.Add(Copy_messge);
            Controls.Add(Copy_key);
            Controls.Add(Encryption_key_label);
            Controls.Add(Direct_Decryption_Title3);
            Controls.Add(Encrypt_Message_Out);
            Controls.Add(Direct_Decryption_Message_Out);
            Controls.Add(Direct_Decryption_Tickmark);
            Controls.Add(Copy_Decrypted);
            Controls.Add(Encryption_Key_Out);
            Controls.Add(File_Symmetric);
            Controls.Add(Direct_Symmetric);
            Controls.Add(Decrypt_Symmetric);
            Controls.Add(Encrypt_Symmetric);
            Controls.Add(Asymmetric_StartUp);
            Controls.Add(Title_StartUp);
            ForeColor = SystemColors.ButtonFace;
            Name = "StartUp_Form";
            Text = "StartUp";
            Load += StartUp_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title_Symmetric;
        private Button Encrypt_Symmetric;
        private Button Decrypt_Symmetric;
        private Button ToStart;
        private Label Symmetric_Encryption_Title;
        private Button Direct_Symmetric;
        private Button File_Symmetric;
        private TextBox Direct_TextBox;
        private Label Direct_Title;
        private Button Direct_TickMark;
        private Label Encrypted_message_label;
        private Label Direct_Decryption_Message_Out;
        private Label Encryption_key_label;
        private Label Encryption_Key_Out;
        private Button Copy_key;
        private Button Copy_messge;
        private Label Symmetric_Decryption_Title;
        private Button Symmetric_Direct_Decryption;
        private Button Symmetric_File_Decription;
        private Button Direct_Decryption_Message_Tickmark;
        private TextBox Direct_Decryption_Message;
        private Label Direct_Decryption_Title3;
        private Button Copy_Decrypted;
        private Label Direct_Decryption_Title;
        private Button Direct_Decryption_Tickmark;
        private TextBox Direct_Decryption_Key;
        private Label Direct_Decryption_Title2;
        private Label Encrypt_Message_Out;
        private Button Quit;
        private Button GoBack;
        private Button Asymmetric_StartUp;
        private Button Symmetric_StartUp;
        private Label Title_StartUp;
        private Label Success_Title;
        private Button File_Encryption_TickMark;
        private Label File_Symmetric_Encryption_Title;
        private TextBox File_Encryption_Path;
        private Label File_Key_title;
        private Label File_Key_Out;
        private Button Copy_File_Key;
        private Button File_Decryption_Tickmark;
        private Label File_Decription_Title;
        private TextBox File_Decryption_Key;
        private Label Success_File_Title;
        private Label File_Symmetric_Decryption_Title;
        private TextBox File_Decryption_Path;
    }
}
