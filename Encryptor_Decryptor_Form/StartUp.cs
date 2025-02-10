using Encryptor_Decryptor;
using Encryptor_Decryptor.Main.UserRepository;
using EncryptorDecryptor;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Text;

namespace Encryptor_Decryptor_Form
{
    public partial class StartUp_Form : Form
    {
        private readonly Stack<List<Control>> navigationHistory = new Stack<List<Control>>();

        private readonly UsersRepository _usersRepository = new();

        private Encryptor_Decryptor.Main.UserRepository.User _logedUser;

        private string recipient;

        public StartUp_Form()
        {
            InitializeComponent();
        }
        private void StartUp_Form_Load(object sender, EventArgs e) { }

        #region Event Handlers

        private void Symmetric_Click(object sender, EventArgs e)
        {
            ShowSymmetricOptions();
        }

        private void Asymmetric_Click(object sender, EventArgs e)
        {
            ShowAsymmetricOptions();
        }

        private void ToStart_Click(object sender, EventArgs e)
        {
            ResetToStart();
        }

        private void Encrypt_Symmetric_Click(object sender, EventArgs e)
        {
            ShowSymmetricEncryptionOptions();
        }

        private void Direct_Symmetric_Click(object sender, EventArgs e)
        {
            ShowDirectSymmetricEncryption();
        }

        private void File_Symmetric_Click(object sender, EventArgs e)
        {
            ShowSymmetricFileEncryption();
        }

        private void Direct_TickMark_Click(object sender, EventArgs e)
        {
            PerformDirectSymmetricEncryption();
        }

        private void Decrypt_Symmetric_Click(object sender, EventArgs e)
        {
            ShowSymmetricDecryptionOptions();
        }

        private void Symmetric_Direct_Decryption_Click(object sender, EventArgs e)
        {
            ShowDirectSymmetricDecryption();
        }

        private void Direct_Decryption_Tickmark_Click(object sender, EventArgs e)
        {
            PerformDirectSymmetricDecryption();
        }
        private void Symmetric_File_Decription_Click(object sender, EventArgs e)
        {
            ShowFileSymmetricDecryption();
        }

        private void Copy_messge_Click(object sender, EventArgs e)
        {
            CopyToClipboard(Encrypt_Message_Out.Text);
        }

        private void Copy_key_Click(object sender, EventArgs e)
        {
            CopyToClipboard(Encryption_Key_Out.Text);
        }

        private void Copy_Decrypted_Click(object sender, EventArgs e)
        {
            CopyToClipboard(Direct_Decryption_Message_Out.Text);
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            NavigateBack();
        }

        private void File_Encryption_TickMark_Click(object sender, EventArgs e)
        {
            PerformFileSymmetricEncryption();
        }
        private void File_Decryption_Tickmark_Click(object sender, EventArgs e)
        {
            PerformFileSymmetricDecryption();
        }

        private void Copy_File_Key_Click(object sender, EventArgs e)
        {
            CopyToClipboard(File_Key_Out.Text);
        }

        private void Create_account_Click(object sender, EventArgs e)
        {
            ShowCreateAccount();
        }

        private void Create_Account_Button_Click(object sender, EventArgs e)
        {
            HideErrors();
            string username = Username_Textbox.Text;
            string password = Password_Textbox.Text;
            bool error = false;
            if (_usersRepository.Exists(username))
            {
                SetControlVisibility(true, Username_Error, Account_Already_Exists);
                error = true;
            }
            if (string.IsNullOrEmpty(username))
            {
                SetControlVisibility(true, Username_Error, Empty_Username);
                error = true;
            }
            else if (username.Length < 3 || username.Length > 20)
            {
                SetControlVisibility(true, Username_Error, Username_Length);
                error = true;
            }
            if (username.Contains(" "))
            {
                SetControlVisibility(true, Username_Error, Username_Spaces);
                error = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                SetControlVisibility(true, Password_Error, Empty_Password);
                error = true;
            }
            else if (password.Length < 6)
            {
                SetControlVisibility(true, Password_Error, Password_Length);
                error = true;
            }
            if (password.Contains(" "))
            {
                SetControlVisibility(true, Password_Error, Password_Spaces);
                error = true;
            }

            if (!error)
            {
                Encryptor_Decryptor.Main.UserRepository.User user = new Encryptor_Decryptor.Main.UserRepository.User(username, password);
                _usersRepository.AddNew(user);
                _logedUser = user;
                ShowUserMenu(username);
            }
            else
            {
                return;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }
        private void Login_Button_Click(object sender, EventArgs e)
        {
            HideErrors();
            string username = Username_Textbox.Text;
            string password = Password_Textbox.Text;
            bool error = false;
            if (!_usersRepository.Exists(username))
            {
                SetControlVisibility(true, Username_Error, Account_Not_Found);
                error = true;
            }
            if (string.IsNullOrEmpty(username))
            {
                SetControlVisibility(true, Username_Error, Empty_Username);
                error = true;
            }
            if (string.IsNullOrEmpty(password))
            {
                SetControlVisibility(true, Password_Error, Empty_Password);
                error = true;
            }
            if (!_usersRepository.GetByName(username).IsPasswordTrue(password))
            {
                SetControlVisibility(true, Password_Error, Incorrect_Password);
                error = true;
            }
            if (!error)
            {
                _logedUser = _usersRepository.GetByName(username);
                ShowUserMenu(username);
            }
            else return;
        }

        private void Log_Out_Click(object sender, EventArgs e)
        {
            _logedUser = null!;
            NavigateBack();
            NavigateBack();
        }
        private void Read_Inbox_Click(object sender, EventArgs e)
        {
            ShowInbox();
            Inbox.Items.Clear();
            string[] files = Directory.GetFiles(_logedUser.InboxPath);
            foreach (var file in files)
            {
                Inbox.Items.Add(Path.GetFileName(file));
            }
        }
        private void Inbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ListView.SelectedListViewItemCollection selectedItems = Inbox.SelectedItems;
            ListView item = ((ListView)sender);

            string filePath = _logedUser.InboxPath + item.FocusedItem.Text;
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    if (Path.GetExtension(filePath) == ".txt")
                    {
                        string encryptedContent = File.ReadAllText(filePath, Encoding.UTF8);
                        string decryptedContent = _logedUser.DecryptMessage(encryptedContent);
                        File.WriteAllText(filePath, decryptedContent, Encoding.UTF8);
                    }
                    else
                    {
                        _logedUser.DecryptFile(filePath);
                    }

                    MonitorFileAndReencrypt(filePath, _logedUser);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing file: {ex.Message}");
                }
                return;
            }
        }
        private void Send_Click(object sender, EventArgs e)
        {
            ShowOptions();
        }

        private void Send_File_Click(object sender, EventArgs e)
        {
        }

        private void Send_Message_Click(object sender, EventArgs e)
        {
            ShowSend();
        }
        private void Message_TickMark_Click(object sender, EventArgs e)
        {
            SendMessage(_logedUser.Username, recipient);
            NavigateBack();
            NavigateBack();
        }

        #endregion

        #region Navigation Methods

        private void ResetToStart()
        {
            ResetAllTextBoxes();
            HideAllControls();
            SetControlVisibility(true, Symmetric_StartUp, Asymmetric_StartUp, Title_StartUp, Quit);
        }

        private void NavigateToNewState(params Control[] controlsToShow)
        {
            ResetAllTextBoxes();
            SaveCurrentState();
            HideAllControls();
            SetControlVisibility(true, controlsToShow);
        }

        private void NavigateBack()
        {
            ResetAllTextBoxes();
            if (navigationHistory.Count > 0)
            {

                var previousState = navigationHistory.Pop();
                HideAllControls();
                SetControlVisibility(true, previousState.ToArray());
            }
            else
            {
                MessageBox.Show("No previous page to go back to.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SaveCurrentState()
        {
            var currentState = GetAllVisibleControls();
            navigationHistory.Push(currentState);
        }

        private List<Control> GetAllVisibleControls()
        {
            var visibleControls = new List<Control>();
            foreach (var control in GetAllDescendants<Control>(this))
            {
                if (control.Visible)
                {
                    visibleControls.Add(control);
                }
            }
            return visibleControls;
        }

        #endregion

        #region Symmetric Encryption Methods

        private void ShowSymmetricOptions()
        {
            NavigateToNewState(Title_Symmetric, Encrypt_Symmetric, Decrypt_Symmetric, Quit, GoBack);
        }

        private void ShowSymmetricEncryptionOptions()
        {
            NavigateToNewState(Symmetric_Encryption_Title, Direct_Symmetric, File_Symmetric, GoBack, Quit);
        }

        private void ShowDirectSymmetricEncryption()
        {
            NavigateToNewState(Direct_TextBox, Direct_Title, Direct_TickMark, GoBack, Quit);
        }

        private void PerformDirectSymmetricEncryption()
        {
            try
            {
                var encryptor = new SymmetricEncryptor(Direct_TextBox.Text.ToCharArray());
                encryptor.EncryptMessage();

                Encrypt_Message_Out.Text = encryptor.EncryptedMessage;
                Encryption_Key_Out.Text = encryptor.Key;

                SetControlVisibility(true, Encrypted_message_label, Encrypt_Message_Out, Encryption_key_label, Encryption_Key_Out, Copy_key, Copy_messge, ToStart);
            }
            catch (Exception ex)
            {
                ShowError("Encryption failed", ex);
            }
        }

        private void ShowSymmetricFileEncryption()
        {
            NavigateToNewState(File_Encryption_Path, File_Encryption_TickMark, File_Symmetric_Encryption_Title, GoBack, Quit);
        }

        private async void PerformFileSymmetricEncryption()
        {
            try
            {
                var encryptor = new FileEncryptor();
                await Task.Run(() => encryptor.EncryptFile(File_Encryption_Path.Text));
                File_Key_Out.Text = encryptor.Key;
                SetControlVisibility(true, File_Key_Out, File_Key_title, Copy_File_Key, Success_Title, ToStart);
            }
            catch (Exception ex)
            {
                ShowError("File encryption failed", ex);
            }
        }


        private void ShowSymmetricDecryptionOptions()
        {
            NavigateToNewState(Symmetric_Decryption_Title, Symmetric_Direct_Decryption, Symmetric_File_Decription, GoBack, Quit);
        }

        private void ShowDirectSymmetricDecryption()
        {
            NavigateToNewState(Direct_Decryption_Title, Direct_Decryption_Title2, Direct_Decryption_Key, Direct_Decryption_Tickmark, Direct_Decryption_Message, GoBack, Quit);
        }

        private void PerformDirectSymmetricDecryption()
        {
            try
            {
                var decryptor = new SymmetricalDecryptor(Direct_Decryption_Key.Text, Direct_Decryption_Message.Text.ToCharArray());
                decryptor.Decrypt();

                Direct_Decryption_Message_Out.Text = decryptor.DecryptedMessage;

                SetControlVisibility(true, Direct_Decryption_Message_Out, Copy_Decrypted, Direct_Decryption_Title3, ToStart);
            }
            catch (Exception ex)
            {
                ShowError("Decryption failed", ex);
            }
        }
        private void ShowFileSymmetricDecryption()
        {
            NavigateToNewState(File_Decription_Title, File_Decryption_Key, File_Decryption_Path, File_Symmetric_Decryption_Title, File_Decription_Title, File_Decryption_Tickmark, GoBack, Quit);
        }

        private async void PerformFileSymmetricDecryption()
        {
            try
            {
                var decryptor = new FileDecryptor();
                await Task.Run(() => decryptor.DecryptFile(File_Decryption_Path.Text, File_Decryption_Key.Text));
                SetControlVisibility(true, Success_File_Title, ToStart);
            }
            catch (Exception ex)
            {
                ShowError("File decryption failed", ex);
            }
        }

        #endregion

        #region Asymmetric Encryption Methods

        private void ShowAsymmetricOptions()
        {
            NavigateToNewState(Title_Assymetric_Encryption, Create_account, Login, Quit, GoBack);
        }
        private void ShowLogin()
        {
            NavigateToNewState(Login_Title, Username_Label, Password_Label, Login_Button, GoBack, Quit, Username_Textbox, Password_Textbox);
        }

        private void ShowCreateAccount()
        {
            NavigateToNewState(Create_Account_Title, Username_Label, Password_Label, Username_Textbox, Password_Textbox, Create_Account_Button, GoBack, Quit);
        }
        private void ShowUserMenu(string username)
        {

            int unreadFiles = Directory.GetFiles(_usersRepository.GetByName(username).InboxPath).Length;
            User_Title.Text = $"WELCOME, {username}!";
            Unread_Label.Text = $"YOU HAVE {unreadFiles} FILE(S) IN YOUR INBOX";

            NavigateToNewState(User_Title, Unread_Label, Read_Inbox, Send, Log_Out, Quit);

        }

        private void ShowSend()
        {
            NavigateToNewState(Send_Title, Recipient_TickMark, Recipient_Name, GoBack, Quit);
        }

        private void ShowInbox()
        {
            NavigateToNewState(Inbox_Title, Inbox, GoBack, Quit);
        }
        private static void MonitorFileAndReencrypt(string filePath, Encryptor_Decryptor.Main.UserRepository.User user)
        {
            Console.WriteLine("Monitoring the file. Close the file after viewing to re-encrypt it.");

            // Open the file with the associated application
            using (var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true // Opens the file with the default application
                }
            })
            {
                process.Start();
                process.WaitForExit(); // Wait until the application is closed
            }

            // Re-encrypt the file after closing
            try
            {
                if (Path.GetExtension(filePath) == ".txt")
                {
                    string content = File.ReadAllText(filePath, Encoding.UTF8);
                    string encrypted = user.EncryptMessage(content, user.PublicKey);
                    File.WriteAllText(filePath, encrypted, Encoding.UTF8);
                }
                else
                {
                    user.EncryptFile(filePath, user.PublicKey);
                }

                Console.WriteLine("File was re-encrypted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error re-encrypting file: {ex.Message}");
            }
        }
        private void Recipient_TickMark_Click(object sender, EventArgs e)
        {
            HideErrors();
            if (_usersRepository.Exists(Recipient_Name.Text))
            {
                recipient = Recipient_Name.Text;
                ShowSendMessage();
            }
            else
            {
                SetControlVisibility(true, Recipient_Error, Recipient_Not_Found);
            }
        }
        private void SendMessage(string senderUsername, string recipientUsername)
        {

            string message = Message_Send.Text;
            int n = 0;

            // Add message to recipient's inbox
            string recipientInbox = _usersRepository.GetByName(recipientUsername).InboxPath;
            string inboxPath = _usersRepository.GetByName(senderUsername).InboxPath;
            var files = Directory.GetFiles(recipientInbox);
            foreach (var file in files.Select(x => Path.GetExtension(x) == ".txt"))
            {
                n++;
            }
            string messageFilePath = Path.Combine(recipientInbox, $"{files.Length}-{senderUsername}_message.txt");
            string encrypted = _usersRepository.GetByName(senderUsername).EncryptMessage(message, _usersRepository.GetByName(recipientUsername).PublicKey);
            File.WriteAllText(messageFilePath, encrypted, Encoding.UTF8);
        }

        private void SendFile(string senderUsername, string recipientUsername)
        {

            string filePath = null;

            if (!File.Exists(filePath))
            {
                return;
            }

            // Add file to recipient's inbox
            string recipientInbox = _usersRepository.GetByName(recipientUsername).InboxPath;
            string destinationPath = Path.Combine(recipientInbox, Path.GetFileName(filePath));
            File.Copy(filePath, destinationPath);
            _usersRepository.GetByName(senderUsername).EncryptFile(destinationPath, _usersRepository.GetByName(recipientUsername).PublicKey);

        }
        private void ShowOptions()
        {
            NavigateToNewState(Send_File, Send_Message, Choose_Title, GoBack, Quit);
        }
        private void ShowSendMessage()
        {
            NavigateToNewState(Message_Sent_Title, Message_Send, Message_TickMark, GoBack, Quit);
        }

        #endregion

        #region Utility Methods

        private void SetControlVisibility(bool isVisible, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = isVisible;
                control.Visible = isVisible;
            }
        }

        private void ResetAllTextBoxes()
        {
            foreach (var textBox in GetAllDescendants<TextBox>(this))
            {
                textBox.Text = string.Empty;
            }
        }
        private void HideAllControls()
        {
            foreach (var control in GetAllDescendants<Control>(this))
            {
                control.Enabled = false;
                control.Visible = false;
            }
        }

        private void HideErrors()
        {
            SetControlVisibility(false, Username_Error, Password_Error, Account_Already_Exists, Empty_Username, Empty_Password, Username_Spaces, Password_Spaces, Password_Length, Username_Length);
        }

        private IEnumerable<T> GetAllDescendants<T>(Control control) where T : class
        {
            foreach (Control child in control.Controls)
            {
                if (child is T tControl)
                {
                    yield return tControl;
                }

                if (child.HasChildren)
                {
                    foreach (var descendant in GetAllDescendants<T>(child))
                    {
                        yield return descendant;
                    }
                }
            }
        }

        private void CopyToClipboard(string text, string successMessage = "Copied to clipboard!")
        {
            if (!string.IsNullOrEmpty(text))
            {
                Clipboard.SetText(text);
                MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowError(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion





        private void Choose_Title_Click(object sender, EventArgs e)
        {

        }

     
    }
}
