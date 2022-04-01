using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class User:IAccount

    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        int count;
        public bool PasswordCheckher(string passw)
        {
            if (passw.Length >= 8)
            {
                for (int i = 0; i < passw.Length; i++)
                {
                    if (Char.IsUpper(passw[i]))
                    {
                        count++;
                    }
                        
                   
                }


            }
            return true;
        }

        public void ShowInfo()
        {
            throw new NotImplementedException();
        }
    }
}
