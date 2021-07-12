﻿using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive number including 0
            unit naturalNumber = 32;
            // integer means negative or positive whole number including 0
            int integerNumber = -23;
            // float means single-precision floating point F suffix makes it a float literal
            float realNumber = 2.3F;
            // double means double-precision floating point
            double anotherRealNumber = 2.3; // double literal
            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            // check the three variables have the same value
            // both statements output true
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0}.")
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.")
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0}.")
        }
    }
}