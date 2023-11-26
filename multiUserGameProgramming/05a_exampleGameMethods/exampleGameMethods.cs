// Xavier Oliver, Template, v0.4
using System;

namespace ExampleGameMethods
{
    class ExampleGameMethods
    {
        static string ChooseEnemy() // Chooses a random enemy from an array. No parameters.
        {
            Random rndNum = new Random();
            string[] enemyList = {"Goblin", "Goblin Chief", "Orc", "Skeleton", "Dragon", "Slime", "Yamato-no-Orochi", "Hydra", "Dark Warlock"}; // List of Potential Enemies
            string enemy = enemyList[rndNum.Next(0, enemyList.Length - 1)];
            Console.WriteLine("You have encountered a " + enemy + "!");
            return enemy; // Returns chosen enemy.
        }

        static int[] GenerateStats() // Generates player stats. No parameters.
        {
            Random rndNum = new Random();
            //int i = 0;
            int[] stats = {1, 2, 3, 4, 5};
            //while (i < 5) {
            stats[0] = (rndNum.Next(1, 30)); // Strength
            stats[1] = (rndNum.Next(1, 30)); // Defense
            stats[2] = (rndNum.Next(1, 30)); // Speed
            stats[3] = (rndNum.Next(1, 30)); // Accuracy
            stats[4] = (rndNum.Next(1, 15)); // Luck
            Console.WriteLine("Strength: " + stats[0]);
            Console.WriteLine("Defense: " + stats[1]);
            Console.WriteLine("Speed: " + stats[2]);
            Console.WriteLine("Accuracy: " + stats[3]);
            Console.WriteLine("Luck: " + stats[4]);
            return stats; // Returns array of stats.
        }

        static string NamePlayer()  // Obtains character's name from user input. No parameters.
        {
            Console.WriteLine("Name your character.");
            string name = Console.ReadLine();
            Console.WriteLine("Your input name is " + name + " correct?\n Please type 1(yes) or 2(no)");
            int nameConfirm = System.Convert.ToInt32(Console.ReadLine());
            if (nameConfirm == 1)
            {
                Console.WriteLine("Character name confirmed");
            } else 
            {
                Console.WriteLine("Please re-input the name of your character");
                name = Console.ReadLine();
                Console.WriteLine("Character name confirmed");
            }
            return name; // Returns name of character.
        }

        static void GameOver(int playerCurrentHealth) // Checks to see if the player's health is less than or equal to zero, then tells them the game has ended. Requires player's current health. No return.
        {
            if (playerCurrentHealth <= 0)
            {
                Console.WriteLine("You have lost all of your health. \nGame Over.");
            }
        }

        static string PlayerTurn()
        {
            pass;
        }





        
        static void Main(string[] args)
        {
            string[] skillList = {"fireball", "icebeam", "thunderbolt","sword slash", "kamikaze", "heal", "guard", "dark void", "holy wrath"};
            string[] itemList = {"potion", "antidote", "fire-boost", "ice-boost", "thunder-boost", "dark-boost", "light-boost", "revival totem"};
            int playerHealth = 150;
            NamePlayer();
            int[] stats = GenerateStats();
            ChooseEnemy();
            GameOver(playerHealth);
        }

        




    }
}