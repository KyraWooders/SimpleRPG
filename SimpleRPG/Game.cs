using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Game
    {
        public void Start()
        {
            string playerName = "";
            int playerHealth = 100;


            //welcoming player
            Console.Write("What is your name, warrior? ");
            Console.WriteLine("");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName + ".");

            //monster appear
            int monsterDamge = 13;
            Console.WriteLine("");
            Console.WriteLine("A monster have appeared in front of you!");
            
            //player choice
            string action = "";
            Console.Write("What will you do? (fight/flee) ");
            Console.WriteLine("");
            action = Console.ReadLine();
            if (action == "fight" || action == "Fight")
            {
                //monster attack
                Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamge + " damage!");
                playerHealth = playerHealth - monsterDamge;
                Console.WriteLine(playerName + " has " + playerHealth + " health remaining.");

                //player attack
                Console.WriteLine(playerName + " attacks! The monster is dead now because of you.");
                Console.ReadLine();
                Console.WriteLine("Great job.");
                Console.ReadLine();
                Console.WriteLine("That monster had a family!");
                Console.ReadLine();
                Console.WriteLine("You monster.");
            }
            else if (action == "flee" || action == "Flee")
            {
                //escpae
                Console.WriteLine(playerName + " got away safely.");
                Console.WriteLine("You and the monster are safe to go home to your families.");
            }

            Console.ReadKey();
        }
    }
}
