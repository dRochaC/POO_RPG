using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    abstract class BaseUnit
    {
        public String name;

        public int life = 100;
        public int mana = 100;

        public int attack = 10;
        public int defense = 10;

        public int level = 1;

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
