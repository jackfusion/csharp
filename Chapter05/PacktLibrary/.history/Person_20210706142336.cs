using System;
using System.Collections.Generic;

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
    }
}
