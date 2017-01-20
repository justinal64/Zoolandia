using System;

namespace Zoolandia
{

    public class Phascolaractos : Animal
    {
        public Phascolaractos()
        {
            TreeDweller = true;
        }
        public Phascolaractos(bool treeDweller)
        {
            TreeDweller = treeDweller;
        }
        public bool TreeDweller { get; set; }
        public string House { get; set; }
        public string Enemy { get; set; }
        public string Home()
        {
            House = "tree";
            return House;
        }
        public string Home(string home)
        {
            House = home;
            return House;
        }
        public void Predator()
        {
            Enemy = "People";
        }
        public virtual string Predator(string predator) 
        {
            Enemy = predator;
            return Enemy;
        }

    }
}