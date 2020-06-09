using System;
using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            Car1 myCar = new Car1("Auto", "Black", "high", 2019, 4, 80, Car1.Model.M3, Car.CarType.Sedan);
            myCar.Calculate();

            WriteLine("The info about the vehicle:");
            WriteLine($"1. Type: {myCar.Name}.\n2. Color: {myCar.Color}\n3. Year of production: {myCar.YearMade}");
            WriteLine($"4. Model: {myCar.CurrentModel}\n5. Car Type: {myCar.CurrentType}\n6. Comfort level: {myCar.ComfortLevel}]n\n");
            WriteLine($"The price is {myCar.Price}\n\n");

            Car2 friendsCar = new Car2("Auto", "Silver", "medium", 2012, 4, 400, Car2.Model.W140, Car.CarType.Sedan);
            friendsCar.Calculate();

            WriteLine("The info about your friend's vehicle:");
            WriteLine($"1. Type: {friendsCar.Name}.\n2. Color: {friendsCar.Color}\n3. Year of production: {friendsCar.YearMade}");
            WriteLine($"4. Model: {friendsCar.CurrentModel}\n5. Car Type: {friendsCar.CurrentType}\n6. Comfort level: {friendsCar.ComfortLevel}\n\n");
            WriteLine($"The price is {friendsCar.Price}\n\n");
            
            Car yourCar1 = new Car1("Auto", "Black", "high", 2019, 4, 80, Car1.Model.M3, Car.CarType.Sedan);
            yourCar1.TestDrive();
            Car yourCar2 = new Car2("Auto", "Black", "high", 2019, 4, 80, Car1.Model.M3, Car.CarType.Sedan);
            yourCar2.TestDrive();
        }
    }
