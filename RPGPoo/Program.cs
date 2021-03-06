﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGPoo
{
    class Program
    {
        static void PrintColored(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(value);
            Console.ResetColor();
        }

        static void PrintColoredLine(string value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        static bool isRunning = true;
        
        static void Main(string[] args)
        {
            PrintColoredLine("|| RPG GAME ||\n\n", ConsoleColor.Blue);
            Console.Write("Digite seu nome: ");

            var heroName = Console.ReadLine();

            Console.Write("Escolha sua classe (Warrior [0] - Mage [1] - Ranger [2]): ");

            var classType = (ClassType)Int32.Parse(Console.ReadLine());
            
            var hero = new Hero(heroName, classType);

            while (isRunning)
            {
                Console.Clear();

                var enemy = EnemyCreator.createRandomEnemy();

                Console.Write("Nome: ");
                Console.Write(enemy.name);
                Console.Write("\tAtk: ");
                Console.Write(enemy.attack);
                Console.Write("\tDefense: ");
                Console.Write(enemy.defense);

                var inFight = true;
                while (inFight)
                {
                    Console.Clear();
                    PrintColoredLine("|| INIMIGO ENCONTRADO ||", ConsoleColor.Red);
                    Console.WriteLine("\n\n-> Role o dado de Iniciativa [D] ou Tente Fugir! [F] \n\n");
                    Console.Write("Sua Vida: \t\t");
                    Console.Write(hero.life);
                    Console.Write("\tSua Mana: \t\t");
                    Console.WriteLine(hero.mana);
                    Console.Write("Vida do inimigo: \t");
                    Console.Write(enemy.life);
                    Console.Write("\tMana do inimigo: \t");
                    Console.WriteLine(enemy.mana);
                    
                    
                    var actionType = ActionType.NONE;
                    var controlNotSelected = true;
                    do
                    {
                        var key = Console.ReadKey().Key;
                        var valueDice = Dice.rollD20();

                        switch (key)
                        {
                           
                            case ConsoleKey.D:

                                Console.WriteLine("\n Você Tirou:" + valueDice);
                                
                                break;

                            case ConsoleKey.F:
                                
                                if (valueDice <= 5 || valueDice == 1)
                                {
                                    Console.WriteLine("Você Tirou:" + valueDice + "Impossivel fugir!");
                                }
                                else
                                {
                                    Console.WriteLine("Fuga Bem Sucedida!");
                                    
                                    controlNotSelected = false;
                                }
                                break;
                        }
                    }
                    while (controlNotSelected);

                    switch(actionType)
                    {
                        case ActionType.ATTACK:
                            enemy.takeDamage(hero.attack);
                            hero.takeDamage(0);
                            break;

                        case ActionType.DEFENSE:

                            break;
                    }

                    if (hero.isDead())
                    {
                        Console.WriteLine("\n\nMorreu o hero");

                        inFight = false;
                        isRunning = false;

                    }
                    else if (enemy.isDead())
                    {
                        var levelUp = hero.addGainExp(enemy.GiveExp);

                        if (levelUp)
                        {
                            Console.WriteLine("\t\t Parabéns você alcançou o level:" + hero.level);
                        }

                        Console.Clear();
                        Console.WriteLine("\n\nVoce venceu, obteve " + enemy.GiveExp + " xp");
                        Console.WriteLine("Seu Total de Xp é: " + hero.totalExp);
                        Console.WriteLine("Seu level atual é: " + hero.level);
                        
                        Console.ReadKey();

                        inFight = false;
                    }

                }

            }

            Console.ReadKey();
        }
    }
}

