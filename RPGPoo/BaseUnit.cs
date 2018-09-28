using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    abstract class BaseUnit
    {
        protected String name;

        protected int life = 100;
        protected int mana = 100;

        protected int attack = 10;
        protected int defense = 10;

        public string Name { get => name; set => name = value; }
        public int Life { get => life; set => life = value; }
        public int Mana { get => mana; set => mana = value; }
        public int Attack { get => attack; set => attack = value; }
        public int Defense { get => defense; set => defense = value; }

        public void takeDamage(int damage)
        {
            life -= damage;
        }

        public bool isDead()
        {
            return life <= 0;
        }

    }
}
