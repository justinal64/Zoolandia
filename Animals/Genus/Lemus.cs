//lemursusing System;

namespace Zoolandia
{
    public class Lemus : Animal
    {
        public Lemus()
        {
            Home = "Madagascar";
        }

        public Lemus(string home)
        {
            Home = home;
        }
        
        // public bool Herbivores(bool MeatEater)
        // {
        //     return MeatEater;
        // }
        public string Home { get; set; }


    }

}