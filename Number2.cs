using System;

namespace CodingChalengeClh
{
    class Number2
    {
        public static void Answer()
        {
            int num = 28;
         //   int num = 7;
         //   int num = 15;
            int add = 0;

            for (int i = 1; i<num; i++)
            {
                if (num % i == 0)
                {
                    add+=i;
                }
            }
            Console.WriteLine(add == num);
            // {
            //     Console.WriteLine("true");
            // }
            // else
            // {
            //      Console.WriteLine("false");
            // }
        }
    }
}