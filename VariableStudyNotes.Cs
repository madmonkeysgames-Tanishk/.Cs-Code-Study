using System;

namespace VariableStudyNotes
{
    class Program
    {
        // This is a CLASS-LEVEL variable (we'll talk about scope later)
        static string classLevelGreeting = "Hello from the class!";

        static void Main(string[] args)
        {
            // ================================================================
            //  INTRO: What is a variable?
            //  A variable is like a BOX with a NAME.
            //  You put data (like numbers or text) inside the box.
            //  The box has a TYPE – it tells what kind of data can go in.
            //  Example: a "number box" can only hold numbers.
            // ================================================================

            // ================================================================
            //  PART 1: DECLARING VARIABLES – "Making a box"
            //  Syntax: type name = value;
            //  - type: what kind of data (int, string, bool, etc.)
            //  - name: what you call it (must follow rules)
            //  - value: what you put inside (optional at first)
            // ================================================================

            Console.WriteLine("===== PART 1: DECLARING VARIABLES =====");

            // Way 1: Declare and assign later
            int age;           // Makes a box named 'age' that can hold whole numbers
            age = 25;          // Now put 25 inside

            // Way 2: Declare and assign at the same time (most common)
            int score = 100;   // Box named 'score', holds 100

            // Way 3: Multiple variables on one line (but don't overdo it)
            int x = 5, y = 10, z = 15;

            Console.WriteLine($"Age: {age}, Score: {score}, X: {x}");

            // ================================================================
            //  PART 2: DATA TYPES – "Different kinds of boxes"
            //  C# has many built-in types. Here are the most important ones.
            // ================================================================

            Console.WriteLine("\n===== PART 2: DATA TYPES =====");

            // ----- 2.1 WHOLE NUMBERS (integers) -----
            // int – most common, holds numbers from -2B to +2B
            int playerLives = 3;

            // byte – very small (0 to 255), good for small numbers
            byte level = 5;

            // long – very large whole numbers (like for big calculations)
            long population = 8_000_000_000L;  // note the 'L' suffix

            Console.WriteLine($"int: {playerLives}, byte: {level}, long: {population}");

            // ----- 2.2 DECIMAL NUMBERS (floating point) -----
            // float – 32-bit, less precise, use with 'f' suffix
            float temperature = 36.5f;

            // double – 64-bit, more precise, default for decimals
            double pi = 3.14159265359;

            // decimal – 128-bit, most precise, use for money/currency (avoid rounding errors)
            decimal price = 19.99m;  // note the 'm' suffix

            Console.WriteLine($"float: {temperature}, double: {pi}, decimal: {price}");

            // ----- 2.3 TEXT -----
            // string – holds text (words, sentences). Use double quotes " "
            string name = "Alice";

            // char – holds a SINGLE character. Use single quotes ' '
            char grade = 'A';
            char symbol = '$';

            Console.WriteLine($"string: {name}, char: {grade}, char: {symbol}");

            // ----- 2.4 TRUE/FALSE (logical) -----
            // bool – holds either true or false
            bool isGameOver = false;
            bool isPlayerAlive = true;

            Console.WriteLine($"isGameOver: {isGameOver}, isPlayerAlive: {isPlayerAlive}");

            // ----- 2.5 OTHER USEFUL TYPES -----
            // DateTime – holds a date and time
            DateTime today = DateTime.Now;   // current date/time
            DateTime birthday = new DateTime(2000, 1, 1); // Jan 1, 2000

            Console.WriteLine($"Today: {today}, Birthday: {birthday.ToShortDateString()}");

            // ================================================================
            //  PART 3: NAMING RULES – "What can you name your box?"
            //  Rules (you MUST follow):
            //  1. Can contain letters, digits, and underscore _
            //  2. Must start with a letter or underscore (not a digit)
            //  3. Cannot use C# keywords (like int, class, if, etc.)
            //  4. Case-sensitive (myName and MyName are different)
            //
            //  Conventions (good practice, not rules):
            //  - Use camelCase for local variables: myFirstVariable
            //  - Use meaningful names, not single letters (except loops)
            //  - Name it so you know what it's for (e.g., playerScore, not ps)
            // ================================================================

            Console.WriteLine("\n===== PART 3: NAMING RULES =====");

            // ✅ Good names
            int playerScore = 1000;
            string playerName = "Bob";
            bool isGameActive = true;

            // ❌ Bad names (don't do this)
            // int 2ndPlace = 2;     // ERROR: starts with a number
            // string class = "Math"; // ERROR: 'class' is a C# keyword
            // int my-score = 5;     // ERROR: hyphen not allowed

            // ✅ Underscore is allowed (often used for unused variables)
            int _tempValue = 99;

            Console.WriteLine($"Good variable examples: {playerScore}, {playerName}, {isGameActive}");

            // ================================================================
            //  PART 4: TYPE INFERENCE – "Let C# guess the type using 'var'"
            //  When you use 'var', C# figures out the type from the value.
            //  It's like saying: "C# know what this box is, just fill it!"
            // ================================================================

            Console.WriteLine("\n===== PART 4: TYPE INFERENCE (var) =====");

            var city = "London";        // C# knows it's a string
            var population2 = 9_000_000; // C# knows it's an int
            var pi2 = 3.14;             // C# knows it's a double (not float)
            var isRaining = false;      // C# knows it's a bool

            // ⚠️ IMPORTANT: You MUST assign a value when using 'var'
            // var something;   // ERROR! C# can't guess without a value.

            Console.WriteLine($"var string: {city}, var int: {population2}, var double: {pi2}");

            // When to use 'var' vs explicit type?
            // - Use 'var' when the type is obvious (e.g., new List<int>())
            // - Use explicit types when it's not clear (e.g., var result = GetData())
            // - Many developers use 'var' all the time. It's personal preference.

            // ================================================================
            //  PART 5: CONSTANTS – "A box that cannot be changed"
            //  Use 'const' to make a variable that stays the same forever.
            //  Like a mathematical PI or a company name.
            // ================================================================

            Console.WriteLine("\n===== PART 5: CONSTANTS =====");

            const double Pi = 3.14159;
            const string CompanyName = "MyCompany Inc.";
            const int MaxPlayers = 10;

            // Pi = 3.14;   // ❌ ERROR! Cannot change a constant

            Console.WriteLine($"Pi = {Pi}, Company = {CompanyName}, MaxPlayers = {MaxPlayers}");

            // You can also use 'readonly' (similar but can be set at runtime in constructors).
            // For beginners, just know 'const' means "never changes".

            // ================================================================
            //  PART 6: CONVERTING BETWEEN TYPES – "Changing one box to another"
            //  Implicit (automatic) – safe conversion (no data loss).
            //  Explicit (casting) – you tell C# to do it (may lose data).
            // ================================================================

            Console.WriteLine("\n===== PART 6: CONVERTING TYPES =====");

            // ----- 6.1 Implicit Conversion (automatic) -----
            // Happens when you go from smaller to bigger (safe).
            int myInt = 100;
            double myDouble = myInt;   // int → double (automatic, no data loss)
            Console.WriteLine($"int to double: {myDouble}");

            // ----- 6.2 Explicit Conversion (casting) -----
            // You must do it when you go from bigger to smaller (possible data loss).
            double anotherDouble = 9.99;
            int anotherInt = (int)anotherDouble;   // (int) is a cast – drops the .99
            Console.WriteLine($"double to int: {anotherInt} (lost the decimal!)");

            // ----- 6.3 Using Convert class (safe and flexible) -----
            string numberText = "123";
            int parsedNumber = Convert.ToInt32(numberText);   // string → int
            double parsedDouble = Convert.ToDouble("45.67");
            bool parsedBool = Convert.ToBoolean("true");

            Console.WriteLine($"Converted string to int: {parsedNumber}");
            Console.WriteLine($"Converted string to double: {parsedDouble}");
            Console.WriteLine($"Converted string to bool: {parsedBool}");

            // ----- 6.4 Using Parse (similar) -----
            int parseInt = int.Parse("456");
            Console.WriteLine($"Parsed int: {parseInt}");

            // ----- 6.5 TryParse (safe – doesn't crash if it fails) -----
            string maybeNumber = "abc";
            if (int.TryParse(maybeNumber, out int result))
                Console.WriteLine($"Parsed successfully: {result}");
            else
                Console.WriteLine($"Failed to parse '{maybeNumber}' (but program didn't crash!)");

            // ================================================================
            //  PART 7: NULL AND NULLABLE TYPES – "An empty box"
            //  Reference types (like string) can be null (empty).
            //  Value types (like int, bool) CANNOT be null by default.
            //  But you can make them nullable using '?' – they become "optional".
            // ================================================================

            Console.WriteLine("\n===== PART 7: NULL AND NULLABLE TYPES =====");

            // string is a reference type – it CAN be null
            string myName = null;      // perfectly fine (no text)
            Console.WriteLine($"string with null: {myName ?? "NO NAME"}" );

            // int is a value type – it CANNOT be null (by default)
            // int myAge = null;   // ❌ ERROR!

            // To make a value type nullable, add '?'
            int? myAge = null;         // now it's allowed!
            bool? isLoggedIn = null;   // could be true, false, or "unknown"

            // Check if nullable has a value using .HasValue
            if (myAge.HasValue)
                Console.WriteLine($"Age is: {myAge.Value}");
            else
                Console.WriteLine("Age is not set (null)");

            // You can also use the null-coalescing operator ?? to provide a default
            int actualAge = myAge ?? 0;   // if null, use 0
            Console.WriteLine($"Actual age (with default): {actualAge}");

            // ================================================================
            //  PART 8: DEFAULT VALUES – "What's inside a brand new box?"
            //  When you declare a variable without assigning, it gets a default.
            // ================================================================

            Console.WriteLine("\n===== PART 8: DEFAULT VALUES =====");

            int defaultInt;         // default is 0
            bool defaultBool;       // default is false
            string defaultString;   // default is null (for reference types)
            double defaultDouble;   // default is 0.0

            // We have to assign before using, but these are their defaults:
            Console.WriteLine($"Default int: {default(int)}");
            Console.WriteLine($"Default bool: {default(bool)}");
            Console.WriteLine($"Default string: {default(string) ?? "null"}");
            Console.WriteLine($"Default double: {default(double)}");

            // You can also use the 'default' keyword:
            int numberDefault = default;  // gives 0
            string stringDefault = default; // gives null

            // ================================================================
            //  PART 9: SCOPE – "Where does your variable live?"
            //  A variable only exists inside the curly braces { } where it's declared.
            //  You can't use it outside.
            // ================================================================

            Console.WriteLine("\n===== PART 9: SCOPE =====");

            // This is a LOCAL variable (only inside Main method)
            string localVar = "I am inside Main";

            if (true)
            {
                // This variable only exists inside this IF block
                string blockVar = "I am inside the IF block";
                Console.WriteLine(blockVar);   // works
                Console.WriteLine(localVar);   // works (can see outside)
            }

            // Console.WriteLine(blockVar);   // ❌ ERROR! blockVar doesn't exist here

            // Class-level variable (declared at the top of the class)
            Console.WriteLine(classLevelGreeting);   // works anywhere in the class

            // ================================================================
            //  PART 10: VALUE TYPES vs REFERENCE TYPES – "Copy vs Share"
            //  (Simple explanation for beginners)
            // ================================================================

            Console.WriteLine("\n===== PART 10: VALUE vs REFERENCE TYPES =====");

            // VALUE TYPES (int, double, bool, char, structs)
            // When you assign one to another, the value is COPIED.
            int a = 10;
            int b = a;      // b gets a COPY of 10 (a and b are separate)
            b = 20;         // change b, but a stays 10
            Console.WriteLine($"a = {a}, b = {b}");  // a=10, b=20

            // REFERENCE TYPES (string, arrays, classes, lists)
            // When you assign one to another, they SHARE the same data.
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;   // array2 points to the SAME array
            array2[0] = 99;          // changing array2 also changes array1!
            Console.WriteLine($"array1[0] = {array1[0]}, array2[0] = {array2[0]}"); // both 99!

            // But STRING is special – it behaves like a value type (immutable)
            // When you change a string, it creates a new one (doesn't change the original).
            string str1 = "Hello";
            string str2 = str1;
            str2 = "World";   // str1 is still "Hello"
            Console.WriteLine($"str1 = {str1}, str2 = {str2}");

            // ================================================================
            //  SUMMARY – "All you need to know about variables"
            // ================================================================

            // 1. A variable is a named box that holds data.
            // 2. Types: int, long, float, double, decimal, string, char, bool, DateTime.
            // 3. Name rules: start with letter/_, no keywords, case-sensitive.
            // 4. Use 'var' when type is obvious.
            // 5. 'const' for things that never change.
            // 6. Convert using (cast), Convert class, Parse, TryParse.
            // 7. 'null' means empty (only for reference types).
            // 8. 'int?' makes a value type nullable.
            // 9. Scope = where your variable lives (inside { }).
            // 10. Value types copy; reference types share (except string).

            // ================================================================

            Console.WriteLine("\n🎉 You now know everything about variables in C#!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
