using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Warrior : Character
    {
        private int _armor;

        public int Armor
        {
            get { return _armor; }
            set
            {
                if (value < 0)
                { _armor = 0; }
                else
                { _armor = value; }
            }
        }

        public Warrior(string name, int armor) : base(name) 
        {
            Armor = armor;
        }

        public override string GetDesciption()
        {
            return base.GetDesciption() + $" - armor:{Armor}";
        }

        public override bool TakeDamage(int amount)
        {
            return base.TakeDamage(amount - Armor);
        }
    }
}
