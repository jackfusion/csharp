using System;
using static System.Console;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            WriteLine("Enter a number between 0 and 255: ");
            string numberOne = ReadLine();
            int number1;
            Int32.TryParse(numberOne, out number1);
            WriteLine("Enter a number between 0 and 255: ");
            string numberTwo = ReadLine();
            int number2;
            Int32.TryParse(numberTwo, out number2);
            WriteLine($"{number1} divided by {number2} is {number1 / number2}");
            }
            catch
            {
                WriteLine("FormatException: Input string was not in a correct format.")
            }
        }
    }
}
