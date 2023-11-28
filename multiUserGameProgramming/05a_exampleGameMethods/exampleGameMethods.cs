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
            } 
            else 
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

        static int PlayerTurn(int playerCurrentHealth, string playerName)
        {   int playerHealth = playerCurrentHealth;
            while (playerHealth > 0)
            {
                string[] skillList = {"fireball(1)", "icebeam(2)", "thunderbolt(3)","sword slash(4)", "kamikaze(5)", "heal(6)", "guard(7)", "dark void(8)", "holy wrath(9)"};
                //Console.WriteLine(skillList);
                Console.WriteLine("[{0}]", string.Join(", ", skillList)); // Code taken and modified from https://stackoverflow.com/questions/16265247/printing-all-contents-of-array-in-c-sharp
                Console.WriteLine(playerName + ", please select an action from your skill list by typing the number for the skill.");
                int skill = System.Convert.ToInt32(Console.ReadLine());
                //int count = skillList.Count(x => x == skill);
                //Console.WriteLine(count);
                if (skill == 1)
                {
                    Console.WriteLine("You cast Fireball." );
                    break;
                } 
                else if (skill == 2)
                {
                    Console.WriteLine("You cast Icebeam.");
                    break;
                } 
                else if (skill == 3)
                {
                    Console.WriteLine("You cast Thunderbolt.");
                    break;
                } 
                else if (skill == 4)
                {
                    Console.WriteLine("You used Sword Slash.");
                    break;
                } 
                else if (skill == 5)
                {
                    Console.WriteLine("You cast Kamikaze.");
                    break;
                } 
                else if (skill == 6)
                {
                    Console.WriteLine("You cast Heal.");
                    break;
                } 
                else if (skill == 7)
                {
                    Console.WriteLine("You Guard.");
                    break;
                } 
                else if (skill == 8)
                {
                    Console.WriteLine("You used Dark Void.");
                    break;
                } 
                else if (skill == 9)
                {
                    Console.WriteLine("You used Holy Wrath.");
                    break;
                } 
                else
                {
                    Console.WriteLine("Chosen skill not found");
                    continue;
                }
            }
            return skill;
        }   

        /*static string PlayerItemChoose()
        {
            string[] itemList = {"potion", "antidote", "fire-boost", "ice-boost", "thunder-boost", "dark-boost", "light-boost", "revival totem"};
            Console.WriteLine(playerName + ",please select an item from your inventory.");
            string item = Console.ReadLine();
            for (i in range(itemList.Length - 1))
            {
                if (item == itemList[i])
                {
                    Console.WriteLine("You used " + item);
                    break;
                }
                else
                {
                    Console.WriteLine("Chosen item not found.")
                    continue
                }
            }
        }   return item*/



        
        static void Main(string[] args)
        {
            string playerName = NamePlayer();
            int[] stats = GenerateStats();
            ChooseEnemy();
            PlayerTurn(150, playerName);
            GameOver(0);
        }

        




    }
}