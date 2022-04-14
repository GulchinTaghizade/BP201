using PharmacyApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Pharmacy
    {
        public int MedicineLimit { get; set; }
        List<Medicine> medicines = new List<Medicine>();

        public Pharmacy(int medicineLimit)
        {
            MedicineLimit = medicineLimit;
        }


        public void AddMedicine(Medicine medicine)
        {
            bool isExist = false;
            foreach (var item in medicines)
            {
                if (medicine.Name==item.Name)
                {
                    isExist = true;
                    throw new MedicineAlreadyExistsException("This Medicine is already exist");
                }
                
            }
            if (!isExist)
            {
                if (MedicineLimit>=medicines.Count)
                {
                    medicines.Add(medicine);
                    Console.WriteLine("Medicine added to list");
                }
                else
                {
                    throw new CapacityLimitException("Capacity is full");
                }

            }
        }

        public void  GetAllMedicines()
        {
            List<Medicine> copymedicine = new List<Medicine>();
            copymedicine.AddRange(medicines);
            foreach (var item in medicines)
            {
                copymedicine.Add(item);
                Console.WriteLine(item.Name);
            }
            foreach (var item in copymedicine)
            {
                item.IsDeleted = false;
            }
           
        }

        public void FilterMedicineByPrice(double minprice, double maxprice)
        {
            foreach (var item in medicines)
            {
                if (item.Price>minprice && item.Price<maxprice)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void GetMedicineById(int? id)
        {
            if (id==null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (var item in medicines)
                {
                    if (item.ID==id && item.IsDeleted==false)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }

        public void DeleteMedicineById(int? id)
        {
         
            
            if (id == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                bool isExist = false;
                foreach (var item in medicines)
                {
                    
                    if (item.ID == id && item.IsDeleted == false)
                    {
                        isExist = true;
                        item.IsDeleted = true;
                        Console.WriteLine("deleted");
                        
                    }
                }

                if (!isExist)
                {
                    throw new NotFoundException("Not Found");
                }

            }


        }

        public void EditMedicineEmail(int? id, string? name )
        {
            bool isExist = false;
            if (id==null && name==null)
            {
                throw new NullReferenceException();
            }
            else
            {
                foreach (var item in medicines)
                {
                    if (item.ID==id && item.IsDeleted==false)
                    {
                        isExist = true;
                        item.Name = name;
                    }
                   
                }
                if (!isExist)
                {
                    throw new NotFoundException("This medicine not found");
                }
            }
        
        }


    }
}
