using System;
using static System.Console;

namespace Assignment1
{
    class Program
    {
        public long CountLinesLINQ(FileInfo file)
    => File.ReadLines(file.FullName).Count();
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
