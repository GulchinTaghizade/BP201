using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit.Explicit
{
    static class extension
    {
        public static void Extension(this string word, int num)
        {
            if (num % 2 == 1)
            {
                Console.WriteLine(word);
            }
            else
            {
                Console.WriteLine($"{word}'s");
            }
        }

        public static void ToName(this string name)
        {
            StringBuilder result = new StringBuilder();

            result.Append(Char.ToUpper(name[0]));

            for (int i = 1; i < name.Length; i++)
            {
                result.Append(Char.ToLower(name[i]));
            }



            Console.WriteLine(result);
        }


    }
}
