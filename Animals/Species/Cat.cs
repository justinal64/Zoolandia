using System;

namespace Zoolandia
{
    public class Cat : Animal
    {
        public string Big { get; set; }
        public bool Male { get; set; }
        public bool Carnivore { get; set; }
        public override void sleep() 
        {
            Console.WriteLine("Cat is awake");
        }
    }
    
}