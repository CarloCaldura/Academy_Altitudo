﻿using System.Numerics;
using System.Xml.Schema;
using Microsoft.VisualBasic;
using Vehicle;

namespace Vehicle

{   // Main Class
    public class Vehicle
    {
        // Fields (private vars)
        public string make;
        private string model;
        private int year;
        private int numberofwheels;
        private decimal fuelquantity;
        private decimal distance;


        // Constructor
        public Vehicle(string make, string model, int year, int numberofwheels, decimal fuelquantity, decimal distance)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.numberofwheels = numberofwheels;
            this.fuelquantity = fuelquantity;
            this.distance = distance;

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

        public decimal Fuelquantity
        { get { return fuelquantity; } set { fuelquantity = value; } }

        public decimal Distance
        { get { return distance; } set { distance = value; } }


        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
            Console.WriteLine($"Number of wheels: {numberofwheels}");
            Console.WriteLine($"Liters of fuel consumed: {fuelquantity}");
            Console.WriteLine($"Distance travelled: {distance}");
        }

        // Method to calculate gas consumption
        public virtual decimal Consumption() 
        {
            if (this.fuelquantity > 0 & this.distance > 0) 
            {
                return this.distance / this.fuelquantity;
            }
            return 0;
        }
    }

    // Inheritance
    public class Car : Vehicle
    {
        //Additional property
        public int NumDoors { get; set; }

        // Constructor
        public Car(string make, string model, int year, int numberofwheels, decimal fuelquantity, decimal distance,int numDoors)
            : base(make, model, year, numberofwheels, fuelquantity, distance)
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
    public class Motorcycle : Vehicle
    {
        // additional property
        public string Type { get; set; }

        // Constructor
        public Motorcycle(string make, string model, int year, int numberofwheels, decimal fuelquantity, decimal distance, string type)
            : base(make, model, year, numberofwheels, fuelquantity, distance)

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

    public class Program
    {
        static void Main()
        {

            Car myCar = new("Citroen", "Picasso", 2002, 4, 20, 225, 5);
            Motorcycle myMotorcycle = new("Suzuki", "Hayabusa", 2018, 2, 5, 80, "Sportbike");

            Console.WriteLine("Car Information:");
            myCar.DisplayInfo();
            decimal carConsumption = myCar.Consumption();
            Console.WriteLine($"The car {myCar.make} {myCar.Model} has a consumption rate of {carConsumption} km/L");

            Console.WriteLine("\nMotorcycle Information:");
            myMotorcycle.DisplayInfo();
            decimal motorcicleConsumption = myMotorcycle.Consumption();
            Console.WriteLine($"The motorcicle {myMotorcycle.make} {myMotorcycle.Model} has a consumption rate of {motorcicleConsumption} km/L");

            //Implementa input parametri con ReadLine
        }
    }
}