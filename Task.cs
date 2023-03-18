using System;

namespace HelloWorld
{
    public class Car
    {
        // Attributes
        public string Make;
        public string Model;
        public int Year;
        public double Price;
        public bool IsElectric;
        public int MaxSpeed;
        public string Color;
        public int NumberOfDoors;

        // Constructors
        public Car(string make)
        {
            Make = make;
        }

        public Car(string make, string model, int year, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }

        public Car(string make, string model, int year, double price, bool isElectric, int maxSpeed, string color, int numberOfDoors)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            IsElectric = isElectric;
            MaxSpeed = maxSpeed;
            Color = color;
            NumberOfDoors = numberOfDoors;
        }

        public Car(string make, string model, int year) : this(make, model, year, 0)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model) : this(make, model, 0)
        {
            Make = make;
            Model = model;
        }

        // Methods
        public void Start()
        {
            Console.WriteLine("The car has started.");
        }

        public void Accelerate()
        {
            Console.WriteLine("The car is accelerating.");
        }

        public void Brake()
        {
            Console.WriteLine("The car is braking.");
        }

        public void Honk()
        {
            Console.WriteLine("The car is honking.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}, Electric: {IsElectric}, Max Speed: {MaxSpeed}, Color: {Color}, Number of Doors: {NumberOfDoors}");
        }

        public bool IsExpensive()
        {
            return Price > 50000;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car myCar = new Car("Honda", "Civic", 2022, 25000.0, false, 120, "Blue", 4);
            Console.WriteLine($"My car is a {myCar.Year} {myCar.Make} {myCar.Model}.");
            myCar.Start();
            myCar.Accelerate();
            myCar.Brake();
            myCar.Honk();
            myCar.DisplayInfo();
            bool isExpensive = myCar.IsExpensive();
            Console.WriteLine($"Is my car expensive? {isExpensive}");
        }
    }
}
