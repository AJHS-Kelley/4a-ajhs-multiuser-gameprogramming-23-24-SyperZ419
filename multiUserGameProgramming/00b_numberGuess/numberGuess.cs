// Xavier Oliver, Number Guess, v0.4
/*
Generate secret number from a defined range of numbers.
Print game instructions including range and number of guesses allowed.
    MATCH == first player to score 3 points.
    ROUND == guessing a specific number, until correct or no more attempts.
Ask the player what difficulty they want to play on.
Ask player what their guess is.
Determine if guess is correct or not.
    If guess is correct{
        Tell them they have guessed correctly.
        Award the player a point.
    } else {
        Tell them their guess was incorrect.
        Tell them if their guess is too high or too low.
        Check to see if they have guesses remaining. {
            if guess remain: {
                allow player to guess again.                
            } else {
                CPU wins the round.
            }
        }

    }
*/
using System;

namespace numberGuess
{
    class numberGuess
    {
        static void Main(string[] args)
        {
            int secretNumber = -1;
            int numGuesses = 0; // Number of guesses the player is ALLOWED.
            int numAttempts = 0; // Number of guesses TAKEN.
            int playerGuess = 0;
            int playerScore = 0;
            int cpuScore = 0;
            string difficulty = "";
            int rangeMin = -1;
            int rangeMax = -1;

            Console.WriteLine("Welcome to the Number Guess Game. \nPlease select a difficulty.\n");
            Console.WriteLine("Easy Mode: Range is 0 - 20 with 5 guesses. \nNormal Mode: Range is 0 - 35 with 4 guesses. \nHard Mode: range is 0 - 50 with 3 guesses.\n");

            // Difficulty Selection
            Console.WriteLine("Please type Easy, Normal, or Hard and press ENTER.");
            difficulty = Console.ReadLine();
            // Console.ReadLine() will save to STRING by default.
            Console.WriteLine("You have selected: " + difficulty);
            if (difficulty == "Easy") {
                rangeMin = 0;
                rangeMax = 20;
                numGuesses = 5;   

            } else if (difficulty == "Normal") {
                rangeMin = 0;
                rangeMax = 35;
                numGuesses = 4; 
            } else if (difficulty == "Hard") {
                rangeMin = 0;
                rangeMax = 50;
                numGuesses = 3; 
            } else {
                Console.WriteLine("No difficulty has been detected. \nDefaulting to Normal difficulty.\n");
                rangeMin = 0;
                rangeMax = 35;
                numGuesses = 4; 
            }
            Console.WriteLine("Minimum: " + rangeMin);
            Console.WriteLine("Maximum: " + rangeMax);
            Console.WriteLine("Num. Guesses: " + numGuesses);

            // START THE MATCH
            while (playerScore != 3 && cpuScore != 3) {
                // Any code you want to run BEFORE each round goes here
                // GENERATE SECRET NUMBER
                Random rndNum = new Random();
                secretNumber = rndNum.Next(rangeMin, rangeMax);
                Console.WriteLine(secretNumber); // REMOVE AFTER TESTING
                Console.WriteLine("Player Score: " + playerScore + "\n");
                Console.WriteLine("CPU Score: " + cpuScore + "\n");
                // START EACH ROUND
                for (int i = 0; i < numGuesses; i++) {
                    // Code to guess number goes here
                    Console.WriteLine("You have used " + numAttempts + " attempts this round.\n");
                    Console.WriteLine("Please guess a number between " + rangeMin + " and " + rangeMax + ".\n");
                    playerGuess = System.Convert.ToInt32(Console.ReadLine());
                    if (playerGuess == secretNumber) {
                        Console.WriteLine("You got it right! You've earned a point.");
                        playerScore++;
                        break;
                    } else {
                        if (playerGuess > secretNumber) {
                            Console.WriteLine("Your guess was too high!\n");
                        } else {
                            Console.WriteLine("Your guess was too low!\n");
                        }
                    numAttempts++;
                    }
                    if (numGuesses == numAttempts) {
                        cpuScore++;
                        Console.WriteLine("You ran out of guesses. The CPU gets a point.\n");
                        numAttempts = 0;
                }

            
                }
            }
            if (playerScore >= 3) {
                Console.WriteLine("You have won the game!\n");
            } else {
                Console.WriteLine("You have lost the game!\n");
            }
        }


    }




}