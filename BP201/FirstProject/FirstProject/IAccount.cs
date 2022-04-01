using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    interface IAccount
    {
        public bool PasswordCheckher(string passw);
        public void ShowInfo();
    }
}
