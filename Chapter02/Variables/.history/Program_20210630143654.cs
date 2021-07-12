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

            // storing a string in a dynamic object
            dynamic anotherName = "ahmed";
            // this compiles but would throw an exception at run-time if you later store a data tyoe that does not have a property named Length.
            int length = anotherName.Length;

            var int population = 66_000_000; // 66 million in UK
            var double weight = 1.88; // in kilograms
            var decimal price = 4.99M; // in pounds sterling
            var string fruit = "Apples"; // strings use double-quotes
            var char letter = 'Z'; // chars use single-quotes
            var bool happy = true; // Booleans have value of true or false
        }
    }
}
