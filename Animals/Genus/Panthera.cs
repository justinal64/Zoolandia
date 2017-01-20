using System;

namespace Zoolandia
{
    public class Panthera : Animal
    {
        // set default values
        private string _size = "Large";
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
        public string BigCats { get; set; }
        public void Sleep()
        {
            Console.WriteLine($"Panthera like to sleep for 8 hours");
        }
        public void Sleep(int hoursSlept)
        {
            Console.WriteLine($"Panthera like to sleep for {hoursSlept} hours");
        }
        public void Sleep(int hoursSlept, string location)
        {
            Console.WriteLine($"Panthera like to sleep in {location} for {hoursSlept} hours");
        }

        // Method will be overridden in BigCats.cs
        public virtual string BigCatFamily() 
        {
            BigCats = "Lions, Tiger and Panthers";
            return BigCats;
        }

    }

}