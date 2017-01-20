using System;

namespace Zoolandia
{
    public class Lemur : Lemus
    {
        public override void Playful() 
        {
            LikeToPlay = true;
        }
        public string InCharge { get; set; }
        public string Dominate(string dominate)
        {
            InCharge = dominate;
            return InCharge;
        }
    }
    
}