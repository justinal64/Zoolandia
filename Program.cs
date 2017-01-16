using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Animal.cs only
            var Lion = new Animal();
            Lion.Name = "Scarry";
            System.Console.WriteLine($"What is the lions name? {Lion.Name}\n");

            // Alligator.cs is inheriting from Animal.cs
            // \n is a linebreak
            var Alligator = new Alligator();
            Alligator.Height = "5.2ft";
            System.Console.WriteLine($"What is the Alligators height? {Alligator.Height}\n");

            // Squirrel.cs is inheriting from Animal.cs
            var Squirrel = new Squirrel();
            Squirrel.Name = "Justin";
            Squirrel.Fly = false;
            System.Console.WriteLine($"What is the squirrels name? {Squirrel.Name} \nDoes the squirrel fly? {Squirrel.Fly}");

            // Cat.cs is inherting from Animal.cs
            var Cat = new Cat();
            Cat.Name = "Katie";
            Cat.Carnivore = true;
            Cat.sleep();
            System.Console.WriteLine($"What is the cat's name? {Cat.Name}\nDoes the cat eat meat? {Cat.Carnivore}");
        }
    }
}
