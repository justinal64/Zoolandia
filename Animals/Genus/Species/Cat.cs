using System;

namespace Zoolandia
{
    public class Cat : Felis
    {
        // Method will be overridden in Cat.cs
        public override void Lazy() 
        {
            IsLazy = false;
        }
    }
    
}