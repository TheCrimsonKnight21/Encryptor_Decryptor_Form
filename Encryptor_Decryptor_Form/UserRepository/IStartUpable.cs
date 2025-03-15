using Encryptor_Decryptor.Main.UserRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryptor_Decryptor_Form.UserRepository
{
    public interface IStartUpable
    {
        UsersRepository GetRepository();
        void UpdateRepository(UsersRepository usersRepository);

        FormWindowState GetWindowState();
    }
}
