using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // storing a double in an object
            object name = "Amir"; // storing a string in an object

            Console.WriteLine($"{name} in {height} meters tall.");
            //int length1 = name.Length; // gives compiler error!
            int length2 = ((string)name).Length; //tell compiler it is a string
            Console.WriteLine($"{name} has {length2} characters.");

            
        }
    }
}
