using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxNumber(-120, 151, 45, 89, 0);
            NumOfOnes(7);
        }


        static int MaxNumber(params int[] arr) //Task1
        {
            int max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                {
                    max = item;

                }
            }
            Console.WriteLine(max);
            return max;
        }
        static int NumOfOnes(int num) //Task2
        {
            string Result = "";
            for (int i = 0; num > 0; i++)
            {
                Result = num % 2 + Result;
                num = num / 2;
            }
            int count = 0;
            for (int i = 0; i < Result.Length; i++)
            {
                if (Result[i]%2 == 1)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
            return count;
        }

    }
}
