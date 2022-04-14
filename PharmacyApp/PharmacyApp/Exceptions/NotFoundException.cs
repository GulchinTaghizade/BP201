using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp.Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException (string msg) : base(msg)
        {

        }
    }
}
