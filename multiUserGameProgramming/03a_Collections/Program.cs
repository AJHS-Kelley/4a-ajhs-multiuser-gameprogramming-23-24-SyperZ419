﻿// 03_Collections, Xavier Oliver, v0.5b
using System;
using System.Linq;

namespace _03_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CANNOT change
            -- Contents of elements in an array CAN change
            -- Items in the array are called ELEMENTS
            -- Arrays are ordered, meaning each item has a fixed position
            -- The position in the array is known as the INDEX
            -- FIrst element in an array is index 0
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Parfait"};
            int[] testScores = {99, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};
            

            // Print Array Elements -- All Elements on Single Line
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();
            

            /* Print Array Contents -- Each Element on Seperate Lines
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join("\n", GPA));
            Console.WriteLine();
            */

            /*/ Determining Array Length
            Console.WriteLine("The length of each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods.Length);
            Console.WriteLine("testScores: " + testScores.Length);
            Console.WriteLine("GPA: " + GPA.Length);

            // Accessing Array Elements -- use the index
            Console.WriteLine("The first element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[0]);
            Console.WriteLine("testScores: " + testScores[0]);
            Console.WriteLine("GPA: " + GPA[0]);

            // Access Last Element
            Console.WriteLine("The last element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[breakfastFoods.Length - 1]);
            Console.WriteLine("testScores: " + testScores[testScores.Length - 1]);
            Console.WriteLine("GPA: " + GPA[GPA.Length - 1]);

            // WYOC -- Access the third element in each array and print to the screen.
            Console.WriteLine("The first element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[2]);
            Console.WriteLine("testScores: " + testScores[2]);
            Console.WriteLine("GPA: " + GPA[2]);
            */

            /* Changing Array Elements -- 
            breakfastFoods[0] = "Fried Squid";
            testScores[0] = 59;
            GPA[0] = 1.34f;
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();
            

            // WYOC -- Update 5th element from each array
            breakfastFoods[4] = "French Toast";
            testScores[4] = 47;
            GPA[4] = 1.56f;
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();
            Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
            Console.WriteLine();
            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();
            

            // Common Bugs working with arrays
            // Index Out of Bounds -- Accessing an element that does not exist
            // Console.WriteLine(breakfastFoods[7]);
            // Fix: Console.WriteLine(breakfastFoods[4]);

            // Incorrect Data Type
            // testScores[0] = "Billy"; // If possible, use the correct Convert.() If not possible, manually change to correct data type.
            */

            // Common Array Methods - Sort() -- Sorts in alphabetical or numerical order, ascending
            int[] newIntArr = {25, -25, 0, -10, 15, 50, -35, 75, -155, 95, -65, 85};
            string[] newStringArr = {"Zebra", "Aardvark", "Emu", "Cow", "Frog", "Platypus", "Gorilla", "Ibis", "Horse"};
            /*
            Console.WriteLine("The elements for each array are:\n");
            Console.WriteLine("newIntArr: \n" + String.Join(", ", newIntArr));
            Console.WriteLine();
            Console.WriteLine("newStringArr: \n" + String.Join(", ", newStringArr));
            Console.WriteLine();
            // Sort Each Array
            Array.Sort(newIntArr);
            Array.Sort(newStringArr);
            Console.WriteLine("The SORTED elements for each array are:\n");
            Console.WriteLine("newIntArr: \n" + String.Join(", ", newIntArr));
            Console.WriteLine();
            Console.WriteLine("newStringArr: \n" + String.Join(", ", newStringArr));
            Console.WriteLine();
            */

            // Common Array Methods - Min(), Max(), and Sum()
            Console.WriteLine("The minimum value for newIntArr is:");
            Console.WriteLine(newIntArr.Min());
            Console.WriteLine("The maximum value for newIntArr is:");
            Console.WriteLine(newIntArr.Max());
            Console.WriteLine("The sum value for newIntArr is:");
            Console.WriteLine(newIntArr.Sum());


        }  
    }
}
