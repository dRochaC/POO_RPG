using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class Enemy : BaseUnit
    {

        int giveExp;

        public Enemy(String name, int giveExp)
        {
            this.name = name;
            this.GiveExp = giveExp;
        }

        public int GiveExp { get => giveExp; set => giveExp = value; }
    }
}
