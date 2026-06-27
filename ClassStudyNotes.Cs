using System;

namespace ClassStudyNotes
{
    // ================================================================
    //  PART 1: WHAT IS A CLASS? – "The Blueprint"
    //  Think of a class as a blueprint for a house.
    //  The blueprint says: "A house has 3 rooms, 2 doors, and a color."
    //  But the blueprint itself is NOT a house – it's just the plan.
    //  When you use the blueprint to build an actual house, that's an OBJECT.
    // 
    //  So: Class = Blueprint, Object = Actual thing built from that blueprint.
    // ================================================================

    // Let's create a simple class called "Car"
    // This is the blueprint for any car.
    class Car
    {
        // ----------------------------------------------------------------
        //  FIELDS – "The data the car holds"
        //  These are like variables that belong to the car.
        //  They represent the car's state or attributes.
        // ----------------------------------------------------------------

        // Field: brand (string)
        string brand;
        
        // Field: model (string)
        string model;
        
        // Field: year (int)
        int year;
        
        // Field: speed (int) – current speed in km/h
        int speed;

        // Field: isEngineOn (bool)
        bool isEngineOn;

        // ----------------------------------------------------------------
        //  PROPERTIES – "Controlled access to fields"
        //  Properties are like special methods that let you get or set a field's value.
        //  They allow you to add logic (like validation) when someone tries to read or change a value.
        //  They have 'get' (read) and 'set' (write) parts.
        // ----------------------------------------------------------------

        // Property for Brand – full property with get and set
        public string Brand
        {
            get { return brand; }          // get: return the value of brand
            set { brand = value; }         // set: assign value to brand
        }

        // Property for Model – full property
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Property for Year – with validation (can't be less than 1886, the first car)
        public int Year
        {
            get { return year; }
            set 
            {
                if (value >= 1886)
                    year = value;
                else
                    year = 1886; // default if invalid
            }
        }

        // Property for Speed – we only allow reading, but not setting directly.
        // We'll have a method to change speed.
        public int Speed
        {
            get { return speed; }
            private set { speed = value; } // private set means only this class can set it
        }

        // Auto-implemented property (shortcut) – C# creates a hidden field for you.
        // This is a property without a custom logic – just get and set.
        public string Color { get; set; }  // Short form, no manual field needed.

        // Read-only property (no set) – computed from other fields.
        public string FullDescription
        {
            get { return $"{Year} {Brand} {Model} in {Color}"; }
        }

        // ----------------------------------------------------------------
        //  CONSTRUCTORS – "How to build a car"
        //  A constructor is a special method that runs when you create a new object.
        //  It sets up the initial state of the object.
        //  It has the same name as the class and no return type (not even void).
        // ----------------------------------------------------------------

        // Default constructor (no parameters) – if you don't provide one, C# gives you one free.
        // But we'll define one that sets default values.
        public Car()
        {
            Brand = "Unknown";
            Model = "Unknown";
            Year = 2000;
            Color = "White";
            speed = 0;
            isEngineOn = false;
        }

        // Parameterized constructor – lets you set values when creating the car.
        public Car(string brand, string model, int year, string color)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            speed = 0;
            isEngineOn = false;
        }

        // Constructor that copies another car (like a clone)
        public Car(Car otherCar)
        {
            Brand = otherCar.Brand;
            Model = otherCar.Model;
            Year = otherCar.Year;
            Color = otherCar.Color;
            speed = 0;
            isEngineOn = false;
        }

        // ----------------------------------------------------------------
        //  METHODS – "Actions the car can do"
        //  Methods are functions that belong to the class.
        //  They define what the car can do: start, accelerate, brake, etc.
        // ----------------------------------------------------------------

        // Start the engine
        public void StartEngine()
        {
            if (!isEngineOn)
            {
                isEngineOn = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Engine already running.");
            }
        }

        // Stop the engine
        public void StopEngine()
        {
            if (isEngineOn)
            {
                isEngineOn = false;
                speed = 0; // stop the car when engine turns off
                Console.WriteLine("Engine stopped.");
            }
            else
            {
                Console.WriteLine("Engine already off.");
            }
        }

        // Accelerate – increase speed by a given amount
        public void Accelerate(int increment)
        {
            if (isEngineOn)
            {
                speed += increment;
                if (speed > 200) speed = 200; // max speed limit
                Console.WriteLine($"Accelerating. Current speed: {speed} km/h");
            }
            else
            {
                Console.WriteLine("Cannot accelerate – engine is off.");
            }
        }

        // Brake – decrease speed
        public void Brake(int decrement)
        {
            if (isEngineOn)
            {
                speed -= decrement;
                if (speed < 0) speed = 0;
                Console.WriteLine($"Braking. Current speed: {speed} km/h");
            }
            else
            {
                Console.WriteLine("Cannot brake – engine is off.");
            }
        }

        // Display the car's info
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {FullDescription}");
            Console.WriteLine($"Speed: {speed} km/h");
            Console.WriteLine($"Engine: {(isEngineOn ? "On" : "Off")}");
        }

        // ----------------------------------------------------------------
        //  ACCESS MODIFIERS – "Who can see what?"
        //  public   → anyone can access
        //  private  → only this class can access
        //  protected → this class and derived classes (we'll see later)
        //  internal → only within the same project
        // 
        //  We used:
        //  - Fields (brand, model, etc.) are private by default (since no modifier).
        //  - Properties (Brand, Model) are public to allow external access.
        //  - Methods (StartEngine, etc.) are public so we can call them from outside.
        // ================================================================

        // A private helper method – only used inside this class.
        private void Log(string message)
        {
            // This could write to a file, but we'll just print.
            Console.WriteLine($"[Car Log] {message}");
        }
    }

    // ================================================================
    //  PART 2: STATIC vs INSTANCE – "Shared vs Individual"
    //  Static members belong to the CLASS itself, not to any object.
    //  Instance members belong to each object separately.
    // ================================================================

    // Let's create a class that demonstrates static members.
    class MathHelper
    {
        // Instance field – each object has its own
        public string Name;

        // Static field – shared by all objects (and even without objects)
        public static double Pi = 3.14159;

        // Instance method – needs an object
        public void PrintName()
        {
            Console.WriteLine($"Name: {Name}");
        }

        // Static method – can be called without an object
        public static double CircleArea(double radius)
        {
            return Pi * radius * radius;
        }
    }

    // ================================================================
    //  PART 3: INHERITANCE – "Parent and Child"
    //  Inheritance lets you create a new class based on an existing one.
    //  The new class (child) inherits all public and protected members of the parent.
    //  It can add new members or override existing ones.
    // ================================================================

    // Base class (parent) – Vehicle
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        // Virtual method – can be overridden by child classes
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle is moving.");
        }

        public void Honk()
        {
            Console.WriteLine("Beep beep!");
        }
    }

    // Derived class (child) – Car inherits from Vehicle
    // Car gets all of Vehicle's public and protected stuff.
    // It adds its own things.
    class SportsCar : Vehicle   // : means "inherits from"
    {
        public int TopSpeed { get; set; }

        // Constructor must call base constructor
        public SportsCar(string make, string model, int topSpeed) : base(make, model)
        {
            TopSpeed = topSpeed;
        }

        // Override the Drive method to change behavior
        public override void Drive()
        {
            Console.WriteLine($"The sports car zooms at {TopSpeed} km/h!");
        }

        // New method specific to sports car
        public void ActivateTurbo()
        {
            Console.WriteLine("Turbo activated! Vroom!");
        }
    }

    // ================================================================
    //  MAIN PROGRAM – "Using the classes"
    // ================================================================

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== C# CLASSES DEMO =====\n");

            // --- 1. Creating objects using constructors ---
            Console.WriteLine("--- Creating Cars ---");

            // Using default constructor
            Car defaultCar = new Car();
            defaultCar.DisplayInfo();

            // Using parameterized constructor
            Car myCar = new Car("Toyota", "Corolla", 2020, "Red");
            myCar.DisplayInfo();

            // Using copy constructor
            Car clonedCar = new Car(myCar);
            clonedCar.Color = "Blue"; // change color
            clonedCar.DisplayInfo();

            // --- 2. Using methods and properties ---
            Console.WriteLine("\n--- Using Car Methods ---");
            myCar.StartEngine();
            myCar.Accelerate(30);
            myCar.Accelerate(50);
            myCar.Brake(20);
            myCar.StopEngine();

            // --- 3. Static vs Instance ---
            Console.WriteLine("\n--- Static vs Instance ---");
            MathHelper helper1 = new MathHelper();
            helper1.Name = "Calculator 1";
            helper1.PrintName();

            MathHelper helper2 = new MathHelper();
            helper2.Name = "Calculator 2";
            helper2.PrintName();

            // Static members are accessed via class name, not object.
            Console.WriteLine($"Pi = {MathHelper.Pi}");
            double area = MathHelper.CircleArea(5);
            Console.WriteLine($"Area of circle with radius 5 = {area:F2}");

            // --- 4. Inheritance ---
            Console.WriteLine("\n--- Inheritance ---");
            Vehicle myVehicle = new Vehicle("Generic", "Vehicle");
            myVehicle.Drive();      // uses base class method
            myVehicle.Honk();

            SportsCar mySportsCar = new SportsCar("Ferrari", "F8", 340);
            mySportsCar.Drive();    // uses overridden method
            mySportsCar.Honk();     // inherited from Vehicle
            mySportsCar.ActivateTurbo();

            // You can treat a derived object as its base type.
            Vehicle vehicleReference = mySportsCar; // valid
            vehicleReference.Drive(); // still calls the overridden version (polymorphism)

            // --- 5. Access Modifiers Recap ---
            Console.WriteLine("\n--- Access Modifiers Recap ---");
            // Public: accessible anywhere.
            // Private: only inside the class (fields like brand, model are private).
            // But we can access them via public properties (Brand, Model).
            Console.WriteLine($"My car brand: {myCar.Brand}"); // works because Brand is public
            // myCar.brand; // ERROR: brand is private

            // --- 6. Encapsulation – the concept of hiding internal details ---
            Console.WriteLine("\n--- Encapsulation ---");
            // The car hides its internal state (speed, engine state) and exposes
            // methods to interact with it. This is good practice.

            // --- 7. Summary ---
            Console.WriteLine("\n===== SUMMARY =====");
            Console.WriteLine("1. Class = blueprint for objects.");
            Console.WriteLine("2. Fields = data (private by default).");
            Console.WriteLine("3. Properties = controlled access to fields (get/set).");
            Console.WriteLine("4. Constructors = build objects.");
            Console.WriteLine("5. Methods = actions.");
            Console.WriteLine("6. Public = accessible everywhere, Private = only inside class.");
            Console.WriteLine("7. Static = belongs to class, Instance = belongs to object.");
            Console.WriteLine("8. Inheritance = child class inherits from parent.");
            Console.WriteLine("9. Override = change behavior of a method.");
            Console.WriteLine("10. Encapsulation = hiding internals, exposing only what's needed.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
