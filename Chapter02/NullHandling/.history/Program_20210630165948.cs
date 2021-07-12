using System;
#nullable enable

namespace NullHandling
{
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
        }
    }
}
