using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //health exercise
            int health = 100 / 2;
            int healthRegen = 50;
            health = health + healthRegen;
            health += healthRegen;
            Console.WriteLine(health);

            //character stats Gunslinger
            string characterjob = "Gunslinger";
            string characterhealth = "100";
            string power = "200";



            //gun slinger story options
            string characterchoice = "1";
            

            
            
            


            //start menu
            Console.WriteLine("Welcome to the game");
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

            while (validinputrecieved == false)
            {
                //Character select menu
                Console.WriteLine("Choose a class");
                Console.WriteLine("1.Gunslinger");
                Console.WriteLine("2.Brawler");
                Console.Write("> ");

                //input from player
                input = Console.ReadLine();

                if (input == "1" || input == "Gunslinger")
                {
                    characterjob = "Gunslinger";
                    characterhealth = "100";
                    power = "200";
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
                            Console.WriteLine("stuff");
                            
                            


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
                    characterhealth = "300";
                    power = "600";
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
