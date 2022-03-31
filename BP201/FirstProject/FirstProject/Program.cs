
using System;
using System.Text;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa sayi daxil edin");
            int num = Int32.Parse(Console.ReadLine());

            Book[] book = new Book[num];

            for (int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();
                book[i].No = Int32.Parse(Console.ReadLine());
                book[i].Name = Console.ReadLine();
                book[i].Price = Int32.Parse(Console.ReadLine());
                book[i].Genre = Console.ReadLine();


            }


        }
    }
} 