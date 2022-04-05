using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022_Class
{
    class Room
    {
       
        private static int _id;
        public int Id { get;}
        public string Name { get; set; }
        public int Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
     
        public Room(string name, int price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            _id++;
            Id=_id;
        }

        public string ShowInfo()
        {
            return$"ID:{Id}\nName:{Name}\nPersonCapacity: {PersonCapacity}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
