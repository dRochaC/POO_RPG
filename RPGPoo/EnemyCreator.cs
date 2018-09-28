using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class EnemyCreator
    {
        static List<String> enemyNames = new List<String>() { "Vitinho", "Raffi Negativo", "Sapo", "Step do mal" };

        public static Enemy createRandomEnemy()
        {
            var randomNumber = new Random().Next(enemyNames.Count);
            var enemyName = enemyNames[randomNumber];
            var giveExp = new Random().Next(100) + 1;
            var enemy = new Enemy(enemyName, giveExp);

            return enemy;
        }
    }
}
