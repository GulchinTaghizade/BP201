using System;

namespace PharmacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine med1 = new Medicine();
            med1.Name="A";
            med1.Price = 5;
            med1.IsDeleted = false;

            Medicine med2 = new Medicine();
            med2.Name = "B";
            med2.Price = 55;
            med2.IsDeleted = false;
          

            Pharmacy ph = new Pharmacy(5);
            ph.AddMedicine(med1);
            ph.AddMedicine(med2);
            //ph.GetAllMedicines();
            //ph.FilterMedicineByPrice(20, 100);
            //ph.GetMedicineById(2);
            //ph.DeleteMedicineById(1);
            ph.EditMedicineEmail(1,"AAA");







        }
    }
}
