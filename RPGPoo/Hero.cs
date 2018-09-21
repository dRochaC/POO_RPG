using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class Hero : BaseUnit
    {
        ClassType classType;

        public Hero(String name, ClassType classType)
        {
            this.name = name;
            this.classType = classType;
        }
    }
}
