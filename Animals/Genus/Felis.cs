using System;

namespace Zoolandia
{
    public class Felis : Animal
    {
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

    }

}