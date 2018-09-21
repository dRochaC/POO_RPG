using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class Program
    {
        static bool isRunning = true;

        static void Main(string[] args)
        {
            Console.WriteLine("|| RPG GAME ||\n\n");
            Console.Write("Digite seu nome: ");

            var heroName = Console.ReadLine();

            Console.Write("Escolha sua classe (Warrior [0] - Mage [1] - Ranger [2]): ");

            var classType = (ClassType)Int32.Parse(Console.ReadLine());
            
            var hero = new Hero(heroName, classType);

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("|| INIMIGO ENCONTRADO ||\n\n");

                var enemy = EnemyCreator.createRandomEnemy();

                Console.Write("Nome: ");
                Console.Write(enemy.Name);
                Console.Write("\tAtk: ");
                Console.Write(enemy.Attack);
                Console.Write("\tDefense: ");
                Console.Write(enemy.Defense);

                var inFight = true;
                while (inFight)
                {
                    Console.WriteLine("\n\n-> Controles: Atacar [a] - Defender [d]\n\n");
                    Console.Write("Sua Vida: \t\t");
                    Console.Write(hero.Life);
                    Console.Write("\tSua Mana: \t\t");
                    Console.WriteLine(hero.Mana);
                    Console.Write("Vida do inimigo: \t");
                    Console.Write(enemy.Life);
                    Console.Write("\tMana do inimigo: \t");
                    Console.WriteLine(enemy.Mana);

                    var actionType = ActionType.NONE;
                    var controlNotSelected = true;
                    do
                    {
                        Console.Write("\nO que fazer? ");

                        var key = Console.ReadKey().Key;
                        if (key == ConsoleKey.A)
                        {
                            actionType = ActionType.ATTACK;
                            controlNotSelected = false;
                        }
                        else if (key == ConsoleKey.D)
                        {
                            actionType = ActionType.DEFENSE;
                            controlNotSelected = false;
                        }
                    }
                    while (controlNotSelected);

                    switch(actionType)
                    {
                        case ActionType.ATTACK:

                            break;

                        case ActionType.DEFENSE:

                            break;
                    }

                }

            }

            Console.ReadKey();
        }
    }
}
