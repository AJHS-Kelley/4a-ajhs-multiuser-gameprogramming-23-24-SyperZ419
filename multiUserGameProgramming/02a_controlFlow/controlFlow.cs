// Xavier Oliver, Control Flow, v0.8
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            
            // DECLARATIONS
            string favColor = "Blue";
            int luckyNumber = 77;
            float myGPA = 3.63F;
            int myAge = 17;
            bool pineappleOnPizza = false;

            /*
            // if Statements -- Check for a single condition
            if (favColor == "Green") {
                Console.WriteLine("Green with envy");
            }

            if (pineappleOnPizza == true) {
                Console.WriteLine("Incorrect");   
            }

            // if - else Statement -- Checks for a single condition, but has two actions
            if (myAge > 15) {
                Console.WriteLine("You are eligible to drive");
            } else {
                Console.WriteLine("START WALKING SCRUB");
            }   

            // if -- else if -- else -- Checks multiple outcomes
            // WHEN CHECKING NUMBER VALUES, START WITH THE HIGHEST VALUE
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on straight A grades");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making honor roll");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("You are graduation ready");
            } else {
                Console.WriteLine("You should probably study");
            }
            
            // Nested Statements
            if (pineappleOnPizza == true) {
                Console.WriteLine("Eww thats gross. You must be a boomer. How old are you?");   
                if (myAge > 60) {
                    Console.WriteLine("Just as I suspected. What was it like having a dinosaur growing up?");
                } else {
                    Console.WriteLine("Ok, so you're not a boomer, but you still have no taste in food.");
                }
            } else {
                Console.WriteLine("Glad to see you have common sense.");
            }
            */
            // for Loop -- Best for when you know # of iterations needed
            /*

            // for (statement1; statement2; statement3;) {}
                Code to loop.
            }
            statement1 is executed ONCE BEFORE the loop starts
            statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts
            statement3 is executed EVERYTIME after the loop executes
            */
            
            for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
            }
      
            for (int i = 100; i > -1; i--) {
                Console.WriteLine("" + i);
            }

            // Nested Loops
            // Outer Loop
            for (int i = 1; i <= 2; i++) {
                Console.WriteLine("Outer: " + i);

                for (int j = 1; j <= 3; j++) {
                    Console.WriteLine("Inner: "+ j);
                }
            }

            // while Loop -- Best used when # of iterations is unknown
            int x = 0;
            while (x < 1000) {
                Console.WriteLine("" + x);
                x++;
            }
            /*
            int y = 1000
            while (y <= 0) {
                Console.WriteLine("" + y);
                y--;
            }
            */
        }
            // Special Keywords
            // break, will immediately exit a LOOP or an IF/ELSE IF/ELSE block
             for (int i = 0; i < 101; i++) {
                Console.WriteLine("" + i);
                if (i == 50) {
                    break;
                }
            }

            // continue, will SKIP the current iteration and then finish the loop
            for (int i = 0; i < 101; i++) {
                 if (i == 50) {
                    continue;
                Console.WriteLine("" + i);
                }
            }
    }        




}