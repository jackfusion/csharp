using System;
using static System.Console;
using static System.Convert;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age? ");
            string input = Console.ReadLine();
            try 
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years ols.");
            }
            catch 
            {
            }
            WriteLine("After parsing");
        }
    }
}
