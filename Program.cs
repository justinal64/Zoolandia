using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Lion = new Animal();
            Lion.Name = "Scarry";
            Console.WriteLine(Lion.Name); 

            // Console.WriteLine($"I have a Squirrel named {Lion.Name} {Lion.Name} {Lion.Name} {Lion.Name}");
        }
    }
}
