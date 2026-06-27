using System;
using System.Collections.Generic;

namespace LoopStudyNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================================================
            //  INTRO: What is a loop?
            //  A loop lets you repeat a block of code many times.
            //  Think of it like telling a robot: "Keep singing 'Happy Birthday' 5 times."
            // ================================================================

            // ================================================================
            //  1. FOR LOOP – "I know exactly how many times to repeat"
            //  Use this when you have a fixed number of steps.
            //  It has 3 parts: start; condition; step (increase/decrease)
            // ================================================================

            Console.WriteLine("===== FOR LOOP =====");
            // Example: Count from 1 to 5
            // int i = 1      → start at 1
            // i <= 5         → keep going as long as i is 5 or less
            // i++            → after each round, add 1 to i
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"For-loop: step {i}");
            }

            // You can also count backwards
            Console.WriteLine("\nCounting backwards:");
            for (int i = 10; i > 0; i -= 2)  // i -= 2 means subtract 2 each time
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // When do we use for? 
            // - When you need an index number.
            // - When you're working with arrays/lists and you know their size.
            // - When you want to do something exactly N times.

            // ================================================================
            //  2. WHILE LOOP – "Check the condition FIRST; if true, keep going"
            //  Use this when you don't know the number of repeats in advance.
            //  The condition is checked at the BEGINNING.
            // ================================================================

            Console.WriteLine("===== WHILE LOOP =====");
            int secretNumber = 7;
            int guess = 0;   // starting with 0 (not 7)

            // While the guess is wrong, keep asking.
            // If guess equals 7, the condition becomes false and loop ends.
            while (guess != secretNumber)
            {
                Console.Write("Guess the number (1-10): ");
                guess = int.Parse(Console.ReadLine()); // pretend user types a number

                if (guess != secretNumber)
                    Console.WriteLine("Wrong, try again!");
            }
            Console.WriteLine("Correct! You got it.\n");

            // Warning: If the condition is always true, you get an infinite loop.
            // Always make sure something changes inside to stop it!

            // ================================================================
            //  3. DO-WHILE LOOP – "Do it once, THEN check the condition"
            //  Use this when you must execute the code at least ONE time.
            //  The condition is checked at the END.
            // ================================================================

            Console.WriteLine("===== DO-WHILE LOOP =====");
            string password = "abc123";
            string userInput;

            // We ask at least once, and keep asking until they get it right.
            do
            {
                Console.Write("Enter the password: ");
                userInput = Console.ReadLine();
                if (userInput != password)
                    Console.WriteLine("Incorrect.");
            } while (userInput != password);

            Console.WriteLine("Access granted!\n");

            // Difference between while and do-while:
            // - while: "Check the door if it's locked. If locked, don't enter."
            // - do-while: "Enter the room, then check if the door is locked. 
            //              If locked, leave and try again." (You enter at least once)

            // ================================================================
            //  4. FOREACH LOOP – "Go through every item in a collection"
            //  Use this when you want to read all items in an array/list 
            //  without caring about the index.
            // ================================================================

            Console.WriteLine("===== FOREACH LOOP =====");
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date" };

            // 'fruit' is a variable that takes each item one by one.
            // The loop stops automatically when it runs out of items.
            Console.WriteLine("Fruits in the basket:");
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }

            // You can also use foreach with an array.
            int[] scores = { 95, 88, 76, 92 };
            int total = 0;
            foreach (int score in scores)
            {
                total += score;   // add each score to total
            }
            Console.WriteLine($"Total scores: {total}\n");

            // IMPORTANT: You CANNOT change the collection while using foreach
            // (e.g., you can't add or remove items inside a foreach loop over a list).
            // Use a 'for' loop if you need to modify the collection.

            // ================================================================
            //  5. NESTED LOOPS – "A loop inside another loop"
            //  Like a clock: the hour hand loops once, but inside, the minute hand loops 60 times.
            //  Use nested loops for tables, grids, or combinations.
            // ================================================================

            Console.WriteLine("===== NESTED LOOPS =====");

            // Example 1: Draw a rectangle with stars (3 rows, 5 columns)
            Console.WriteLine("Drawing a rectangle 3x5:");
            for (int row = 1; row <= 3; row++)        // Outer loop (rows)
            {
                for (int col = 1; col <= 5; col++)    // Inner loop (columns)
                {
                    Console.Write("* ");              // print a star
                }
                Console.WriteLine();                  // go to next line after each row
            }

            // Example 2: Multiplication table (1 to 5 times table)
            Console.WriteLine("\nMultiplication table (1 to 5):");
            for (int i = 1; i <= 5; i++)              // Outer loop: first number
            {
                for (int j = 1; j <= 5; j++)          // Inner loop: second number
                {
                    Console.Write($"{i * j,4}");      // print product, pad to 4 spaces
                }
                Console.WriteLine();                  // new line after each row
            }

            // Example 3: Nested loops with lists (find pairs)
            List<string> colors = new List<string> { "Red", "Blue", "Green" };
            List<string> shapes = new List<string> { "Circle", "Square" };

            Console.WriteLine("\nAll combinations of colors and shapes:");
            foreach (string color in colors)
            {
                foreach (string shape in shapes)
                {
                    Console.WriteLine($"{color} {shape}");
                }
            }

            // How nested loops work:
            // - The outer loop runs once.
            // - For each outer iteration, the inner loop runs completely.
            // - If outer runs 3 times and inner runs 5 times → total 15 iterations.

            // ================================================================
            //  6. BONUS: BREAK and CONTINUE – "Control your loop"
            // ================================================================

            Console.WriteLine("\n===== BREAK and CONTINUE =====");

            // BREAK – "Stop the loop right now, get out!"
            Console.WriteLine("Break example: stop at 3");
            for (int i = 1; i <= 10; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("Breaking at 3!");
                    break;   // loop stops here, no more iterations
                }
                Console.WriteLine($"i = {i}");
            }

            // CONTINUE – "Skip this one round, but keep going with the next"
            Console.WriteLine("\nContinue example: skip even numbers");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)   // if i is even
                {
                    continue;     // skip printing this number, go to next i
                }
                Console.Write(i + " ");  // only odd numbers printed
            }
            Console.WriteLine("\n");

            // ================================================================
            //  7. SUMMARY – Which loop to use when? (Easy guide)
            // ================================================================

            // 1. Use 'for' when:
            //    - You need an index (position number).
            //    - You know exactly how many times to loop (e.g., count 1 to 100).
            //    - You're working with arrays/lists and need the index.

            // 2. Use 'while' when:
            //    - You don't know the number of repetitions.
            //    - The loop might not run at all if the condition is false at start.
            //    - Example: waiting for a user to type "yes".

            // 3. Use 'do-while' when:
            //    - You need the code to run at least once, no matter what.
            //    - Example: showing a menu, asking for a password.

            // 4. Use 'foreach' when:
            //    - You just want to read/use every item in a collection.
            //    - You don't need the index number.
            //    - It's simpler and safer (less chance of index errors).

            // 5. Use nested loops when:
            //    - You need to work with rows and columns (grids, tables).https://github.com/madmonkeysgames-Tanishk/.Cs-Coding/tree/main
            //    - You need to compare each item in one list with each in another.
            //    - You're making combinations or patterns.

            // 6. Use 'break' to exit a loop early.
            //    Use 'continue' to skip the current iteration and move to the next.

            // ================================================================
            //  FINAL THOUGHT – like a game!
            //  Loops let you repeat fun actions. 
            //  Try writing your own loops to print a triangle, countdown, or menu!
            //  Happy coding! 🎮
            // ================================================================

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
