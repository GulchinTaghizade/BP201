using _04._11._2022.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04._11._2022
{
     class Group
    {
        public string No { get; set; }
        //public Categories Category;
        public bool IsOnline { get; set; }
        public string Category { get; set; }
        public int Limit { get; set; }
        //public static int Programming = 200;
        //public static int Design = 200;
        //public static int SystemAdministration = 200;
         


        public static List<Student> students=new List<Student>();
       

        //public Group(Categories category, bool isOnline )
        //{
        //    switch (category)
        //    {
        //        case Categories.Programming:
        //            No = $"BP{Programming}";
        //            Programming++;
        //            break;
        //        case Categories.Design:
        //            No = $"D{Design}";
        //            Design++;

        //            break;
        //        case Categories.SystemAdministration:
        //            No = $"SA{SystemAdministration }";
        //            SystemAdministration++;
        //            break;
        //        default:
        //            Console.WriteLine("Bele bir kateqoriya yoxdur!!");
        //            break;
        //    }
        //    Category= category;


        //    if (isOnline==true)
        //    {
        //        IsOnline = true;
        //        Limit = 15;
        //        //Console.WriteLine("Group Limit: 15");
        //    }
        //    else
        //    {
        //        Limit = 10;
        //        //Console.WriteLine("Group Limit: 10");

        //    }
        //}
        public Group()
        {
            Console.WriteLine("Group No: ");
            No = Console.ReadLine();
            Console.WriteLine("Group Category: ");
            Category = Console.ReadLine();
            Console.WriteLine("Group IsOnline: ");
            IsOnline = Convert.ToBoolean(Console.ReadLine());
           
                if (IsOnline == true)
                {
                    IsOnline = true;
                    Limit = 15;
                  
                }
                else
                {
                    Limit = 10;
                 
                }

        }


    }
}
