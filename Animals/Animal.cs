using System;

namespace Zoolandia
{
    public class Animal
    {
        // This sets the default name 
        public string Name { get; set; }
        // Constructor overloading using string
        public Animal() 
        { 
            Name = "Bob";
        }

        // This is used if the user passes a name in
        public Animal(string name)
        {
            Name = name;
        }

        public int Age { get; set; }

        public string Height { get; set; }
        // Constructor overload using int and string
        public void SetHeight()
        {
            Height = "0";
        }
        public string SetHeight(int height, string measurment)
        {   
            Height = height + measurment;
            return Height;
        }
        
        public string Weight { get; set; }
        public string Food { get; set; }

        public virtual void sleep() 
        {
            Console.WriteLine("Animal is sleeping");
        }
        

    }
}