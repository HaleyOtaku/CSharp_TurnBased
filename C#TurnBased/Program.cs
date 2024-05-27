//Following this tutorial => https://youtu.be/30NsBqPNMzU?si=FLOuY19MjBGOcfva

namespace C_TurnBased
{
    //Remove internal from class name
    class Program
    {
        static void Main(string[] args)
        {
            int playerHP = 40;
            int enemyHP = 20;
            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;

            Random random = new Random();

            while (playerHP > 0 && enemyHP > 0)
            {
                //Player turn
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Player HP - " + playerHP + " | Enemy HP - " + enemyHP);
                Console.WriteLine("Please select...\n\na)Attack\nh)Heal\n");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "a")
                {
                    enemyHP -= playerAttack; //enemyHP = enemyHP - playerAttack;
                    Console.WriteLine("\nPlayer attacks Enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHP += healAmount;//playerHP = playerHP + healAmount;
                    Console.WriteLine("\nPlayer restores " + healAmount + " health points!");
                }

                if (enemyHP > 0)
                {
                    Console.WriteLine("\n\n-- Enemy Turn --");
                    Console.WriteLine("Player HP - " + playerHP + " | Enemy HP - " + enemyHP);
                    //Range below is 0-1 because Random's first value is inclusive, and its second value is exclusive.
                    int enemyChoice = random.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHP -= enemyAttack;//playerHp = playerHP - enemyAttack;
                        Console.WriteLine("\nEnemy attacks Player and deals " + enemyAttack + " damage!\n");
                    }
                    else
                    {
                        enemyHP += healAmount;//enemyHP = enemyHP + healAmount;
                        Console.WriteLine("\nEnemy restores " + healAmount + " health points!\n");
                    }
                }
            }

            if (playerHP > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
