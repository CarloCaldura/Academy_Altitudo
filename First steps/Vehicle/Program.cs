using System.Xml.Schema;
using Microsoft.VisualBasic;
using Vehicle;

namespace Vehicle

{
    class Vehicle
    {
        // Fields (private vars)
        public string make;
        private string model;
        private int year;
        private int numberofwheels;

        // Constructor
        public Vehicle(string make, string model, int year, int numberofwheels)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.numberofwheels = numberofwheels;
        }

        // Properties (getters and setters)
        public string Make
        { get { return make; } set { make = value; } }

        public string Model
        { get { return model; } set { model = value; } }

        public int Year
        { get { return year; } set { year = value; } }

        public int Numberofwheels
        { get { return numberofwheels; } set { numberofwheels = value; } }


        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Number of wheels: {numberofwheels}");
        }
    }

    // Inheritance
    class Car : Vehicle
    {
        //Additional property
        public int NumDoors { get; set; }

        // Constructor
        public Car(string make, string model, int year, int numberofwheels, int numDoors)
            : base(make, model, year, numberofwheels)
        {
            NumDoors = numDoors;
        }

        //Override the DisplayInfo Method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of doors: {NumDoors}");
        }
    }

    // Inheritance
    class Motorcycle : Vehicle
    {
        // additional property
        public string Type { get; set; }

        // Constructor
        public Motorcycle(string make, string model, int year, int numberofwheels, string type)
            : base(make, model, year, numberofwheels)

        {
            Type = type;
        }

        //Override the DispalyInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new("Citroen", "Picasso", 2002, 4, 5);
            Motorcycle myMotorcycle = new("Suzuki", "Hayabusa", 2018, 2, "Sportbike");

            Console.WriteLine("Car Information:");
            myCar.DisplayInfo();

            Console.WriteLine("\nMotorcycle Information:");
            myMotorcycle.DisplayInfo();

        }
    }
}

