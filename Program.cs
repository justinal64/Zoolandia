using System;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Complete
            // Cat.cs is inherting from Felis.cs which inherits from Animal.cs
            // var Cat = new Cat();
            // Cat.Name = "Tom";
            // Cat.Age = 21;
            // Cat.Food = "Meat";
            // Console.WriteLine($"Cat.Name =  {Cat.Name}");
            // Console.WriteLine($"Cat.Age =  {Cat.Age}");
            // Console.WriteLine($"Cat.Food =  {Cat.Food}");
            // Console.WriteLine($"Cat.IsCat =  {Cat.IsCat}");
            // Console.WriteLine($"Cat.IsLazy =  {Cat.IsLazy}");

            // Complete
            // var Gorilla = new Gorilla();
            // Gorilla.HasHair = false;
            // Gorilla.MeatEater = false;
            // Gorilla.Food = "Leaves";
            // Console.WriteLine($"Gorilla.HasHair = {Gorilla.HasHair}");
            // Console.WriteLine($"Gorilla.MeatEater = {Gorilla.MeatEater}");
            // Console.WriteLine($"Gorilla.Food = {Gorilla.Food}");

            // Complete
            // var Lemur = new Lemur();
            // Lemur.Color = "Pink";
            // Lemur.Dominate("Female");
            // Lemur.LikeToPlay = true;
            // Lemur.Home = "Trees";
            // Console.WriteLine($"Lemur.Home = {Lemur.Home}");
            // Console.WriteLine($"Lemur.LikeToPlay = {Lemur.LikeToPlay}");
            // Lemur.LiveInTree("Pine Trees");

            // Complete
            // var BigCats = new BigCats();
            // BigCats.Food = "Meat";
            // BigCats.Name = "DontMessWithMe";
            // BigCats.Sleep(2);
            // Console.WriteLine($"BigCats.Name = {BigCats.Name}");
            // Console.WriteLine($"Ths biggest threat to BigCats is {BigCats.GreatestThreat()}");
            
            // Complete
            // var Koala = new Koala();
            // Koala.Home("Tree tops");
            // Koala.Predator("Humans");
            // Koala.Food = "Leaves";
            // Console.WriteLine($"Koala.Home = {Koala.House}");
            // Console.WriteLine($"Koala.Enemy = {Koala.Enemy}");
            // Console.WriteLine($"Koala.Food = {Koala.Food}");

            // Complete
            var Orangutan = new Orangutan();
            Orangutan.LifeSpan("75 years");
            Orangutan.Food = "Trees";
            Orangutan.HairColor("Pink");
            Console.WriteLine($"Orangutan.Life = {Orangutan.Life}");
            Console.WriteLine($"Orangutan.Food = {Orangutan.Food}");
            Console.WriteLine($"Orangutan.Color = {Orangutan.Color}");
            // Example using an Interface
            Orangutan.Up();
            Orangutan.Down();
            Orangutan.Left();
            Orangutan.Right();
            


        }
    }
}
