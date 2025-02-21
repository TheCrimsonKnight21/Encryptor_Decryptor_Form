

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
                    language_Label.Text = "Language";
                    Resolution_Label.Text = "Resolution";
                    English_Button.Text = "English";
                    Bulgarian_Button.Text = "Bulgarian";
                    English_Button.Enabled = false;
                    break;
                case "Bulgarian":
                    Back.Text = "НАЗАД";
                    Settings_Title.Text = "НАСТРОЙКИ";
                    language_Label.Text = "Език";
                    Resolution_Label.Text = "Резолюция";
                    English_Button.Text = "Английски";
                    Bulgarian_Button.Text = "Български";
                    Bulgarian_Button.Enabled = false;
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
                english.Hide();
                bulgarian.Show();
                this.BringToFront();
            }
        }

        //private void SetResolution(int x, int y)
        //{
            
        //    switch (language)
        //    {
        //        case "English":
        //            foreach (var control in StartUp_Form.GetAllDescendants<Control>(english))
        //            {

        //                switch (resolution)
        //                {
        //                    case 1:
        //                        control.Size = new Size(control.Size.Width * x / 1280, control.Size.Height * y / 720);
        //                        break;
        //                    case 2:
        //                        control.Size = new Size(control.Size.Width * x / 1680, control.Size.Height * y / 1050);
        //                        break;
        //                    case 3:
        //                        control.Size = new Size(control.Size.Width * x / 1920, control.Size.Height * y / 1080);
        //                        break;
        //                }
        //            }
        //            english.Size = new Size(x, y);
        //            break;
        //        case "Bulgarian":
        //            foreach (var control in StartUp_Form.GetAllDescendants<Control>(bulgarian))
        //            {

        //            }
        //            break;
        //    }
        //}

        //private void trackBar1_Scroll(object sender, EventArgs e)
        //{
        //    if (Resolution_TrackBar.Value == 1)
        //    {
        //        SetResolution(1280, 720);
        //    }
        //    else if (Resolution_TrackBar.Value == 2)
        //    {
        //        SetResolution(1680 ,1050);
        //    }
        //    else if (Resolution_TrackBar.Value == 3)
        //    {
        //        SetResolution(1920, 1080);
        //    }

        //    resolution = Resolution_TrackBar.Value;
        //}
    }
}
