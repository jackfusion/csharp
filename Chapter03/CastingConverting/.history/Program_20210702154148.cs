using System;
using static System.Console;
namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; // an int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; // compiler gives an error for this line
            WriteLine(d); // d is losing  the .8 part

            long e 10;
            int f = (int)e;
            WriteLine
        }
    }
}
