using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Character
    {
        private int _mana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else 
                {
                    _mana = value;
                }
            }
        }

        public Mage(string name, int mana) : base(name)  
        {
            Mana = mana;
        }

        public override string GetDesciption()
        {
            return base.GetDesciption() + $" - mana:{Mana}";
        }
    }
}
