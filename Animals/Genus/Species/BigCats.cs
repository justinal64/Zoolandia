using System;

namespace Zoolandia
{
    public class BigCats : Panthera
    {
        public string Threat {get; set; }
        public string GreatestThreat() 
        {
            return "ManKind";
        }
        // overridden from Panthera.cs
        public override string BigCatFamily() 
        {
            BigCats = "Lions, Tiger and Bears oooo myyyyy";
            return BigCats;
        }
    }
    
}