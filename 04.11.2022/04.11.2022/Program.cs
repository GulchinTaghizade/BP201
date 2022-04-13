using System;
using System.Collections.Generic;


namespace _04._11._2022
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Student> students = new List<Student>();

            for (int i = 1; i != 0; i++)
            {
                Console.WriteLine("1.Yeni qrup yarat" +
                    "\n2. Qrupların siyahısını goster" +
                    "\n3. Qrup üzərində düzəliş etmək" +
                    "\n4. Qrupdakı tələbələrin siyahısını göstər" +
                    "\n5. Bütün telebelerin siyahısını göstər" +
                    "\n6. Telebe yarat");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {

                    case 1:                      //1.Yeni qrup yarat
                        Group grp1 = new Group();
                        groups.Add(grp1);
                        break;
                    case 2:                     //2.Qrupların siyahısını goster
                        foreach (var item in groups)
                        {
                            Console.WriteLine($"Group No: {item.No}" +
                                $"\nGroup Category: {item.Category}" +
                                $"\nGroup Limit: {item.Limit}\n\n");
                        }
                        break;
                    case 3:                                 //3. Qrup üzərində düzəliş etmək
                        //Console.WriteLine("Please insert Group No: ");
                        //string FindNo = Console.ReadLine();
                        //bool isExist = true;
                        //bool isNewExist = true;
                        //foreach (var item in groups)
                        //{
                        //    if (item.No == FindNo)
                        //    {

                        //        isExist = true;
                        //        break;
                        //    }
                        //    else
                        //    {
                        //        isExist = false;
                        //    }

                        //}

                        //if (!isExist)
                        //{
                        //    Console.WriteLine("This group No is not exist!!!");
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Please insert NEW Group No: ");
                        //    string newNo = Console.ReadLine();
                        //    foreach (var item in groups)
                        //    {
                        //        if (newNo != item.No)
                        //        {
                        //            isNewExist = false;
                        //        }
                        //        else
                        //        {
                        //            isNewExist = true;
                        //            Console.WriteLine("This group No is already exist!");
                        //            break;
                        //        }

                        //    }

                        //}


                        //if (!isNewExist)
                        //{
                        //    Console.WriteLine("Group no updated.");
                        //    FindNo = newNo;
                        //}

                        break;
                    case 4:                            //4. Qrupdakı tələbələrin siyahısını göstər
                        Console.WriteLine("Please write the group NO: ");
                        string groupNo = Console.ReadLine();

                        foreach (var item in groups)
                        {
                            if (groupNo==item.No)
                            {
                                Console.WriteLine(students);
                                break;
                            }
                        }



                        break;
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
