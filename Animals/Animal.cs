using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Food { get; set; }
        public virtual void sleep() 
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}