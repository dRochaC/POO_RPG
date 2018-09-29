using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class Hero : BaseUnit
    {

        public int totalExp;

        public ClassType classType;

        public Hero(String name, ClassType classType)
        {
            this.name = name;
            this.classType = classType;
        }

        public bool addGainExp(int giveExp)
        {
            const int baseExp = 200;
            totalExp += giveExp;

            if (totalExp >= baseExp * level)
            {
                level++;
                totalExp = 0;

                return true;
            }

            return false;
        }
    }
}
