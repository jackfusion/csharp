using System;
#nullable enable

namespace NullHandling
{
    class Address{
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int thisCannotbeNull = 4;
            //thisCannotbeNull = null; // compile error!
            int? thisCannotbeNull = null;
            Console.WriteLine(thisCannotbeNull);
            Console.WriteLine(thisCannotbeNull.GetValueOrDefault());
            thisCannotbeNull = 7;
            Console.WriteLine(thisCannotbeNull);
            Console.WriteLine(thisCannotbeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }
}
