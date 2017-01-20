using System;

namespace Zoolandia
{
    public class Koala : Phascolaractos
    {
        // Overwriting a method in Phascolaractos.cs
        public override string Predator(string predator) 
        {
            Enemy = predator;
            return Enemy;
        }
    }
    
}