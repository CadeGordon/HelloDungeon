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

            



            
            
            


            //start menu
            Console.WriteLine("Welcome to the game");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();


            //Choose player name
            string name = "Empty";
            Console.WriteLine();
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + name);
            Console.WriteLine();

            //Character select menu
            Console.WriteLine("Choose a class");
            Console.WriteLine("1.Gunslinger");
            Console.WriteLine("2.Brawler");
            Console.Write("> ");

            //input from player
            string input = Console.ReadLine();

            if (input == "1" || input == "Gunslinger")
            {
                characterjob = "Gunslinger";
                characterhealth = "100";
                power = "200";
                Console.WriteLine("Gunslinger");
                Console.WriteLine("Health 100");
                Console.WriteLine("Power 200");
                Console.ReadLine();
                Console.Clear();
                

            }
            else if (input == "2" || input == "Brawler")
            {
                characterjob = "Brawler";
                characterhealth = "300";
                power = "600";
                Console.WriteLine("Brawler");
                Console.WriteLine("Health 300");
                Console.WriteLine("Power 600");
                Console.ReadLine();
                Console.Clear();

            }

        }
    }
}
