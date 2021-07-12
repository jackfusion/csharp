using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Bear: Animal, IAnimal
    {
        string grizzly;
        public void isGrizzly()
        {
            Console.Write("Is it a grizzly bear (true/false)? ");
            grizzly = Console.ReadLine();
            if (grizzly.ToLower().Equals("no"))
            {
                grizzly = "non-";
            }
            else
            {
                grizzly = "";
            }
        }
        public void GetDescription()
        {
            Console.WriteLine($" contains a {Age}-year-old {grizzly}grizzly {Species}."); //
        }
        public void RequestUniqueCharacteristic()
        {
            SetAge();
            isGrizzly();
        }
    }
}
