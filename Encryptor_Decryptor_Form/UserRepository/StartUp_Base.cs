using Encryptor_Decryptor.Main.UserRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryptor_Decryptor_Form.UserRepository
{
    public partial class StartUp_Base : Form
    {
        public StartUp_Base()
        {
            InitializeComponent();
        }
        public virtual UsersRepository GetRepository()
        {
            return null;
        }
        public virtual void UpdateRepository(UsersRepository usersRepository)
        {

        }

        private void StartUp_Base_Load(object sender, EventArgs e)
        {

        }
    }
}
