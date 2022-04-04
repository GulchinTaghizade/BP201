using System;

namespace Implicit.Explicit
{
    class Program
    {
        static void Main(string[] args)
        {

            Square kvadrat = new Square();
            kvadrat.Side1 = 5;
            Rectangle duzbucaqli = new Rectangle();
            duzbucaqli.Side1 = 6;
            duzbucaqli.Side2 = 7;

            
            Console.WriteLine("Menu:\n1.Rectangula's area\n2.Square's area\n3.Exit");

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    duzbucaqli.CalcArea();
                    break;
                case 2:
                    kvadrat.CalcArea();
                    break;
                case 3:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Menuda bele bir sechim yoxdur");
                    break;
            }

        }
    }
}
