using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            int line = 15;
            for (int i = 1; i <= count; i++)
            {
                /*
                 * here is a logic
                 */
                //Console.Write($"{i}, ");
                //if (i == count)
                //    Console.Write($"{i}.");
                //else
                //    Console.Write($"{i}, ");
                Console.Write($"{i}{(i == count ? "." : ", ")}");

                if (i % line == 0)
                    Console.WriteLine();

            }
        }
    }
}
