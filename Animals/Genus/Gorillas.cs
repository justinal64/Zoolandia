using System;

namespace Zoolandia
{
    public class Gorillas : Animal
    {
        
        public bool HasHair { get; set; }
        public bool MeatEater { get; set; }
        public string FavTree { get; set; }
        public Gorillas()
        {
            HasHair = true;
        }

        public Gorillas(bool hasHair)
        {
            HasHair = hasHair;
        }

        // Method overloading
        public void Herbivores()
        {
            MeatEater = false;
        }        
        public bool Herbivores(bool meatEater)
        {
            return meatEater;
        }
        public void Herbivores(string favFood, int timesADay)
        {
            Console.WriteLine($"Gorillas eat {favFood} {timesADay} times a day");
        }
        // This is overridden in Gorilla.cs
        public virtual void FavoriteTree() 
        {
            FavTree = "Pine Tree";
        }
    }

}

