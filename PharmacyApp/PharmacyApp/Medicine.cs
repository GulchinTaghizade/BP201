using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyApp
{
    class Medicine
    {
        private static int _id;
        public int ID { get; }
        public Medicine()
        {
            _id++;
            ID = _id;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted = false;


        public void Sell()
        {
            Count--;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID}\nName: {Name}\nPrice: {Price}\n Count: {Count}");
        }
    }
}
