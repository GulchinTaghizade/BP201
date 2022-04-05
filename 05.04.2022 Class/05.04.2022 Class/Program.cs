
using System;

namespace _05._04._2022_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("A", 5, 2);
            Room room2 = new Room("B", 10, 2);

            Hotel hotel1 = new Hotel("Hilton");
            hotel1.AddRoom(room1);
            //hotel1.AddRoom(room2);

            Console.WriteLine(room1.Id);

            //Console.WriteLine(hotel1[0].Name);

            try
            {
                hotel1.MakeReservation(1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
