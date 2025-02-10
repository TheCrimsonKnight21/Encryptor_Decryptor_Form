using Encryptor_Decryptor;
using EncryptorDecryptor;

namespace Encryptor_Decryptor_Form
{
    public partial class StartUp_Form : Form
    {
        private readonly Stack<List<Control>> navigationHistory = new Stack<List<Control>>();

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
            // Placeholder for asymmetric encryption logic
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

        #endregion

        #region Navigation Methods

        private void ResetToStart()
        {
            HideAllControls();
            SetControlVisibility(true, Symmetric_StartUp, Asymmetric_StartUp, Title_StartUp, Quit);
        }

        private void NavigateToNewState(params Control[] controlsToShow)
        {
            SaveCurrentState();
            HideAllControls();
            SetControlVisibility(true, controlsToShow);
        }

        private void NavigateBack()
        {
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
            NavigateToNewState(File_Decription_Title, File_Decryption_Key, File_Decryption_Path, File_Symmetric_Decryption_Title, File_Decription_Title,File_Decryption_Tickmark,GoBack,Quit);
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

        #region Utility Methods

        private void SetControlVisibility(bool isVisible, params Control[] controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = isVisible;
                control.Visible = isVisible;
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
    }
}
