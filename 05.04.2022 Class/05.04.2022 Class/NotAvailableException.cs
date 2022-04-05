using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022_Class
{
    class NotAvailableException:Exception
    {
        public NotAvailableException() { }

        public NotAvailableException(string msg) : base(msg)
        {

        }
    }
}
