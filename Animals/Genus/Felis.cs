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
        public void HairLength(string hairlength)
        {
            Console.WriteLine($"hairlength = {hairlength}");
        }

        public void HairLength(string hairtype, int hairlength)
        {
            Console.WriteLine($"HairType is {hairtype} and it is {hairlength} inches long");
        }
        // Method will be overridden in Cat.cs
        public virtual void Lazy() 
        {
            IsLazy = true;
        }

    }

}