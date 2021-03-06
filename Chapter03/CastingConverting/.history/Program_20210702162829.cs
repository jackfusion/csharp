using System;
using static System.Console;
using static System.Convert;
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

            long e = 5_000_000_000;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");
            e = long.MaxValue;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            double[] doubles = new[]
            {
                9.49, 9.5, 9.51, 10.49, 10.5, 10.51
            };
            foreach(double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            foreach (double n in doubles)
            {
                WriteLine(format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                arg0: n,
                arg1: Math.Round(value: n,
                 digits: 0,
                 mode: MidpointRounding.AwayFromZero));
            }

            int number = 12;
            WriteLine(number.ToString());
            bool boolean = true;
            WriteLine(boolean.ToString());
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            object me = new object();
            WriteLine(me.ToString());
        }
    }
}
