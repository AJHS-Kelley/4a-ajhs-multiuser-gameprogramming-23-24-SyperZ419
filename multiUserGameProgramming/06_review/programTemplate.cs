// Xavier Oliver, Review, v0.2
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {

            // Declaring and Assigning Variables
            // Integer -- -2,147,483,648 to 2,147,483,647
            // Integer 4 bytes
            //int smtGames = 6;

            // Long -- -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            // Long -- 8 bytes
            long length = 8349829829489239;

            // Boolean -- true/false
            // Boolean = 1 bit
            bool correct = false;

            // String -- 
            // 2 bytes PER CHARACTER
            // Must be in DOUBLE QUOTES " "
            string food = "potato";

            // Float -- Stores up to 6-7 decimal digits
            // Float -- 4 bytes
            float percent = 23.78F;

            // Double -- Stores up to 15 decimal digits
            // Double -- 8 bytes
            //double myDouble = 10.83467347D;

            // Character (char)
            // Single character, in SINGLE QUOTES ' '
            // 2 bytes
            char myChar = 'C';

            // Type Casting -- changing one data type to another
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double
            
            int myInt = 9;
            double myDouble = myInt;
            Console.WriteLine(myDouble);
            
            // EXPLICIT -- Must be done manually when going larger -> smaller
            // double -> float -> long -> int -> char
            double exampleDouble = 9.945738349D;
            int myInt = (int) myDouble;

            // Conversion Methods
            Convert.ToString(); //String
            Convert.ToDouble(); //Double
            Convert.ToInt32(); //Integer
            Convert.ToInt64(); //Long

            Convert.ToString(myChar);
            Convert.ToDouble(percent);
            Convert.ToInt32(length);
            Convert.ToInt64(exampleDouble);


            
        }

    }




}