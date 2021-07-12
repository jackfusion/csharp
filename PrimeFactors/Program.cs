using System;
using static System.Console;
using System.Collections.Generic;

namespace Assignment3
{
    public class Program
    {
        public static string primeFactors(int number)
        {
            var primes = new List<int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }
            }

            return string.Join(" x ", primes);
        }
        static void Main(string[] args)
        {
            WriteLine("Prime factors of 4 are " + primeFactors(4));
            WriteLine("Prime factors of 7 are " + primeFactors(7));
            WriteLine("Prime factors of 30 are " + primeFactors(30));
            WriteLine("Prime factors of 40 are " + primeFactors(40));
            WriteLine("Prime factors of 50 are " + primeFactors(50));
        }
    }
}
