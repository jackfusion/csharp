using System;
using static System.Console;
using System.Runtime.CompilerServices;

namespace Assignment1
{
    class Program
    {
        static void WriteLine(string message, [CallerLineNumber] int lineNumber = 0)
        {
            Console.WriteLine(lineNumber + ": " + message);
        }
        static void Main(string[] args)
        {
            int count = 100;
            int line = 16;
            for (int i = 1; i <= count; i++)
            {
                if (i % line == 0)
                {
                    Console.WriteLine();
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("Fizzbuzz");

                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                else
                {

                    Console.Write(i);

                }
                Console.Write($"{(i == count ? "." : ", ")}");
            }
        }
        }
    }
