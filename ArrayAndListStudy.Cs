using System;
using System.Collections.Generic;  // This gives us List<T>
using System.Linq;                 // For some extra cool tricks (optional)

namespace ArrayAndListStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            // ============================================================
            // PART 1: ARRAYS – like a row of fixed‑size boxes
            // ============================================================

            // ------------------------------------------------------------
            // 1.1 Declaring and creating an array
            // ------------------------------------------------------------

            // Way 1: Tell the type and size, then fill later
            int[] numbers = new int[5];   // 5 boxes for integers, all empty (0)
            numbers[0] = 10;              // Put 10 in the first box (index 0)
            numbers[1] = 20;              // Put 20 in the second box (index 1)
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Way 2: Declare and fill at the same time
            string[] fruits = new string[] { "Apple", "Banana", "Cherry" };

            // Way 3: Shortcut – let C# guess the size
            double[] scores = { 95.5, 88.0, 76.5 };

            // ------------------------------------------------------------
            // 1.2 Accessing elements (reading and writing)
            // ------------------------------------------------------------

            Console.WriteLine("First fruit: " + fruits[0]);   // Apple
            Console.WriteLine("Third number: " + numbers[2]); // 30

            // Change a value
            fruits[1] = "Blueberry";   // Now Banana becomes Blueberry
            Console.WriteLine("Changed fruit: " + fruits[1]);

            // ------------------------------------------------------------
            // 1.3 Looping through an array
            // ------------------------------------------------------------

            // Using for loop (we know the size)
            Console.WriteLine("\nAll numbers (for loop):");
            for (int i = 0; i < numbers.Length; i++)   // .Length gives the fixed size
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Using foreach (simpler, no index needed)
            Console.WriteLine("\nAll fruits (foreach):");
            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // ------------------------------------------------------------
            // 1.4 Multi‑dimensional arrays – like a table (rows and columns)
            // ------------------------------------------------------------

            // Rectangular array: 2 rows, 3 columns
            int[,] matrix = new int[2, 3];
            matrix[0, 0] = 1; matrix[0, 1] = 2; matrix[0, 2] = 3;
            matrix[1, 0] = 4; matrix[1, 1] = 5; matrix[1, 2] = 6;

            Console.WriteLine("\nMatrix (2x3):");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // You can also initialise directly:
            int[,] preFilled = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // 3x2

            // ------------------------------------------------------------
            // 1.5 Jagged arrays – arrays of arrays (each row can have different length)
            // ------------------------------------------------------------

            int[][] jagged = new int[3][];   // 3 rows, but each row will be an array
            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 4, 5 };
            jagged[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("\nJagged array:");
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.Write("Row " + i + ": ");
                foreach (int val in jagged[i])
                {
                    Console.Write(val + " ");
                }
                Console.WriteLine();
            }

            // ------------------------------------------------------------
            // 1.6 Useful built‑in methods from the Array class
            // ------------------------------------------------------------

            int[] unsorted = { 5, 2, 8, 1, 9 };

            // Sort (ascending)
            Array.Sort(unsorted);
            Console.WriteLine("\nSorted array: " + string.Join(", ", unsorted));

            // Reverse (order)
            Array.Reverse(unsorted);
            Console.WriteLine("Reversed array: " + string.Join(", ", unsorted));

            // Clear (set elements to default value)
            Array.Clear(unsorted, 1, 2); // from index 1, clear 2 elements
            Console.WriteLine("After Clear (index 1 and 2): " + string.Join(", ", unsorted));

            // Copy (copy part of an array to another)
            int[] source = { 10, 20, 30, 40, 50 };
            int[] destination = new int[3];
            Array.Copy(source, 1, destination, 0, 3); // copy 3 items starting from source[1]
            Console.WriteLine("Copied array: " + string.Join(", ", destination));

            // IndexOf – find where an item is
            int index = Array.IndexOf(source, 30); // returns 2
            Console.WriteLine("Index of 30 in source: " + index);

            // ------------------------------------------------------------
            // 1.7 Important: Arrays are fixed size – you can't add or remove items.
            // ------------------------------------------------------------

            // That's why we have Lists!


            // ============================================================
            // PART 2: LISTS – like a stretchy basket that can grow or shrink
            // ============================================================

            // ------------------------------------------------------------
            // 2.1 Creating a List
            // ------------------------------------------------------------

            List<string> names = new List<string>();   // empty list of strings
            List<int> ages = new List<int> { 5, 10, 15 }; // initialised with values

            // ------------------------------------------------------------
            // 2.2 Adding elements
            // ------------------------------------------------------------

            names.Add("Alice");          // add one at the end
            names.Add("Bob");
            names.Add("Charlie");

            // Add many at once using AddRange
            List<string> moreNames = new List<string> { "David", "Eve" };
            names.AddRange(moreNames);

            // Insert at a specific position (index)
            names.Insert(1, "Ben");      // Insert "Ben" at index 1 (second position)

            Console.WriteLine("\nNames after adding and inserting:");
            foreach (string n in names)
                Console.Write(n + " ");
            Console.WriteLine();

            // ------------------------------------------------------------
            // 2.3 Removing elements
            // ------------------------------------------------------------

            names.Remove("Bob");          // removes the first "Bob"
            names.RemoveAt(2);            // removes element at index 2
            names.RemoveRange(0, 2);      // removes 2 elements starting at index 0

            Console.WriteLine("Names after removals:");
            foreach (string n in names)
                Console.Write(n + " ");
            Console.WriteLine();

            // Clear all
            names.Clear();
            Console.WriteLine("After Clear, count = " + names.Count); // 0

            // ------------------------------------------------------------
            // 2.4 Accessing and updating elements
            // ------------------------------------------------------------

            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            Console.WriteLine("\nFirst color: " + colors[0]); // Red
            colors[1] = "Yellow";   // change Green to Yellow

            // ------------------------------------------------------------
            // 2.5 Looping through a List
            // ------------------------------------------------------------

            Console.WriteLine("Colors:");
            for (int i = 0; i < colors.Count; i++)   // .Count is the number of items
                Console.Write(colors[i] + " ");
            Console.WriteLine();

            // foreach works too
            foreach (string c in colors)
                Console.Write(c + " ");
            Console.WriteLine();

            // ------------------------------------------------------------
            // 2.6 Searching in a List
            // ------------------------------------------------------------

            bool containsGreen = colors.Contains("Green"); // false
            int idx = colors.IndexOf("Yellow");            // 1
            Console.WriteLine($"Contains Green? {containsGreen}, Index of Yellow? {idx}");

            // Find all items that start with 'B'
            List<string> words = new List<string> { "Apple", "Banana", "Blueberry", "Cherry" };
            List<string> bWords = words.FindAll(w => w.StartsWith("B"));
            Console.WriteLine("Words starting with B: " + string.Join(", ", bWords));

            // Find the first item that matches a condition
            string found = words.Find(w => w.Length > 5); // "Banana" (first with length >5)
            Console.WriteLine("First word longer than 5 letters: " + found);

            // ------------------------------------------------------------
            // 2.7 Sorting and reversing a List
            // ------------------------------------------------------------

            List<int> numbersList = new List<int> { 42, 17, 8, 99, 23 };
            numbersList.Sort();            // ascending
            Console.WriteLine("Sorted numbers: " + string.Join(", ", numbersList));

            numbersList.Reverse();         // descending
            Console.WriteLine("Reversed numbers: " + string.Join(", ", numbersList));

            // ------------------------------------------------------------
            // 2.8 Capacity vs Count
            // ------------------------------------------------------------

            // Count = actual number of items in the list.
            // Capacity = size of internal array (how many items can fit before resizing)
            List<int> demo = new List<int>();
            Console.WriteLine($"\nInitial: Count={demo.Count}, Capacity={demo.Capacity}");
            demo.Add(1);
            Console.WriteLine($"After 1 add: Count={demo.Count}, Capacity={demo.Capacity}");
            // You can trim excess capacity to save memory (rarely needed)
            demo.TrimExcess();

            // ------------------------------------------------------------
            // 2.9 Converting between Array and List
            // ------------------------------------------------------------

            // Array → List
            string[] arrayOfFruits = { "Apple", "Banana", "Cherry" };
            List<string> listFromArray = arrayOfFruits.ToList();

            // List → Array
            string[] arrayFromList = listFromArray.ToArray();

            Console.WriteLine("\nConverted List from array: " + string.Join(", ", listFromArray));
            Console.WriteLine("Converted Array from list: " + string.Join(", ", arrayFromList));


            // ============================================================
            // PART 3: KEY DIFFERENCES – when to use what?
            // ============================================================

            // 1. Arrays have a fixed size (you set it when you create it).
            //    Lists can grow and shrink dynamically.

            // 2. Arrays are slightly faster (less overhead) but lists are more flexible.

            // 3. Arrays can be multi‑dimensional (like [ , ]), but lists are always one‑dimensional.
            //    (You can have List<List<T>> for a jagged-like structure, but not a rectangular one.)

            // 4. Arrays are created with `new int[5]`; Lists with `new List<int>()`.

            // 5. For most everyday tasks, use List<T> because it's easier.
            //    Use arrays when you know the size won't change and you need maximum performance.


            // ============================================================
            // PART 4: BONUS – using LINQ with collections (advanced but fun)
            // ============================================================

            // LINQ gives you powerful querying capabilities.
            List<int> scoresList = new List<int> { 80, 95, 70, 60, 85 };

            // Get all scores above 80
            var highScores = scoresList.Where(s => s > 80).ToList();
            Console.WriteLine("\nScores above 80: " + string.Join(", ", highScores));

            // Get the average
            double average = scoresList.Average();
            Console.WriteLine("Average score: " + average);

            // Get the sum
            int sum = scoresList.Sum();
            Console.WriteLine("Sum of scores: " + sum);

            // ============================================================
            // PART 5: SUMMARY (in simple words)
            // ============================================================

            // - An array is like a row of boxes that can only hold a certain number of things.
            //   You decide the number when you build it, and you can't change it later.

            // - A list is like a big basket that can hold as many things as you want.
            //   You can add, remove, and insert items anytime.

            // - Both are great for storing many items of the same type.
            //   Use a list unless you have a good reason to use an array.

            // That's it! You now know everything about arrays and lists in C#.
            // Happy coding! 🎉
        }
    }
}
