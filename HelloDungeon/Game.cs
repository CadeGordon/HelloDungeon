using System;
using System.Collections.Generic;
using System.Text;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //start menu
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("Type start to continue");
            Console.ReadLine();


            //Choose player name
            string name = "Empty";
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
        }
    }
}
