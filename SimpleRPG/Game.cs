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
        int playerMaxHealth = 100;
        int playerHealth = 100;
        int playerDamge = 100;
        public void Start()
        {
            Welcome();
            int montsterRemaining = 2;
            bool alive = true;
            //fight til lose
            while (alive && montsterRemaining > 0)
            {
                Console.WriteLine("There are " + montsterRemaining + " monsters remaining");

                alive = Appear(90, 100);
                montsterRemaining--;
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

        bool Appear(int monsterDamge, int monsterHealth)
        {
            //monster appear
            Console.WriteLine("");
            Console.WriteLine("A monster have appeared in front of you!");

            //player choice
            string action = "";
            bool survived = true;
            while (playerHealth > 0 && monsterHealth > 0)
            {
                Console.Write("What will you do? (fight/flee) ");
                Console.WriteLine("");
                action = Console.ReadLine();

                if (action == "fight" || action == "Fight")
                {
                    survived = Fight(ref monsterDamge, ref monsterHealth);
                    if (!survived)
                    {
                        return false;
                    }
                }
                
                else if (action == "flee" || action == "Flee")
                {
                    //escpae
                    Console.WriteLine(playerName + " got away safely.");
                    Console.WriteLine("You and the monster are safe to go home to your families.");
                    return true;
                }

            }
            return survived;

        }
        bool Fight(ref int monsterDamge, ref int monsterHealth)
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
            Console.WriteLine(playerName + " attacks! The monster takes " + playerDamge + " damage.");
            monsterHealth -= playerDamge;
            Console.WriteLine("The monster has " + monsterHealth + " remaining.");
            if (monsterHealth <= 0)
            {
                //monster dead
                Console.WriteLine("The monster is dead now because of you.");
            }
            Console.ReadLine();
            Console.WriteLine("Great job.");
            Console.ReadLine();
            Console.WriteLine("That monster had a family!");
            Console.ReadLine();
            Console.WriteLine("You monster.");
            return true;
        }

        bool Flee()
        {
            
            Console.WriteLine(playerName + " got away safely.");
            Console.WriteLine("You and the monster are safe to go home to your families.");
            return true;
        }

        bool Heal()
        {
            Console.WriteLine(playerName + " have healed.");
            return true;
        }
    }
}