using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string msg) : base(msg)
        {

        }
    }
}
