﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        string input = "";
        bool validinputrecieved = false;
        int inputrecieved = 0;

        int power = 200;
        int health = 100;
        int healthRegen = 50;
        int GetInput(string description ,string option1, string option2)
        {
            Console.WriteLine("Choose a story");
            Console.WriteLine("1.Gunslinger");
            Console.WriteLine("2.Brawler");
            Console.Write("> ");
            string input = "";
            int inputrecived = 0;
            return 0;
        }
        int GameOver(string description, string option1, string option2)
        {
            Console.WriteLine("You have died or been arrested either way you failed would you like to restart");
            Console.WriteLine();
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            Console.Write("> ");
            string input = "";
            int inputrecived = 0;
            return 0;
        }

            /// <summary>
            /// prints all even numbers in the range [num1 and num2]
            /// </summary>
            /// <param name="num1">the starting number</param>
            /// <param name="num2">the ending number</param>

        void PrintAllEven(int num1, int num2)
        {
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2== 0)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        
        void PrintPlayerStats()
        {
            Console.WriteLine(health  -= health);
        }
        public void Run()
        {
            
            //health exercise
            int health = 100;
            int healthRegen = 50;
            health = health + healthRegen;
            health += healthRegen;
            Console.WriteLine(health);

            //character stats Gunslinger
            string characterjob = "Gunslinger";

            //gun slinger story options
            string characterchoice = "1";

            void GunslingerStory()
            {

            }

            PrintAllEven(1, 10);
            //start menu
            Console.WriteLine("Welcome to the Wild West!!!");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            //Choose player name
            string name = "Empty";
            Console.WriteLine();
            Console.WriteLine("Choose your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine();

            string input = "";
            bool validinputrecieved = false;
            int inputrecieved = 0;

            while (!(inputrecieved == 1 || inputrecieved == 2))
            {
                //Character select menu
                GetInput("Choose a story", "1.Gunslinger", "2.Brawler");
                
                

                //input from player
                input = Console.ReadLine();

                //gunslinger
                if (input == "1" || input == "Gunslinger")
                {
                    characterjob = "Gunslinger";
                    health = 100;
                    power = 200;
                    Console.WriteLine("Gunslinger");
                    Console.WriteLine("Health 100");
                    Console.WriteLine("Power 200");
                    Console.WriteLine("Two six shooter revolvers");
                    Console.WriteLine();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    validinputrecieved = true;
                    Console.Clear();

                    // gunslinger story
                    if (input == "1" || input == "Gunslinger")
                    {
                        string decide = " ";
                        Console.WriteLine("you are drinking at a bar in a town you have never been to.");
                        Console.WriteLine();
                        Console.WriteLine("press enter to continue");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("4 men wearing bandanas all walk up behind you and stop, telling you to get out of their town");
                        Console.WriteLine();
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        Console.WriteLine("how do you respond?");
                        Console.WriteLine();
                        Console.WriteLine("1.Attack the bandits");
                        Console.WriteLine("2.Apologize and walk away");
                        Console.Write("> ");
                        decide = Console.ReadLine();
                        Console.Clear();

                        if (decide == "1")
                        {
                            Console.WriteLine("You throw ur whiskey on the tallest bandit and throw your chair at his head");
                            Console.WriteLine();
                            Console.WriteLine("The second bandit charges at you, but throw your whiskey glass at his head shattering the glass in his eyes");
                            Console.WriteLine();
                            Console.WriteLine("The third bandit slams a chair over your back knocking you to the ground in a daze you reach for your gun but the bandit throws you over the bar counter");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue");
                            Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("you regain your composure how do you respond");
                            Console.WriteLine();
                            Console.WriteLine("1.Kill the remaining banits");
                            Console.WriteLine("2.Try and talk it out");
                            Console.Write("> ");
                            decide = Console.ReadLine();
                            Console.Clear();

                            if (decide == "1")
                            {
                                Console.WriteLine("You draw your guns shooting the bandits in the knee caps dropping them to ground killing them with a second shot to the head");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("The law rushes over to see what the sound was and see you holding two revolvers standing over 4 dead bodies");
                                Console.WriteLine();
                                Console.WriteLine("you get arrested you fail!!!");
                                Console.WriteLine();
                                Console.WriteLine("Press enter to continue");
                                Console.ReadLine();
                                Console.Clear();
                                GameOver("1", "1", "1");

                            }
                            else if (decide == "2")
                            {
                                Console.WriteLine("You try and talk but the law comes");
                            }
                            else
                            {
                                Console.WriteLine("invalid input");
                            }

                        }
                        else if (decide == "2")
                        {
                            Console.WriteLine("other stuff");
                        }
                            
                    }

                }
                else if (input == "2" || input == "Brawler")
                {
                    characterjob = "Brawler";
                    health = 300;
                    power = 600;
                    Console.WriteLine("Brawler");
                    Console.WriteLine("Health 300");
                    Console.WriteLine("Power 600");
                    Console.WriteLine();
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                    validinputrecieved = true;

                    //brawler story
                    if (input == "2" || input == "Brawler")
                        Console.WriteLine("Stuff happens");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
