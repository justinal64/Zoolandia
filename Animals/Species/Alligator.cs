using System;

namespace Zoolandia
{
    public class Alligator : Animal
    {
        
        public string Type { get; set; }
        public bool Male { get; set; }
        public string Species { get; set; }

        public override void sleep() 
        {
            Console.WriteLine("Alligator is awake");
        }

    }
}