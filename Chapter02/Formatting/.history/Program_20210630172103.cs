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
        }
    }
}
