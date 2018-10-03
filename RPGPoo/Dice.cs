using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    public static class Dice
    {
        public static Int32 rollD20()
        {
            return new Random().Next(20) + 1;
        }
    }
}
