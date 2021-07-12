using System;
using static System.Console;

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
                if (i % 3){
                    Write("fizz");
                }
                Write($"{i}{(i == count ? "." : ", ")}");

                if (i % line == 0)
                    Console.WriteLine();

            }
        }
    }
}
