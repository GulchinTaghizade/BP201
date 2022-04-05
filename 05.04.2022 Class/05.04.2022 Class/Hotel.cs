using System;
using System.Collections.Generic;
using System.Text;

namespace _05._04._2022_Class
{
    class Hotel
    {
        public string Name { get; set; }
        public bool IsAvailable { get; private set; }

        public Hotel(string name)
        {
            Name = name;
        }

        private Room[] rooms =new Room[0];
        public Room this[int index]  { 
            get 
            {
                if (index>0 && rooms.Length>0)
                {
                    return rooms[index];

                }
                else
                {
                    throw new NotAvailableException("Bele bir index yoxdur");
                }
                
            }
            set 
            {
                if (index>0 && rooms.Length > 0)
                {
                    rooms[index] = value;
                }
                else
                {
                    throw new NotAvailableException("Bele bir index yoxdur");
                }
            }
        }

        public void AddRoom(params Room[] otaq)
        {
            int arrayLength = rooms.Length;
            Array.Resize(ref rooms, arrayLength + otaq.Length);
            int temp = 0;
            for (int i = arrayLength; i < rooms.Length; i++)
            {
                rooms[i] = otaq[temp];
                temp++;
            }

          
        }

        public void MakeReservation(int? roomID)
        {

            if (roomID!=null)
            {
                if (rooms[(int)roomID-1]!=null)
                {
                    Console.WriteLine("Room is available");
                    IsAvailable = true;
                }
                else
                {
                    IsAvailable = false;
                    throw new NotAvailableException();
                }

            }
            else
            {
                throw new  NullReferenceException();
            }
          
            //if (roomID==null)
            //{
            //    throw new NullReferenceException();
            //}
            //else
            //{
            //    if (IsAvailable==false)
            //    {
            //        throw new NotAvailableException("this room is not available");
            //    }
            //    else
            //    {
            //        IsAvailable = true;
            //    }
            //}
        }

    }
}
