using System;

namespace Zoolandia
{
    public class Squirrel : Animal
    {
        public string Type { get; set; }
        public bool Male { get; set; }
        public bool Fly { get; set; }

        public override void sleep() 
        {
            Console.WriteLine("Squirrel is awake");
        }
    }
}