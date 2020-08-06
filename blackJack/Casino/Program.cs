using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino.blackJack;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Whats up, {0}. would you like to join a game of blackjack?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes") //|| answer == "yeah" || answer == "y" || answer == "ya" || answer = "ok") this code is not working the OR operator
            {
                Player player = new Player(playerName, bank);
                Game game = new blackJackGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the Casino. bye bye now!");
            Console.ReadLine();
        }
    }
}
