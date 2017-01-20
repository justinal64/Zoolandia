using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Cat.cs is inherting from Felis.cs which inherits from Animal.cs
            var Cat = new Cat();
            Cat.Name = "Tom";
            Cat.Age = 21;
            Cat.Food = "Meat";
            System.Console.WriteLine($"Cat.Name =  {Cat.Name}");
            System.Console.WriteLine($"Cat.Age =  {Cat.Age}");
            System.Console.WriteLine($"Cat.Food =  {Cat.Food}");
            System.Console.WriteLine($"Cat.IsCat =  {Cat.IsCat}");
            System.Console.WriteLine($"Cat.IsLazy =  {Cat.IsLazy}");


            // var Gorilla = new Gorilla();
            // Gorilla.HasHair = false;
            // Gorilla.MeatEater = false;
            // Gorilla.Food = "Leaves";
            // Console.WriteLine($"Gorilla.HasHair = {Gorilla.HasHair}");
            // Console.WriteLine($"Gorilla.MeatEater = {Gorilla.MeatEater}");
            // Console.WriteLine($"Gorilla.Food = {Gorilla.Food}");

            // var Lemur = new Lemur();
            // Console.WriteLine($"Lemur.Home = {Lemur.Home}");
            


        }
    }
}
