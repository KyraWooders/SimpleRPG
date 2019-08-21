using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Game
    {
        string playerName = "";
        int playerHealth = 100;
        public void Start()
        {
            Welcome();
            int montsterRemainjng = 5;
            bool alive = true;
            //fight til lose
            while (alive && montsterRemainjng > 0)
            {
                Console.WriteLine("There are " + montsterRemainjng + " monsters remaining");
                alive = appear(50);
                montsterRemainjng--;
            }
            

            //wait input before closeing
            Console.ReadKey();
        }
        void Welcome()
        {
            //welcoming player
            Console.Write("What is your name, warrior? ");
            Console.WriteLine("");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName + ".");
            
        }

        bool appear(int monsterDamge)
        {
            //monster appear
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
                    if (playerHealth <= 0)
                    {
                        //dead player
                        Console.WriteLine("You are dead.");
                        return false;
                    }

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
                else
                {
                    //incorrect spelling
                    Console.WriteLine("No action has meet.");
                    Console.ReadLine();
                }

            return true;
        }
    }
}
