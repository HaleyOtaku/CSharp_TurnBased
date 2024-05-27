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

            while (playerHP > 0 && enemyHP > 0)
            {
                //Player turn
                Console.WriteLine("-- Player Turn --");
                Console.WriteLine("Please select...\n\na)Attack\nh)Heal\n");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "a")
                {
                    enemyHP -= playerAttack; //enemyHP = enemyHP - playerAttack;
                    Console.WriteLine("Player attacks enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHP += healAmount;//playerHP = playerHP + healAmount;
                    Console.WriteLine("Player restores " + healAmount + "health points!");
                }
            }
        }
    }
}
