using System;

namespace Zoolandia
{
    public class Gorilla : Animal
    {
        public string Size { get; set; }
        public bool Male { get; set; }
        public bool Carnivore { get; set; }
        public override void sleep() 
        {
            Console.WriteLine("Cat is awake");
        }
    }
    
}