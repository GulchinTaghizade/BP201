using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string msg) : base(msg)
        {

        }
    }
}
