using System;
using System.Collections.Generic;

namespace _04._11._2022
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();

            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("1.Yeni qrup yarat\n2. Qrupların siyahısını goster\n3. Qrup üzərində düzəliş etmək\n4. Qrupdakı tələbələrin siyahısını göstər\n5. Bütün telebelerin siyahısını göstər\n6. Telebe yarat");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        Group grp1 = new Group();
                        groups.Add(grp1);
                        break;
                    case 2:
                        foreach (var item in groups)
                        {
                            Console.WriteLine($"Group No: {item.No}\nGroup Category: {item.Category}\nGroup Limit: {item.Limit}\n\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Please insert Group No: ");
                        string FindNo = Console.ReadLine();
                        bool isExist = true;
                        foreach (var item in groups)
                        {
                            if (item.No == FindNo)
                            {
                                Console.WriteLine("Please insert NEW Group No: ");
                                item.No = Console.ReadLine();
                                break;
                           
                            }
                            else
                            {
                                isExist = false;
                            }
                           
                        }

                        if (!isExist)
                        {
                            Console.WriteLine("This group no is not exist!!!");
                        }
                        else
                        {
                            Console.WriteLine("");
                        }

                        //foreach (var item1 in groups)
                        //{
                        //    if (item1.No == item.No)
                        //    {
                        //        Console.WriteLine("Please try again!!! This group is exist.");
                        //    }

                        //}


                        break;
                    case 4:

                    default:
                        break;
                }
            }






        }
    }
}
//Console.WriteLine("Please insert NEW Group No: ");
//string NewNo = Console.ReadLine();

//bool isExist = false;
//foreach (var item in groups)
//{
//    if (NewNo==item.No)
//    {
//        isExist = true;
//    }
//}

//if (isExist)
//{
//    Console.WriteLine("This group no is already exist!!!");
//}
//else
//{
//    Console.WriteLine("Group No updated.");
//}
