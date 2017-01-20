using System;

namespace Zoolandia
{
    public class Felis : Animal
    {
        // set default values
        private string _size = "small";
        private bool _isCat = true;
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public bool IsCat 
        {
            get { return _isCat; }
            set { _isCat = value; }
        }
        // method overloading
        public bool IsLazy { get; set; }
        public void HairLength()
        {
            Console.WriteLine($"hairlength is 2 inch long");
        }
        public void HairLength(string hairLength)
        {
            Console.WriteLine($"hairlength = {hairLength}");
        }

        public void HairLength(string hairType, int hairLength)
        {
            Console.WriteLine($"HairType is {hairType} and it is {hairLength} inches long");
        }
        // Method will be overridden in Cat.cs
        public virtual void Lazy() 
        {
            IsLazy = true;
        }

    }

}