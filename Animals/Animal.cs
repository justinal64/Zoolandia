using System;

namespace Zoolandia
{
    public class Animal : IClimb
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
        public string Color { get; set; }
         public string HairColor()
        {
            Color = "Red";
            return Color;
        }
        public string HairColor(string color)
        {
            Color = color;
            return Color;
        }

        public virtual void sleep() 
        {
            Console.WriteLine("Animal is sleeping");
        }

        public void Up()
        {
            Console.WriteLine("Going Up");
        }

        public void Down()
        {
            Console.WriteLine("Going Down");
        }

        public void Left()
        {
            Console.WriteLine("Going Left");
        }

        public void Right()
        {
            Console.WriteLine("Going Right");
        }
    }
}