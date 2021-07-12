﻿using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

            // add and remvoe the "" to change the behavior
            object o = 3;
            int j = 4;
            if (o is int i)
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply!");
            }

            A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break; // jump to end of switch statement
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } // end of switch statement
            // string path = "D:\Development\c#\Chapter03"
            string path = @"D:\Development\c#\Chapter03";
            Stream s = File.OPen(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);
            string message = string.Empty;
            switch (s)
            {
            Case FileStream writeableFile when s.CanWrite:
                message = "The stream is a file that I can write to.";
                break;
            Case FileStream readOnlyFile:
                message = "The stream is a read-only file.";
                break;
        }
        }
    }
}
