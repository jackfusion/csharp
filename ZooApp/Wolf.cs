using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Wolf : Animal, IAnimal
    {
        int speed;
        public void SetSpeed()
        {
            Console.Write("How fast can it run (in km/h)? ");
            speed = Int32.Parse(Console.ReadLine());
        }
        public void GetDescription()
        {
            Console.WriteLine($" contains a {Age}-year-old {Species} that runs {speed} km/h."); //
        }
        public void RequestUniqueCharacteristic()
        {
            SetAge();
            SetSpeed();
        }
    }
}
