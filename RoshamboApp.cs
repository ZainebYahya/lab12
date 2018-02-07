using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            string answer = "";
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.WriteLine("Enter your name:");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("\nWould you like to play against The Jets or The Sharks (j/s)?:\n");
            string Choice = Console.ReadLine();
            string OpponentChoice = Validator.validate(Choice);
            do
            {
                Console.WriteLine("\nRock, paper, or scissors? (R/P/S):");
                string Playerchoice = Console.ReadLine();
                Validator.validatechoice(Playerchoice);
                AIplayer p2 = new AIplayer();
                
                Humanplayer p1 = CreatePlayer(PlayerName, Playerchoice);
               
                if (OpponentChoice == "j")
                    RockGame(p1);
                else
                    
                AIGame(p1, p2);
                Console.WriteLine("play again");
                 answer = Console.ReadLine();
            }
            while (answer =="y");


        }

        public static string ChoiceFinder(string Choice)
        {
            string Roshambo = "";
            if (Choice == "r")
                {
                Roshambo = "rock";
            }
            else if (Choice == "p")
            {
                Roshambo = "paper";
            }
            else
            {
                Roshambo = "scissors";
            }
            return Roshambo;
        }
        public static Humanplayer CreatePlayer(string name, string roshambo)
        {
            Humanplayer Player1 = new Humanplayer(name, roshambo);
            return Player1;
        }

        public static object CreateOpponent(string opponent)
        {
            if (opponent == "j")
            {
                Rockplayer TheJets = new Rockplayer();
                return TheJets;
            }
            else
            {
                AIplayer TheSharks = new AIplayer();
                return TheSharks;
            }
        }

        public static void RockGame(Humanplayer player)
        {
            if (player.roshambovalue == "rock")
            {
                Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                Console.WriteLine($"TheJets: rock\nDraw!");
            }
            else if (player.roshambovalue == "paper")
            {
                Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                Console.WriteLine($"TheJets: rock\n{player.name} wins!");
            }
            else
            {
                Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                Console.WriteLine($"TheJets: rock\nTheJets wins!");
            }
        }
        
        public static void AIGame(Humanplayer player, AIplayer computer)
        {
            string data = computer.GenerateRoshambo();
            if (player.roshambovalue == "rock")
            {
                if (computer.roshambovalue == "rock")
                {

                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nDraw!");
                }

                else if (computer.roshambovalue == "paper")
                { Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nTheSharks win!"); }

                else
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\n{player.name} Wins!");
                }

            }
            else if (player.roshambovalue == "paper")
            {
                if (computer.roshambovalue == "rock")
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\n{player.name} Wins!");
                }

                else if (computer.roshambovalue == "paper")
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nDraw!");
                }

                else
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nTheSharks Win!");
                }
            }
            else
            {
                if (computer.roshambovalue == "rock")
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nTheSharks win!");
                }

                else if (computer.roshambovalue == "paper")
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\n{player.name} Wins!");
                }

                else
                {
                    Console.WriteLine($"{ player.name}: {player.roshambovalue}");
                    Console.WriteLine($"TheSharks: {computer.roshambovalue}\nDraw!");
                }
            }
        }
    }
}
