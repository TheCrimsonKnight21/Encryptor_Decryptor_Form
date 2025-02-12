
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
            Create_account = new Button();
            Login = new Button();
            Title_Assymetric_Encryption = new Label();
            Incorrect_Password = new Label();
            Account_Not_Found = new Label();
            Password_Label = new Label();
            Username_Label = new Label();
            Password_Textbox = new TextBox();
            Username_Textbox = new TextBox();
            Login_Button = new Button();
            Login_Title = new Label();
            Username_Error = new Label();
            Password_Error = new Label();
            Create_Account_Button = new Button();
            Account_Already_Exists = new Label();
            Create_Account_Title = new Label();
            Username_Spaces = new Label();
            Empty_Password = new Label();
            Empty_Username = new Label();
            Password_Spaces = new Label();
            Password_Length = new Label();
            Username_Length = new Label();
            Log_Out = new Button();
            Send = new Button();
            Read_Inbox = new Button();
            Unread_Label = new Label();
            User_Title = new Label();
            Inbox = new ListView();
            Inbox_Title = new Label();
            Recipient_Not_Found = new Label();
            Send_Title = new Label();
            Recipient_Name = new TextBox();
            Recipient_TickMark = new Button();
            Recipient_Error = new Label();
            Choose_Title = new Label();
            Send_File = new Button();
            Send_Message = new Button();
            Message_Send = new TextBox();
            Message_TickMark = new Button();
            Message_Sent_Title = new Label();
            File_Send_Path = new TextBox();
            File_Send_TickMark = new Button();
            File_Send_Title = new Label();
            File_Send_Success = new Label();
            Message_Send_Success = new Label();
            Admin_Button = new Label();
            Reset_Repository = new Button();
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
            // Create_account
            // 
            Create_account.Enabled = false;
            Create_account.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Create_account.ForeColor = SystemColors.ActiveCaptionText;
            Create_account.Location = new Point(639, 515);
            Create_account.Name = "Create_account";
            Create_account.Size = new Size(387, 172);
            Create_account.TabIndex = 57;
            Create_account.TabStop = false;
            Create_account.Text = "CREATE ACCOUNT";
            Create_account.UseVisualStyleBackColor = true;
            Create_account.Visible = false;
            Create_account.Click += Create_account_Click;
            // 
            // Login
            // 
            Login.Enabled = false;
            Login.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(639, 274);
            Login.Name = "Login";
            Login.Size = new Size(387, 172);
            Login.TabIndex = 56;
            Login.Text = "LOGIN";
            Login.UseVisualStyleBackColor = true;
            Login.Visible = false;
            Login.Click += Login_Click;
            // 
            // Title_Assymetric_Encryption
            // 
            Title_Assymetric_Encryption.AutoSize = true;
            Title_Assymetric_Encryption.Enabled = false;
            Title_Assymetric_Encryption.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title_Assymetric_Encryption.ForeColor = Color.White;
            Title_Assymetric_Encryption.Location = new Point(464, 127);
            Title_Assymetric_Encryption.Name = "Title_Assymetric_Encryption";
            Title_Assymetric_Encryption.Size = new Size(737, 55);
            Title_Assymetric_Encryption.TabIndex = 55;
            Title_Assymetric_Encryption.Text = "ASSYMETRICAL ENCRYPTION";
            Title_Assymetric_Encryption.TextAlign = ContentAlignment.MiddleCenter;
            Title_Assymetric_Encryption.Visible = false;
            // 
            // Incorrect_Password
            // 
            Incorrect_Password.AutoSize = true;
            Incorrect_Password.Enabled = false;
            Incorrect_Password.Font = new Font("Arial Rounded MT Bold", 22F);
            Incorrect_Password.ForeColor = Color.Red;
            Incorrect_Password.Location = new Point(684, 484);
            Incorrect_Password.Name = "Incorrect_Password";
            Incorrect_Password.Size = new Size(312, 34);
            Incorrect_Password.TabIndex = 67;
            Incorrect_Password.Text = "Incorrect password!";
            Incorrect_Password.Visible = false;
            // 
            // Account_Not_Found
            // 
            Account_Not_Found.AutoSize = true;
            Account_Not_Found.Enabled = false;
            Account_Not_Found.Font = new Font("Arial Rounded MT Bold", 22F);
            Account_Not_Found.ForeColor = Color.Red;
            Account_Not_Found.Location = new Point(684, 326);
            Account_Not_Found.Name = "Account_Not_Found";
            Account_Not_Found.Size = new Size(294, 34);
            Account_Not_Found.TabIndex = 66;
            Account_Not_Found.Text = "Account not found!";
            Account_Not_Found.Visible = false;
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Enabled = false;
            Password_Label.Font = new Font("Arial Rounded MT Bold", 22F);
            Password_Label.ForeColor = Color.White;
            Password_Label.Location = new Point(551, 393);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(168, 34);
            Password_Label.TabIndex = 63;
            Password_Label.Text = "Password:";
            Password_Label.Visible = false;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Enabled = false;
            Username_Label.Font = new Font("Arial Rounded MT Bold", 22F);
            Username_Label.ForeColor = Color.White;
            Username_Label.Location = new Point(551, 237);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(175, 34);
            Username_Label.TabIndex = 62;
            Username_Label.Text = "Username:";
            Username_Label.Visible = false;
            // 
            // Password_Textbox
            // 
            Password_Textbox.Enabled = false;
            Password_Textbox.Font = new Font("Arial Rounded MT Bold", 20.25F);
            Password_Textbox.Location = new Point(551, 430);
            Password_Textbox.Name = "Password_Textbox";
            Password_Textbox.Size = new Size(561, 39);
            Password_Textbox.TabIndex = 61;
            Password_Textbox.Visible = false;
            // 
            // Username_Textbox
            // 
            Username_Textbox.Enabled = false;
            Username_Textbox.Font = new Font("Arial Rounded MT Bold", 20.25F);
            Username_Textbox.Location = new Point(551, 274);
            Username_Textbox.Name = "Username_Textbox";
            Username_Textbox.Size = new Size(561, 39);
            Username_Textbox.TabIndex = 60;
            Username_Textbox.Visible = false;
            // 
            // Login_Button
            // 
            Login_Button.Enabled = false;
            Login_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Button.ForeColor = SystemColors.ActiveCaptionText;
            Login_Button.Location = new Point(639, 541);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(387, 39);
            Login_Button.TabIndex = 59;
            Login_Button.TabStop = false;
            Login_Button.Text = "LOGIN";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Visible = false;
            Login_Button.Click += Login_Button_Click;
            // 
            // Login_Title
            // 
            Login_Title.AutoSize = true;
            Login_Title.Enabled = false;
            Login_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Title.ForeColor = Color.White;
            Login_Title.Location = new Point(741, 81);
            Login_Title.Name = "Login_Title";
            Login_Title.Size = new Size(180, 55);
            Login_Title.TabIndex = 58;
            Login_Title.Text = "LOGIN";
            Login_Title.TextAlign = ContentAlignment.MiddleCenter;
            Login_Title.Visible = false;
            // 
            // Username_Error
            // 
            Username_Error.AutoSize = true;
            Username_Error.BackColor = Color.Red;
            Username_Error.Enabled = false;
            Username_Error.Font = new Font("Segoe UI", 23F);
            Username_Error.Location = new Point(550, 273);
            Username_Error.Name = "Username_Error";
            Username_Error.Size = new Size(565, 42);
            Username_Error.TabIndex = 64;
            Username_Error.Text = "label1aaaaaaaIaIaIIIIIIIIaaaaaaaaaaaaaaa";
            Username_Error.Visible = false;
            // 
            // Password_Error
            // 
            Password_Error.AutoSize = true;
            Password_Error.BackColor = Color.Red;
            Password_Error.Enabled = false;
            Password_Error.Font = new Font("Segoe UI", 23F);
            Password_Error.Location = new Point(549, 429);
            Password_Error.Name = "Password_Error";
            Password_Error.Size = new Size(565, 42);
            Password_Error.TabIndex = 65;
            Password_Error.Text = "label1aaaaaaaIaIaIIIIIIIIaaaaaaaaaaaaaaa";
            Password_Error.Visible = false;
            // 
            // Create_Account_Button
            // 
            Create_Account_Button.Enabled = false;
            Create_Account_Button.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Create_Account_Button.ForeColor = SystemColors.ActiveCaptionText;
            Create_Account_Button.Location = new Point(639, 542);
            Create_Account_Button.Name = "Create_Account_Button";
            Create_Account_Button.Size = new Size(387, 39);
            Create_Account_Button.TabIndex = 70;
            Create_Account_Button.TabStop = false;
            Create_Account_Button.Text = "CREATE ACCOUNT";
            Create_Account_Button.UseVisualStyleBackColor = true;
            Create_Account_Button.Visible = false;
            Create_Account_Button.Click += Create_Account_Button_Click;
            // 
            // Account_Already_Exists
            // 
            Account_Already_Exists.AutoSize = true;
            Account_Already_Exists.Enabled = false;
            Account_Already_Exists.Font = new Font("Arial Rounded MT Bold", 22F);
            Account_Already_Exists.ForeColor = Color.Red;
            Account_Already_Exists.Location = new Point(653, 326);
            Account_Already_Exists.Name = "Account_Already_Exists";
            Account_Already_Exists.Size = new Size(359, 34);
            Account_Already_Exists.TabIndex = 69;
            Account_Already_Exists.Text = "Account already exists!";
            Account_Already_Exists.Visible = false;
            // 
            // Create_Account_Title
            // 
            Create_Account_Title.AutoSize = true;
            Create_Account_Title.Enabled = false;
            Create_Account_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Create_Account_Title.ForeColor = Color.White;
            Create_Account_Title.Location = new Point(591, 81);
            Create_Account_Title.Name = "Create_Account_Title";
            Create_Account_Title.Size = new Size(483, 55);
            Create_Account_Title.TabIndex = 68;
            Create_Account_Title.Text = "CREATE ACCOUNT";
            Create_Account_Title.TextAlign = ContentAlignment.MiddleCenter;
            Create_Account_Title.Visible = false;
            // 
            // Username_Spaces
            // 
            Username_Spaces.AutoSize = true;
            Username_Spaces.Enabled = false;
            Username_Spaces.Font = new Font("Arial Rounded MT Bold", 22F);
            Username_Spaces.ForeColor = Color.Red;
            Username_Spaces.Location = new Point(571, 327);
            Username_Spaces.Name = "Username_Spaces";
            Username_Spaces.Size = new Size(523, 34);
            Username_Spaces.TabIndex = 71;
            Username_Spaces.Text = "Username can not contain spaces!";
            Username_Spaces.Visible = false;
            // 
            // Empty_Password
            // 
            Empty_Password.AutoSize = true;
            Empty_Password.Enabled = false;
            Empty_Password.Font = new Font("Arial Rounded MT Bold", 22F);
            Empty_Password.ForeColor = Color.Red;
            Empty_Password.Location = new Point(691, 484);
            Empty_Password.Name = "Empty_Password";
            Empty_Password.Size = new Size(282, 34);
            Empty_Password.TabIndex = 72;
            Empty_Password.Text = "Enter a password!";
            Empty_Password.Visible = false;
            // 
            // Empty_Username
            // 
            Empty_Username.AutoSize = true;
            Empty_Username.Enabled = false;
            Empty_Username.Font = new Font("Arial Rounded MT Bold", 22F);
            Empty_Username.ForeColor = Color.Red;
            Empty_Username.Location = new Point(695, 327);
            Empty_Username.Name = "Empty_Username";
            Empty_Username.Size = new Size(275, 34);
            Empty_Username.TabIndex = 73;
            Empty_Username.Text = "Enter a username";
            Empty_Username.Visible = false;
            // 
            // Password_Spaces
            // 
            Password_Spaces.AutoSize = true;
            Password_Spaces.Enabled = false;
            Password_Spaces.Font = new Font("Arial Rounded MT Bold", 22F);
            Password_Spaces.ForeColor = Color.Red;
            Password_Spaces.Location = new Point(571, 484);
            Password_Spaces.Name = "Password_Spaces";
            Password_Spaces.Size = new Size(516, 34);
            Password_Spaces.TabIndex = 74;
            Password_Spaces.Text = "Password can not contain spaces!";
            Password_Spaces.Visible = false;
            // 
            // Password_Length
            // 
            Password_Length.AutoSize = true;
            Password_Length.Enabled = false;
            Password_Length.Font = new Font("Arial Rounded MT Bold", 22F);
            Password_Length.ForeColor = Color.Red;
            Password_Length.Location = new Point(517, 486);
            Password_Length.Name = "Password_Length";
            Password_Length.Size = new Size(630, 34);
            Password_Length.TabIndex = 75;
            Password_Length.Text = "Password must be 6 characters or longer!";
            Password_Length.Visible = false;
            // 
            // Username_Length
            // 
            Username_Length.AutoSize = true;
            Username_Length.Enabled = false;
            Username_Length.Font = new Font("Arial Rounded MT Bold", 22F);
            Username_Length.ForeColor = Color.Red;
            Username_Length.Location = new Point(464, 327);
            Username_Length.Name = "Username_Length";
            Username_Length.Size = new Size(737, 34);
            Username_Length.TabIndex = 76;
            Username_Length.Text = "Username must be between 3 and 20 characters!";
            Username_Length.Visible = false;
            // 
            // Log_Out
            // 
            Log_Out.Enabled = false;
            Log_Out.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Log_Out.ForeColor = SystemColors.ActiveCaptionText;
            Log_Out.Location = new Point(1032, 724);
            Log_Out.Name = "Log_Out";
            Log_Out.Size = new Size(387, 83);
            Log_Out.TabIndex = 81;
            Log_Out.TabStop = false;
            Log_Out.Text = "LOG OUT";
            Log_Out.UseVisualStyleBackColor = true;
            Log_Out.Visible = false;
            Log_Out.Click += Log_Out_Click;
            // 
            // Send
            // 
            Send.Enabled = false;
            Send.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Send.ForeColor = SystemColors.ActiveCaptionText;
            Send.Location = new Point(639, 513);
            Send.Name = "Send";
            Send.Size = new Size(387, 114);
            Send.TabIndex = 80;
            Send.TabStop = false;
            Send.Text = "SEND MESSAGE/FILE";
            Send.UseVisualStyleBackColor = true;
            Send.Visible = false;
            Send.Click += Send_Click;
            // 
            // Read_Inbox
            // 
            Read_Inbox.Enabled = false;
            Read_Inbox.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Read_Inbox.ForeColor = SystemColors.ActiveCaptionText;
            Read_Inbox.Location = new Point(639, 343);
            Read_Inbox.Name = "Read_Inbox";
            Read_Inbox.Size = new Size(387, 114);
            Read_Inbox.TabIndex = 79;
            Read_Inbox.TabStop = false;
            Read_Inbox.Text = "READ INBOX";
            Read_Inbox.UseVisualStyleBackColor = true;
            Read_Inbox.Visible = false;
            Read_Inbox.Click += Read_Inbox_Click;
            // 
            // Unread_Label
            // 
            Unread_Label.Enabled = false;
            Unread_Label.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Unread_Label.ForeColor = Color.White;
            Unread_Label.Location = new Point(405, 194);
            Unread_Label.Name = "Unread_Label";
            Unread_Label.Size = new Size(854, 43);
            Unread_Label.TabIndex = 78;
            Unread_Label.Text = "YOU HAVE {} UNREAD FILE(S) IN YOUR INBOX";
            Unread_Label.TextAlign = ContentAlignment.MiddleCenter;
            Unread_Label.Visible = false;
            // 
            // User_Title
            // 
            User_Title.Enabled = false;
            User_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            User_Title.ForeColor = Color.White;
            User_Title.Location = new Point(591, 81);
            User_Title.Name = "User_Title";
            User_Title.Size = new Size(483, 55);
            User_Title.TabIndex = 82;
            User_Title.Text = "WELCOME";
            User_Title.TextAlign = ContentAlignment.MiddleCenter;
            User_Title.Visible = false;
            // 
            // Inbox
            // 
            Inbox.Activation = ItemActivation.OneClick;
            Inbox.AutoArrange = false;
            Inbox.Enabled = false;
            Inbox.Font = new Font("Arial Rounded MT Bold", 15.25F);
            Inbox.GridLines = true;
            Inbox.Location = new Point(401, 180);
            Inbox.MultiSelect = false;
            Inbox.Name = "Inbox";
            Inbox.Size = new Size(863, 478);
            Inbox.TabIndex = 83;
            Inbox.UseCompatibleStateImageBehavior = false;
            Inbox.View = View.Tile;
            Inbox.Visible = false;
            Inbox.SelectedIndexChanged += Inbox_SelectedIndexChanged;
            // 
            // Inbox_Title
            // 
            Inbox_Title.AutoSize = true;
            Inbox_Title.Enabled = false;
            Inbox_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Inbox_Title.ForeColor = Color.White;
            Inbox_Title.Location = new Point(744, 81);
            Inbox_Title.Name = "Inbox_Title";
            Inbox_Title.Size = new Size(177, 55);
            Inbox_Title.TabIndex = 84;
            Inbox_Title.Text = "INBOX";
            Inbox_Title.TextAlign = ContentAlignment.MiddleCenter;
            Inbox_Title.Visible = false;
            // 
            // Recipient_Not_Found
            // 
            Recipient_Not_Found.AutoSize = true;
            Recipient_Not_Found.Enabled = false;
            Recipient_Not_Found.Font = new Font("Arial Rounded MT Bold", 22F);
            Recipient_Not_Found.ForeColor = Color.Red;
            Recipient_Not_Found.Location = new Point(689, 287);
            Recipient_Not_Found.Name = "Recipient_Not_Found";
            Recipient_Not_Found.Size = new Size(311, 34);
            Recipient_Not_Found.TabIndex = 94;
            Recipient_Not_Found.Text = "Recipient not found!";
            Recipient_Not_Found.Visible = false;
            // 
            // Send_Title
            // 
            Send_Title.AutoSize = true;
            Send_Title.Enabled = false;
            Send_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Send_Title.ForeColor = Color.White;
            Send_Title.Location = new Point(409, 95);
            Send_Title.Name = "Send_Title";
            Send_Title.Size = new Size(880, 55);
            Send_Title.TabIndex = 92;
            Send_Title.Text = "ENTER USERNAME OF RECEPTIENT";
            Send_Title.TextAlign = ContentAlignment.MiddleCenter;
            Send_Title.Visible = false;
            // 
            // Recipient_Name
            // 
            Recipient_Name.Enabled = false;
            Recipient_Name.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Recipient_Name.Location = new Point(351, 209);
            Recipient_Name.Name = "Recipient_Name";
            Recipient_Name.Size = new Size(895, 48);
            Recipient_Name.TabIndex = 91;
            Recipient_Name.Visible = false;
            // 
            // Recipient_TickMark
            // 
            Recipient_TickMark.BackColor = Color.White;
            Recipient_TickMark.BackgroundImage = (Image)resources.GetObject("Recipient_TickMark.BackgroundImage");
            Recipient_TickMark.BackgroundImageLayout = ImageLayout.Center;
            Recipient_TickMark.Enabled = false;
            Recipient_TickMark.FlatStyle = FlatStyle.Popup;
            Recipient_TickMark.ForeColor = Color.Transparent;
            Recipient_TickMark.ImageAlign = ContentAlignment.TopCenter;
            Recipient_TickMark.Location = new Point(1267, 208);
            Recipient_TickMark.Name = "Recipient_TickMark";
            Recipient_TickMark.Size = new Size(48, 48);
            Recipient_TickMark.TabIndex = 90;
            Recipient_TickMark.UseVisualStyleBackColor = false;
            Recipient_TickMark.Visible = false;
            Recipient_TickMark.Click += Recipient_TickMark_Click;
            // 
            // Recipient_Error
            // 
            Recipient_Error.AutoSize = true;
            Recipient_Error.BackColor = Color.Red;
            Recipient_Error.Enabled = false;
            Recipient_Error.Font = new Font("Segoe UI", 29F);
            Recipient_Error.Location = new Point(349, 207);
            Recipient_Error.Name = "Recipient_Error";
            Recipient_Error.Size = new Size(900, 52);
            Recipient_Error.TabIndex = 93;
            Recipient_Error.Text = "label1aaaaaajjjjIIIIIIIIaaaaaIaIaIIIIIIIIaaaaaaaaaaaaaaa";
            Recipient_Error.Visible = false;
            // 
            // Choose_Title
            // 
            Choose_Title.AutoSize = true;
            Choose_Title.Enabled = false;
            Choose_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Choose_Title.ForeColor = Color.White;
            Choose_Title.Location = new Point(614, 118);
            Choose_Title.Name = "Choose_Title";
            Choose_Title.Size = new Size(437, 55);
            Choose_Title.TabIndex = 97;
            Choose_Title.Text = "CHOOSE OPTION";
            Choose_Title.TextAlign = ContentAlignment.MiddleCenter;
            Choose_Title.Visible = false;
            // 
            // Send_File
            // 
            Send_File.Enabled = false;
            Send_File.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Send_File.ForeColor = SystemColors.ActiveCaptionText;
            Send_File.Location = new Point(965, 419);
            Send_File.Name = "Send_File";
            Send_File.Size = new Size(387, 172);
            Send_File.TabIndex = 96;
            Send_File.TabStop = false;
            Send_File.Text = "SEND FILE";
            Send_File.UseVisualStyleBackColor = true;
            Send_File.Visible = false;
            Send_File.Click += Send_File_Click;
            // 
            // Send_Message
            // 
            Send_Message.Enabled = false;
            Send_Message.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Send_Message.ForeColor = Color.Black;
            Send_Message.Location = new Point(313, 419);
            Send_Message.Name = "Send_Message";
            Send_Message.Size = new Size(387, 172);
            Send_Message.TabIndex = 95;
            Send_Message.Text = "SEND MESSAGE";
            Send_Message.UseVisualStyleBackColor = true;
            Send_Message.Visible = false;
            Send_Message.Click += Send_Message_Click;
            // 
            // Message_Send
            // 
            Message_Send.Enabled = false;
            Message_Send.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_Send.Location = new Point(350, 267);
            Message_Send.Name = "Message_Send";
            Message_Send.Size = new Size(895, 48);
            Message_Send.TabIndex = 100;
            Message_Send.Visible = false;
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
            Message_TickMark.TabIndex = 99;
            Message_TickMark.UseVisualStyleBackColor = false;
            Message_TickMark.Visible = false;
            Message_TickMark.Click += Message_TickMark_Click;
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
            Message_Sent_Title.TabIndex = 98;
            Message_Sent_Title.Text = "MESSAGE TO SEND";
            Message_Sent_Title.TextAlign = ContentAlignment.MiddleCenter;
            Message_Sent_Title.Visible = false;
            // 
            // File_Send_Path
            // 
            File_Send_Path.Enabled = false;
            File_Send_Path.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Send_Path.Location = new Point(350, 267);
            File_Send_Path.Name = "File_Send_Path";
            File_Send_Path.Size = new Size(895, 48);
            File_Send_Path.TabIndex = 103;
            File_Send_Path.Visible = false;
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
            File_Send_TickMark.TabIndex = 102;
            File_Send_TickMark.UseVisualStyleBackColor = false;
            File_Send_TickMark.Visible = false;
            File_Send_TickMark.Click += File_Send_TickMark_Click;
            // 
            // File_Send_Title
            // 
            File_Send_Title.AutoSize = true;
            File_Send_Title.Enabled = false;
            File_Send_Title.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Send_Title.ForeColor = Color.White;
            File_Send_Title.Location = new Point(542, 118);
            File_Send_Title.Name = "File_Send_Title";
            File_Send_Title.Size = new Size(581, 55);
            File_Send_Title.TabIndex = 101;
            File_Send_Title.Text = "PATH OF FILE TO SEND";
            File_Send_Title.TextAlign = ContentAlignment.MiddleCenter;
            File_Send_Title.Visible = false;
            // 
            // File_Send_Success
            // 
            File_Send_Success.AutoSize = true;
            File_Send_Success.Enabled = false;
            File_Send_Success.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            File_Send_Success.ForeColor = Color.White;
            File_Send_Success.Location = new Point(477, 389);
            File_Send_Success.Name = "File_Send_Success";
            File_Send_Success.Size = new Size(694, 55);
            File_Send_Success.TabIndex = 105;
            File_Send_Success.Text = "FILE SEND SUCCESSFULLY!";
            File_Send_Success.TextAlign = ContentAlignment.MiddleCenter;
            File_Send_Success.Visible = false;
            // 
            // Message_Send_Success
            // 
            Message_Send_Success.AutoSize = true;
            Message_Send_Success.Enabled = false;
            Message_Send_Success.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Message_Send_Success.ForeColor = Color.White;
            Message_Send_Success.Location = new Point(417, 389);
            Message_Send_Success.Name = "Message_Send_Success";
            Message_Send_Success.Size = new Size(830, 55);
            Message_Send_Success.TabIndex = 104;
            Message_Send_Success.Text = "MESSAGE SEND SUCCESSFULLY!";
            Message_Send_Success.TextAlign = ContentAlignment.MiddleCenter;
            Message_Send_Success.Visible = false;
            // 
            // Admin_Button
            // 
            Admin_Button.AutoSize = true;
            Admin_Button.Font = new Font("Arial Rounded MT Bold", 10F);
            Admin_Button.ForeColor = Color.Black;
            Admin_Button.Location = new Point(836, 810);
            Admin_Button.Name = "Admin_Button";
            Admin_Button.Size = new Size(15, 16);
            Admin_Button.TabIndex = 106;
            Admin_Button.Text = "0";
            Admin_Button.TextAlign = ContentAlignment.MiddleCenter;
            Admin_Button.Click += Admin_Button_Click;
            // 
            // Reset_Repository
            // 
            Reset_Repository.Enabled = false;
            Reset_Repository.Font = new Font("Arial Rounded MT Bold", 30F);
            Reset_Repository.ForeColor = Color.Red;
            Reset_Repository.Location = new Point(639, 419);
            Reset_Repository.Name = "Reset_Repository";
            Reset_Repository.Size = new Size(387, 172);
            Reset_Repository.TabIndex = 107;
            Reset_Repository.TabStop = false;
            Reset_Repository.Text = "RESET REPOSITORY";
            Reset_Repository.UseVisualStyleBackColor = true;
            Reset_Repository.Visible = false;
            Reset_Repository.Click += Reset_Repository_Click;
            // 
            // StartUp_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1664, 1011);
            Controls.Add(Reset_Repository);
            Controls.Add(Admin_Button);
            Controls.Add(File_Send_Success);
            Controls.Add(Message_Send_Success);
            Controls.Add(File_Send_Path);
            Controls.Add(File_Send_TickMark);
            Controls.Add(File_Send_Title);
            Controls.Add(Message_Send);
            Controls.Add(Message_TickMark);
            Controls.Add(Message_Sent_Title);
            Controls.Add(Choose_Title);
            Controls.Add(Send_File);
            Controls.Add(Send_Message);
            Controls.Add(Recipient_Not_Found);
            Controls.Add(Send_Title);
            Controls.Add(Recipient_Name);
            Controls.Add(Recipient_TickMark);
            Controls.Add(Recipient_Error);
            Controls.Add(Inbox_Title);
            Controls.Add(User_Title);
            Controls.Add(Log_Out);
            Controls.Add(Unread_Label);
            Controls.Add(Create_Account_Title);
            Controls.Add(Account_Not_Found);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(Password_Textbox);
            Controls.Add(Username_Textbox);
            Controls.Add(Login_Title);
            Controls.Add(Username_Error);
            Controls.Add(Password_Error);
            Controls.Add(Login);
            Controls.Add(Title_Assymetric_Encryption);
            Controls.Add(File_Decryption_Tickmark);
            Controls.Add(File_Decription_Title);
            Controls.Add(File_Decryption_Key);
            Controls.Add(File_Symmetric_Decryption_Title);
            Controls.Add(File_Decryption_Path);
            Controls.Add(Copy_File_Key);
            Controls.Add(Success_Title);
            Controls.Add(File_Encryption_TickMark);
            Controls.Add(File_Symmetric_Encryption_Title);
            Controls.Add(File_Encryption_Path);
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
            Controls.Add(Send);
            Controls.Add(Create_account);
            Controls.Add(Create_Account_Button);
            Controls.Add(Username_Length);
            Controls.Add(Read_Inbox);
            Controls.Add(Username_Spaces);
            Controls.Add(Empty_Username);
            Controls.Add(Account_Already_Exists);
            Controls.Add(Password_Length);
            Controls.Add(Password_Spaces);
            Controls.Add(Empty_Password);
            Controls.Add(Success_File_Title);
            Controls.Add(Incorrect_Password);
            Controls.Add(Encryption_key_label);
            Controls.Add(Direct_Decryption_Title3);
            Controls.Add(Login_Button);
            Controls.Add(File_Key_title);
            Controls.Add(Inbox);
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
        private Button Create_account;
        private Button Login;
        private Label Title_Assymetric_Encryption;
        private Label Incorrect_Password;
        private Label Account_Not_Found;
        private Label Password_Label;
        private Label Username_Label;
        private TextBox Password_Textbox;
        private TextBox Username_Textbox;
        private Button Login_Button;
        private Label Login_Title;
        private Label Username_Error;
        private Label Password_Error;
        private Button Create_Account_Button;
        private Label Account_Already_Exists;
        private Label Create_Account_Title;
        private Label Username_Spaces;
        private Label Empty_Password;
        private Label Empty_Username;
        private Label Password_Spaces;
        private Label Password_Length;
        private Label Username_Length;
        private Button Log_Out;
        private Button Send;
        private Button Read_Inbox;
        private Label Unread_Label;
        private Label User_Title;
        private ListView Inbox;
        private Label Inbox_Title;
        private Label Recipient_Not_Found;
        private Label Send_Title;
        private TextBox Recipient_Name;
        private Button Recipient_TickMark;
        private Label Recipient_Error;
        private Label Choose_Title;
        private Button Send_File;
        private Button Send_Message;
        private TextBox Message_Send;
        private Button Message_TickMark;
        private Label Message_Sent_Title;
        private TextBox File_Send_Path;
        private Button File_Send_TickMark;
        private Label File_Send_Title;
        private Label File_Send_Success;
        private Label Message_Send_Success;
        private Label Admin_Button;
        private Button Reset_Repository;
    }
}
