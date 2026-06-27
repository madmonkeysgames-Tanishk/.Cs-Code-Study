using System;

namespace DecisionMakingNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================================================================
            //  INTRO: What is decision making?
            //  In life, we make decisions: "If it rains, take an umbrella; else, wear sunglasses."
            //  In C#, we use 'if' and 'switch' to make decisions based on conditions.
            //  A condition is something that is either true or false (a boolean).
            // ================================================================

            // ================================================================
            //  PART 1: IF STATEMENT – "If this is true, do that"
            //  The simplest form: if (condition) { code } 
            //  The code inside runs only if the condition is true.
            // ================================================================

            Console.WriteLine("===== PART 1: IF STATEMENT =====");

            int age = 18;

            // Example: Check if you can vote
            if (age >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }

            // If the condition is false, the code is skipped.
            int temperature = 15;
            if (temperature > 30)
            {
                Console.WriteLine("It's hot outside!"); // this won't print
            }

            // You can also have multiple statements inside the block.
            if (temperature < 0)
            {
                Console.WriteLine("It's freezing!");
                Console.WriteLine("Wear a heavy coat.");
            }

            // ================================================================
            //  PART 2: IF-ELSE – "If true do A, else do B"
            //  You have two paths: one for true, one for false.
            // ================================================================

            Console.WriteLine("\n===== PART 2: IF-ELSE =====");

            int number = 7;

            if (number % 2 == 0)   // check if even
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }

            // Another example
            bool isLoggedIn = false;
            if (isLoggedIn)
            {
                Console.WriteLine("Welcome back, user!");
            }
            else
            {
                Console.WriteLine("Please log in.");
            }

            // ================================================================
            //  PART 3: ELSE-IF LADDER – "Many choices"
            //  Use else-if when you have more than two possible conditions.
            //  The first condition that is true will run; the rest are skipped.
            // ================================================================

            Console.WriteLine("\n===== PART 3: ELSE-IF LADDER =====");

            int score = 85;

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }

            // The else at the end is optional – it catches any other case.
            // Note: order matters! Check from most specific to most general.

            // ================================================================
            //  PART 4: NESTED IF – "If inside another if"
            //  You can put an if inside another if. This allows fine-grained decisions.
            // ================================================================

            Console.WriteLine("\n===== PART 4: NESTED IF =====");

            bool hasDrivingLicense = true;
            int driverAge = 20;

            if (hasDrivingLicense)
            {
                Console.WriteLine("You have a license.");
                if (driverAge >= 21)
                {
                    Console.WriteLine("You can rent a car.");
                }
                else
                {
                    Console.WriteLine("You are too young to rent a car.");
                }
            }
            else
            {
                Console.WriteLine("You don't have a license. You cannot drive.");
            }

            // ================================================================
            //  PART 5: COMPARISON OPERATORS – "How to compare things"
            //  These are used to write conditions. They return true or false.
            // 
            //  ==   equal to
            //  !=   not equal to
            //  >    greater than
            //  <    less than
            //  >=   greater than or equal to
            //  <=   less than or equal to
            // ================================================================

            Console.WriteLine("\n===== PART 5: COMPARISON OPERATORS =====");

            int x = 10;
            int y = 20;

            Console.WriteLine($"x == y: {x == y}");   // False
            Console.WriteLine($"x != y: {x != y}");   // True
            Console.WriteLine($"x > y:  {x > y}");    // False
            Console.WriteLine($"x < y:  {x < y}");    // True
            Console.WriteLine($"x >= y: {x >= y}");   // False
            Console.WriteLine($"x <= y: {x <= y}");   // True

            // Compare strings (case-sensitive)
            string name1 = "Alice";
            string name2 = "alice";
            Console.WriteLine($"name1 == name2: {name1 == name2}"); // False

            // To ignore case, use .Equals with StringComparison
            Console.WriteLine($"Ignore case: {name1.Equals(name2, StringComparison.OrdinalIgnoreCase)}"); // True

            // ================================================================
            //  PART 6: LOGICAL OPERATORS – "Combine conditions"
            //  &&  logical AND – both must be true
            //  ||  logical OR  – at least one must be true
            //  !   logical NOT – reverses true/false
            // ================================================================

            Console.WriteLine("\n===== PART 6: LOGICAL OPERATORS =====");

            int age2 = 25;
            bool hasPermission = true;

            // AND: both must be true
            if (age2 >= 18 && hasPermission)
            {
                Console.WriteLine("You can enter the club.");
            }

            // OR: at least one true
            bool isWeekend = false;
            bool isHoliday = true;
            if (isWeekend || isHoliday)
            {
                Console.WriteLine("You don't have to work today.");
            }

            // NOT: reverses a bool
            bool isRaining = false;
            if (!isRaining)
            {
                Console.WriteLine("It's not raining, go outside!");
            }

            // Complex example
            bool isMember = false;
            int age3 = 65;
            if ((isMember && age3 >= 18) || age3 >= 65)
            {
                Console.WriteLine("You get a discount.");
            }

            // ================================================================
            //  PART 7: SWITCH-CASE – "Choose one option from many"
            //  When you have many discrete values (like days of week), switch is cleaner.
            //  Each 'case' checks for a specific value; 'default' handles anything else.
            // ================================================================

            Console.WriteLine("\n===== PART 7: SWITCH-CASE (Traditional) =====");

            int dayNumber = 3;
            string dayName;

            switch (dayNumber)
            {
                case 1:
                    dayName = "Monday";
                    break;   // break exits the switch
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number";
                    break;
            }

            Console.WriteLine($"Day {dayNumber} is {dayName}");

            // ---- Multiple cases for the same action (fall-through) ----
            char gradeLetter = 'B';
            string gradeDescription;

            switch (gradeLetter)
            {
                case 'A':
                case 'B':
                    gradeDescription = "Good job!";
                    break;
                case 'C':
                    gradeDescription = "Average.";
                    break;
                case 'D':
                    gradeDescription = "Needs improvement.";
                    break;
                case 'F':
                    gradeDescription = "Failing.";
                    break;
                default:
                    gradeDescription = "Invalid grade.";
                    break;
            }
            Console.WriteLine($"Grade '{gradeLetter}' means: {gradeDescription}");

            // ================================================================
            //  PART 8: SWITCH WITH PATTERN MATCHING (C# 8+ – modern)
            //  Instead of just values, you can match types and use 'when' conditions.
            //  This makes switch very powerful.
            // ================================================================

            Console.WriteLine("\n===== PART 8: SWITCH WITH PATTERN MATCHING =====");

            // Example 1: Match on type
            object obj = "Hello, World!";
            string message;

            switch (obj)
            {
                case string s:
                    message = $"It's a string with value: {s}";
                    break;
                case int i:
                    message = $"It's an integer: {i}";
                    break;
                case double d:
                    message = $"It's a double: {d}";
                    break;
                case null:
                    message = "It's null.";
                    break;
                default:
                    message = "Unknown type.";
                    break;
            }
            Console.WriteLine(message);

            // Example 2: Using 'when' to add extra conditions
            int numberToCheck = 15;

            switch (numberToCheck)
            {
                case int n when n < 0:
                    Console.WriteLine("Negative number");
                    break;
                case int n when n >= 0 && n <= 10:
                    Console.WriteLine("Number between 0 and 10");
                    break;
                case int n when n > 10 && n <= 20:
                    Console.WriteLine("Number between 11 and 20");
                    break;
                default:
                    Console.WriteLine("Number greater than 20");
                    break;
            }

            // Example 3: Switch expression (shorthand) – returns a value
            // (This is a more concise syntax introduced in C# 8)
            string weather = "sunny";
            string advice = weather switch
            {
                "sunny" => "Wear sunglasses.",
                "rainy" => "Take an umbrella.",
                "cloudy" => "Bring a jacket.",
                _ => "Check the forecast."   // _ means default
            };
            Console.WriteLine($"Weather: {weather} → {advice}");

            // ================================================================
            //  PART 9: TERNARY OPERATOR – "Short if-else"
            //  It's a one-line shorthand: condition ? value_if_true : value_if_false
            //  Use it for simple assignments, not complex logic.
            // ================================================================

            Console.WriteLine("\n===== PART 9: TERNARY OPERATOR =====");

            int age4 = 20;
            string status = (age4 >= 18) ? "Adult" : "Minor";
            Console.WriteLine($"Age {age4} → {status}");

            // Can be nested, but it gets hard to read.
            int score2 = 75;
            string grade2 = score2 >= 90 ? "A" :
                            score2 >= 80 ? "B" :
                            score2 >= 70 ? "C" :
                            score2 >= 60 ? "D" : "F";
            Console.WriteLine($"Score {score2} → Grade {grade2}");

            // ================================================================
            //  PART 10: SHORT-CIRCUIT EVALUATION – "Efficiency"
            //  For && and ||, C# stops evaluating as soon as the result is known.
            //  This can prevent errors and improve performance.
            // ================================================================

            Console.WriteLine("\n===== PART 10: SHORT-CIRCUIT EVALUATION =====");

            // For &&: if first condition is false, second is not evaluated.
            int a = 10;
            if (a > 5 && a < 20)  // both checked
                Console.WriteLine("a is between 5 and 20");

            // This can be useful to avoid null reference errors.
            string text = null;
            // if (text.Length > 0 && text != null) // ERROR: first part causes null reference
            // Correct order: check null first
            if (text != null && text.Length > 0)
                Console.WriteLine("Text has characters.");
            else
                Console.WriteLine("Text is null or empty.");

            // For ||: if first is true, second is skipped.
            bool first = true;
            bool second = false;
            if (first || second)   // second is not evaluated because first is true
                Console.WriteLine("At least one is true.");

            // ================================================================
            //  SUMMARY – "Which tool to use?"
            // ================================================================

            // Use 'if-else' when:
            //   - You have complex conditions with logical operators.
            //   - You need to check ranges (e.g., score >= 80).
            //   - You have a small number of conditions.

            // Use 'switch' when:
            //   - You are comparing a single variable against many discrete values.
            //   - Each case is a constant (like numbers, strings, enums).
            //   - You have many options (more than 3-4) – it's cleaner.

            // Use ternary operator '?:' when:
            //   - You need a simple assignment based on a condition.
            //   - The logic is short and easy to read.

            // Use pattern matching in switch when:
            //   - You need to match on type or add extra conditions with 'when'.
            //   - You prefer a more functional style.

            Console.WriteLine("\n🎉 You now know all about decision making in C#!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
