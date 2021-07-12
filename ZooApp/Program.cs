using System;
using System.Collections.Generic;

namespace ZooApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string animalName;
            int cage = 1;

            List<IAnimal> list = new List<IAnimal>();
            while(true){
                if (list.Count == 3)
                {
                    Console.WriteLine("\n Our Zoo is full. Come back later. \n");
                    break;
                }

                Console.Write($"Cage {cage} \n" +
                    $"What is the animal species? ");
                animalName = Console.ReadLine().ToLower();

                cage++;

                switch (animalName)
                {
                    case "lion":
                        Lion lion = new Lion();
                        lion.RequestUniqueCharacteristic();
                        list.Add(lion);
                        break;
                    case "wolf":
                        Wolf wolf = new Wolf();
                        wolf.RequestUniqueCharacteristic();
                        list.Add(wolf);
                        break;
                    case "bear":
                        Bear bear = new Bear();
                        bear.RequestUniqueCharacteristic();
                        list.Add(bear);
                        break;
                    default: Console.Error.WriteLine("\n Invalid entry. Try again. \n"); 
                        cage--;
                        break;
                }
            }
            cage = 1;
            foreach(var animal in list)
            {
                Console.Write($"Cage {cage}");
                animal.GetDescription();
                cage++;
            }
        }
    }
}
