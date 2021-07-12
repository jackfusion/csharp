using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //string input = "bananas";
                Console.Write("Enter a number between 0 and 255:");
                string input = Console.ReadLine();
                int intInput1 = Int32.Parse(input);

                if (intInput1 < 0 || intInput1 > 255)
                    throw new ArgumentOutOfRangeException();

                //input = "8";
                Console.Write("Enter another number between 0 and 255:");
                string input2 = Console.ReadLine();
                int intInput2 = Int32.Parse(input2);


                if (intInput2 < 0 || intInput2 > 255)
                    throw new ArgumentOutOfRangeException();

                Console.WriteLine("100 divided by 8 is " + intInput1 / intInput2);

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("0: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception: " + e.Message);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("2: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("3: " + e.Message);
            }
        }
    }
}