using System;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePreApple = 0.35M;
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePreApple * numberOfApples);
            string formatted = string.Format(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePreApple * numberOfApples);
            //WriteToFile(formatted); //Write the string into a file

            Console.WriteLine($"{numberOfApples} apples costs {pricePreApple * numberOfApples:C}");

            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Banana";
            int bananasCount = 56789;
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: "Name",
                arg1: "Count");
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);
            Console.WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);

            //Write("Type your First name and press Enter: ");
            //string firstName = ReadLine();
            //Write("Type your age and press Enter: ");
            //string age = ReadLine();
            //WriteLine($"Hello {firstName}, you look good for {age}.");

            Console.WriteLine("Press any key combination: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
            arg0: key.Key,
            arg1: key.KeyChar,
            arg2: key.Modifiers);
        }
    }
}
