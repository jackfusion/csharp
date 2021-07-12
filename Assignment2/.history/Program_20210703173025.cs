using System;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;

            WriteLine("Enter a number between 0 and 255: ");
            numberOne = ReadInt();

            WriteLine("Enter a number between 0 and 255: ");
            numberTwo = ReadInt();

            WriteLine($"{numberOne} divided by {numberTwo} is {numberOne / numberTwo}");
        }
    }
}
