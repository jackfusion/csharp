using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : Object
    {
        //fields
        public string Name;
        public DateTime DateOfBirth;
        public WonderOfTheAncientWorld FavoriteAcientWonder;
        public WonderOfTheAncientWorld Bucklist;
        public List<Person> Children = new List<Person>();
        // constants
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        // constructors
        public Person(){
            // set defualt values for fields
            // including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }
        // methods

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born a {DateOfBirth:dddd}.");
        }
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        public (string, int) GetFruit()
        {
            return ("Apple", 5);
        }
        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} says 'Hello!'";
        }
        public string SayHelloTo(String name)
        {
            return $"{Name} says 'Hello {name}!'";
        }
    }
}
