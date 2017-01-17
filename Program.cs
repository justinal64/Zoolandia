using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //  Animal.cs only
            var Lion = new Animal();
            // System.Console.WriteLine($"What is the lions name? {Lion.Name("Scarry")}\n");

            // Alligator.cs is inheriting from Animal.cs
            // \n is a linebreak
            var Alligator = new Alligator();
            Alligator.Height = "5.2ft";
            Alligator.SetAge(5);
            Console.WriteLine("Alligators Name is " + Alligator.Name);
            // System.Console.WriteLine($"What is the Alligators height? {Alligator.Height}\n");

            // Squirrel.cs is inheriting from Animal.cs
            var Squirrel = new Squirrel();
            Squirrel.Fly = false;
            // System.Console.WriteLine($"What is the squirrels name? {Squirrel.Name("Justin")} \nDoes the squirrel fly? {Squirrel.Fly}");

            // Cat.cs is inherting from Animal.cs
            var Cat = new Cat();
            Cat.Carnivore = true;
            Cat.Male = false;
            Cat.Name = "Scratchy";
            System.Console.WriteLine($"What is the cat's name? {Cat.Name}\nDoes the cat eat meat? {Cat.Carnivore}");

            var JustinsAnimal = new Animal("Justin");
            JustinsAnimal.SetAge(6);
            JustinsAnimal.SetHeight(5, "ft");
            JustinsAnimal.Food = "Rice";
            Console.WriteLine($"JustinsAnimal Name is {JustinsAnimal.Name} and my age is {JustinsAnimal.Age} and I like {JustinsAnimal.Food} and I am {JustinsAnimal.Height} tall");
        }
    }
}
