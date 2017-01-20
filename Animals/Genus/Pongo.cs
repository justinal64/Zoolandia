// orangutanusing System;

namespace Zoolandia
{

    public class Pongo : Animal
    {
        public Pongo()
        {
            TreeDweller = true;
        }
        public Pongo(bool treeDweller)
        {
            TreeDweller = treeDweller;
        }
        public bool TreeDweller { get; set; }
        public string Life { get; set; }
        public void LifeSpan()
        {
            Life = "35 - 40 years";
        }
        public virtual string LifeSpan(string life) 
        {
            Life = life;
            return Life;
        }

    }
}