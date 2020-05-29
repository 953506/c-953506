using System;
using static System.Console;

    class Program
    {
        static void Main(string[] args)
        {
            Car1 myCar = new Car1("Auto", "Blue", "high", 2019, 4, 80, Car1.Model.M3, Car.CarType.Sedan);
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
            WriteLine("Additional functions\n\n");
            WriteLine("The program will show all models available:");
            myCar.ShowModels();
            friendsCar.ShowModels();

            IModels testCar = new Car1("Auto", "Green", "low", 2010, 4, 65, Car1.Model.X5, Car.CarType.SUV);
            testCar.Restore(testCar.Available);
            testCar.Buy(testCar.Available);
            WriteLine(testCar.Available);

            IMovable anotherCar = new Car2("Auto", "Silver", "medium", 2012, 4, 400, Car2.Model.W140, Car.CarType.Sedan);
            anotherCar.MaxSpeed = int.Parse(ReadLine());
            WriteLine("The time it takes the vehicle to get to destination point is: {0}", anotherCar.GetTime(250, anotherCar.MaxSpeed));
        }
    }
