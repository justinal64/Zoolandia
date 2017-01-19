using System;

namespace Zoolandia
{
    public class Gorillas : Animal
    {
        public Gorillas()
        {
            HasHair = true;
        }

        public Gorillas(bool hasHair)
        {
            HasHair = hasHair;
        }
        
        public bool Herbivores(bool MeatEater)
        {
            return MeatEater;
        }
        public bool HasHair { get; set; }
        public bool MeatEater { get; set; }

    }

}