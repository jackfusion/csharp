using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Lion : Animal, IAnimal
    {
        string ManeColour;
        public void SetMane()
        {
            Console.Write("What color is its mane? ");
            ManeColour = Console.ReadLine();
        }
        public void GetDescription() 
        {
            Console.WriteLine($" contains a {Age}-year-old {Species} with a {ManeColour} mane."); //
        }

        

        public void RequestUniqueCharacteristic()
        {
            SetAge();
            SetMane();
            
        }
    }
}
