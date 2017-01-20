using System;

namespace Zoolandia
{
    public class Lemus : Animal
    {
        
        public string Color { get; set; }
        public string Home { get; set; }
        public string FavTree { get; set; }
        public bool LikeToPlay { get; set; }
        public Lemus()
        {
            Color = "Red Tailed";
        }
        public Lemus(string color)
        {
            Color = color;
        }
        // Method overloading
        public string LiveInTree()
        {
            Home = "Trees";
            return Home;
        }       
        public void LiveInTree(string favTree)
        {
            Console.WriteLine($"Lemurs like to live in {favTree}");
        } 
        // This is overridden in Lemur.cs
        public virtual void Playful() 
        {
            LikeToPlay = false;
        }
    }

}

