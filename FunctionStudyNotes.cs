using System;

namespace FunctionStudyNotes
{
    class Program
    {
        // ================================================================
        //  INTRO: What is a function (or method)?
        //  A function is like a little machine that does a specific job.
        //  You give it some ingredients (parameters) and it gives you a result (return).
        //  Or it just does something (like printing) and gives nothing back (void).
        // 
        //  Functions help you:
        //   - Avoid repeating code (write once, use many times)
        //   - Organize your program (break big problems into small pieces)
        //   - Make your code easier to read and fix
        // ================================================================

        // We'll write functions inside the class Program.

        // ================================================================
        //  PART 1: BASIC FUNCTION SYNTAX
        // 
        //  returnType FunctionName(parameter1Type parameter1Name, parameter2Type parameter2Name, ...)
        //  {
        //      // code to do the job
        //      return someValue;   // if returnType is not void
        //  }
        // 
        //  - returnType: what kind of data the function gives back (int, string, bool, etc.)
        //                Use 'void' if it gives nothing back.
        //  - FunctionName: a name that describes what it does (e.g., Add, PrintMessage)
        //  - parameters: inputs you pass to the function (optional)
        //  - body: the code that runs when you call the function
        //  - return: sends a value back to the caller (only if not void)
        // ================================================================

        // ----- Example 1: A function that adds two numbers -----
        // It takes two ints, adds them, and returns the sum (int).
        static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;   // send back the result
        }

        // ----- Example 2: A function that just prints a message (returns nothing) -----
        static void PrintGreeting()
        {
            Console.WriteLine("Hello, welcome to the function world!");
            // no 'return' needed because it's void
        }

        // ----- Example 3: A function that takes a name and returns a greeting -----
        static string GetGreeting(string name)
        {
            return "Hello, " + name + "!";
        }

        // ----- Example 4: A function with multiple parameters -----
        static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        // ================================================================
        //  PART 2: CALLING FUNCTIONS – "Using your machines"
        //  You call a function by writing its name and passing arguments.
        //  If it returns something, you can use that value or store it in a variable.
        // ================================================================

        static void Main(string[] args)
        {
            Console.WriteLine("===== PART 2: CALLING FUNCTIONS =====");

            // Call PrintGreeting (it's void, so just do its work)
            PrintGreeting();

            // Call Add and store the result
            int result = Add(5, 3);
            Console.WriteLine($"5 + 3 = {result}");

            // Call GetGreeting and print directly
            Console.WriteLine(GetGreeting("Alice"));

            // Call CalculateRectangleArea
            double area = CalculateRectangleArea(4.5, 3.2);
            Console.WriteLine($"Rectangle area: {area}");

            // You can also call a function inside another expression
            int anotherResult = Add(10, Add(2, 3));  // first inner Add = 5, then outer Add = 15
            Console.WriteLine($"10 + (2+3) = {anotherResult}");

            // ================================================================
            //  PART 3: RETURN TYPES – "What does the machine give back?"
            //  - int, double, string, bool, etc. → must return that type
            //  - void → returns nothing (no return statement needed, but can use return; to exit early)
            // ================================================================

            Console.WriteLine("\n===== PART 3: RETURN TYPES =====");

            // Functions with different return types
            Console.WriteLine($"Is 5 even? {IsEven(5)}");   // bool
            Console.WriteLine($"Square of 7: {Square(7)}"); // int
            Console.WriteLine($"Full name: {GetFullName("John", "Doe")}"); // string
            Console.WriteLine($"Area of circle with radius 3: {CircleArea(3)}"); // double

            // A void function can use 'return;' to exit early (not return a value)
            PrintIfPositive(10);
            PrintIfPositive(-5);

            // ================================================================
            //  PART 4: PARAMETERS – "Inputs to your machine"
            //  You can have zero or more parameters.
            //  Each parameter has a type and a name.
            //  When you call the function, you pass arguments that match.
            // ================================================================

            Console.WriteLine("\n===== PART 4: PARAMETERS =====");

            // Function with zero parameters
            SayHello();

            // Function with one parameter
            DisplayNumber(42);

            // Function with multiple parameters (already used Add, etc.)

            // Function with different types
            PrintPersonDetails("Bob", 25, 5.9);
        }

        // ----- Helper functions used in Main -----

        // Returns true if number is even, false otherwise
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Returns the square of a number
        static int Square(int x)
        {
            return x * x;
        }

        // Returns a full name by combining first and last
        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }

        // Returns area of a circle given radius
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        // Void function that prints a number only if it's positive
        static void PrintIfPositive(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine($"Number {num} is not positive, skipping.");
                return;   // exit the function early
            }
            Console.WriteLine($"Positive number: {num}");
        }

        // Function with no parameters
        static void SayHello()
        {
            Console.WriteLine("Hello there!");
        }

        // Function with one parameter
        static void DisplayNumber(int num)
        {
            Console.WriteLine($"The number is: {num}");
        }

        // Function with multiple parameter types
        static void PrintPersonDetails(string name, int age, double height)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height:F2} meters");
        }

        // ================================================================
        //  PART 5: METHOD OVERLOADING – "Same name, different inputs"
        //  You can have multiple functions with the SAME name,
        //  as long as they have different parameters (number or types).
        //  The compiler decides which one to call based on the arguments you pass.
        // ================================================================

        Console.WriteLine("\n===== PART 5: METHOD OVERLOADING =====");

        // We'll define three overloaded 'Multiply' functions above Main.
        // Let's test them here (but we need to define them outside Main).
        // I'll show calls here, but you'll see them below in the code.
    }

    // ----- Overloaded Multiply functions (defined inside the class, outside Main) -----
    static int Multiply(int a, int b)
    {
        Console.WriteLine("Multiply(int, int) called");
        return a * b;
    }

    static double Multiply(double a, double b)
    {
        Console.WriteLine("Multiply(double, double) called");
        return a * b;
    }

    static int Multiply(int a, int b, int c)
    {
        Console.WriteLine("Multiply(int, int, int) called");
        return a * b * c;
    }

    // Now back in Main (but we can't have multiple Main methods; I'll add code after the class)
    // Actually, the Main method is already defined. I'll continue in the same Main.
    // To keep the code clean, I'll write a separate demo for overloading inside Main, but we need to call these functions from Main.
    // Let's do it all inside Main (which is already open). I'll add after the previous Main content.
    // Since I wrote the Main method earlier, I'll continue it.

    // Actually, the code is getting messy with this explanation style. Let me rewrite the Main method to include all demos after all functions are declared.
    // I'll restructure: define all functions first, then in Main call them.
    // I'll provide the full code with all parts in order.
}

// To keep it clear, I'll rewrite the entire program with a clean structure.
