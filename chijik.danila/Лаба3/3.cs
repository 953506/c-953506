using System;
using static System.Console;

namespace _3
{
    class Vehicle
    {
        public Vehicle() 
        { 
            Name = "Peugeot"; 
            Year = 2015; 
            Model = "308";
            Number = "MR-2389";
            Color = "Black"; 
        }
        public Vehicle(bool a)
        {
            Clear();
            Write("Car:");
            Name = ReadLine();
            Write("\nYear of release:");
            Year = Convert.ToInt32(ReadLine());
            Test();
            Write("\nNumber:");
            Number = ReadLine();
            Write("\nColor:");
            Color = ReadLine();
            Write("\nModel:");
            Model = ReadLine();
        }
        public string[] Texture { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public string Color { get; set; }
        public string FullName { get => Name +" "+ Model+" "+ Number; }
        public int Age { get => DateTime.Now.Year - Year; }
        public int Test()
        {

           if (Year < 1895 || Year > DateTime.Now.Year)
           {
               WriteLine("Incorrect data\nPlease try again\n");
               Write("\nYear of release:");
               Year = Convert.ToInt32(ReadLine());
               return Test();
           }
            return Year;
        }
        public static void ChooseMenu()
        {
            WriteLine("Choose the task:\n1.Enter car(s)\n2.Show all cars\n3.Test drive\n4.Exit");
        }
        public static void Choose(ref Vehicle[] a)
        {
            Array.Resize(ref a, a.Length + 1);
            Clear();
            WriteLine("Choose example or write your car");
            Write("1.Example\n2.Write my car\nNumber:");
            int choose = Convert.ToInt32(ReadLine());
            switch(choose)
            {
                case 1: a[a.Length - 1] = new Vehicle(); break;
                case 2: a[a.Length - 1] = new Vehicle(true); break;
                default: Error(); break;
            }
            Clear();
        }
        public static void ShowCars(Vehicle[] a)
        {
            Clear();
            for(int i = 0; i < a.Length; i++)
            {
                WriteLine("Car info: {0} , {1} years old\n", a[i].FullName,a[i].Age);
            }
            ReadKey();
            Clear();
        }
        public static void Error()
        {
            Clear();
            Write("Wrong input\n\nPress any button to continue...");
            Read();
            Clear();
        }
        public static void TestDrive(Vehicle[] a)
        {
            Clear();
            Write("Write number of car:");
            int choose = Convert.ToInt32(ReadLine());
            WriteLine("You choose {0} for test drive\n\n", a[choose-1].Name);
            WriteLine("Your drive went well");
            ReadKey();
            Clear();
        }
        public Vehicle[] Park;
        public Vehicle this[int index]
        {
            get
            {
                return Park[index];
            }
            set
            {
                Park[index] = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            Vehicle[] menu = new Vehicle[1];
            menu[0] = new Vehicle();
            do
            {
                Vehicle.ChooseMenu();
                Write("\nNumber of task:");
                int choose = Convert.ToInt32(ReadLine());
                switch (choose)
                {
                    case 1: Vehicle.Choose(ref menu); break;
                    case 2: Vehicle.ShowCars(menu); break;
                    case 3: Vehicle.TestDrive(menu); break;
                    case 4: Clear(); Write("Goodbye!"); exit = false; break;
                    default: Vehicle.Error(); break;
                }
            }
            while (exit == true);

            Read();

        }
    }
}
