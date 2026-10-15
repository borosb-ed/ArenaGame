using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Character
    {
        private string _name;
        private int _health;

        private static int _count;

        public static int Count { get { return _count; } }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get { return _health; }
            set {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > 100)
                {
                    _health = 100;
                }
                else 
                {
                    _health = value;
                }
            }
        }

        public Character(string name) 
        {
            Name = name;
            Health = 100;
            _count++;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public string GetDesciption()
        {
            return $"{Name} ({Health})";
        }
    }
}
