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
                Write($"{i}{(i == count ? "." : ", ")}");
                if (i % line == 0){
                    Console.WriteLine();
                }
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
            }
        }
    }
}
