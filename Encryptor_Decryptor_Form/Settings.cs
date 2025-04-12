

using Encryptor_Decryptor.Main.UserRepository;

namespace Encryptor_Decryptor_Form
{
    public partial class Settings : Form
    {
        private string language = "English";

        private Form english;
        private Form bulgarian;

        private int resolution = 2;
        public Settings(string language, Form form)
        {
            InitializeComponent();
            this.language = language;

            switch (language)
            {
                case "English":
                    english = form;
                    break;
                case "Bulgarian":
                    bulgarian = form;
                    break;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            















            if (english != null && bulgarian == null)
            {
                StartUp_Bulgarian startUp_Bulgarian = new StartUp_Bulgarian();
                bulgarian = startUp_Bulgarian;
                
                
            }
            else if (bulgarian != null && english == null)
            {
                StartUp_Form startUp_Form = new StartUp_Form();
                english = startUp_Form;
            }
            switch (language)
            {
                case "English":
                    Back.Text = "BACK";
                    Settings_Title.Text = "SETTINGS";
                    language_Label.Text = "LANGUAGE:";
                    Display_Label.Text = "DISPLAY MODE:";
                    English_Button.Text = "ENGLISH";
                    Bulgarian_Button.Text = "BULGARIAN";
                    Fullscreen_Button.Text = "FULLSCREEN";
                    Windowed_Button.Text = "WINDOWED";
                    English_Button.Enabled = false;
                    switch (english.WindowState)
                    {
                        case FormWindowState.Normal:
                            Windowed_Button.Enabled = false;
                            break;
                        case FormWindowState.Maximized:
                            Fullscreen_Button.Enabled = false;
                            break;
                    }
                    break;
                case "Bulgarian":
                    Back.Text = "НАЗАД";
                    Settings_Title.Text = "НАСТРОЙКИ";
                    language_Label.Text = "ЕЗИК:";
                    Display_Label.Text = "РЕЖИМ НА ПОКАЗВАНЕ:";
                    English_Button.Text = "АНГЛИЙСКИ";
                    Bulgarian_Button.Text = "БЪЛГАРСКИ";
                    Fullscreen_Button.Text = "ЦЯЛ ЕКРАН";
                    Windowed_Button.Text = " ";
                    Bulgarian_Button.Enabled = false;
                    switch (bulgarian.WindowState)
                    {
                        case FormWindowState.Normal:
                            Windowed_Button.Enabled = false;
                            break;
                        case FormWindowState.Maximized:
                            Fullscreen_Button.Enabled = false;
                            break;
                    }
                    break;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void English_Button_Click(object sender, EventArgs e)
        {
            if (language == "Bulgarian")
            {
                language = "English";
                English_Button.Enabled = false;
                Bulgarian_Button.Enabled = true;
                Settings_Load(sender, e);
                UpdateUserRepository(bulgarian, english);
                bulgarian.Hide();
                english.Show();
                this.BringToFront();
            }

        }

        private void Bulgarian_Button_Click(object sender, EventArgs e)
        {
            if (language == "English")
            {
                language = "Bulgarian";
                English_Button.Enabled = true;
                Bulgarian_Button.Enabled = false;
                Settings_Load(sender, e);
                UpdateUserRepository(english, bulgarian);
                english.Hide();
                bulgarian.Show();
                this.BringToFront();
            }
        }

        private void Windowed_Button_Click(object sender, EventArgs e)
        {
            english.WindowState = FormWindowState.Normal;
            bulgarian.WindowState = FormWindowState.Normal;
            english.FormBorderStyle = FormBorderStyle.FixedSingle;
            bulgarian.FormBorderStyle = FormBorderStyle.FixedSingle;
            Windowed_Button.Enabled = false;
            Fullscreen_Button.Enabled = true;
            this.BringToFront();
        }

        private void Fullscreen_Button_Click(object sender, EventArgs e)
        { 
            english.WindowState = FormWindowState.Maximized;
            bulgarian.WindowState = FormWindowState.Maximized;
            english.FormBorderStyle = FormBorderStyle.None;
            bulgarian.FormBorderStyle = FormBorderStyle.None;
            Windowed_Button.Enabled = true;
            Fullscreen_Button.Enabled = false;
            this.BringToFront();
        }
        private void UpdateUserRepository(Form fromForm, Form toForm)
        {
            if (fromForm is IHasUserRepository fromRepoForm && toForm is IHasUserRepository toRepoForm)
            {
                toRepoForm.UserRepository = fromRepoForm.UserRepository;
            }
        }
    }

    public interface IHasUserRepository
    {
        UsersRepository UserRepository { get; set; }
    }
}
