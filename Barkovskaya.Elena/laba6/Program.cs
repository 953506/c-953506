using System;
using System.Collections;
using System.Collections.Generic;

namespace laba6
{
    public interface ICarInfo
    {
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int FuelConsumption { get; set; }
    }


    abstract class Car
    {
        private int _age;
        private string _color, _mark, _model;
        public static int productionYear;   

        public Car(string mark, string model, string color)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = model;
            _color = color;
        }

        public Car(string mark)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = "uknown";
            _color = "uknown";
        }

        public Car(string mark, string model)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = model;
            _color = "uknown";
        }

        public string Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Age
        {
            get
            {
                return 2020 - productionYear;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public string this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "mark": return _mark;
                    case "model": return _model;
                    case "color": return _color;
                    default: return null;
                }
            }
            set
            {
                switch (choice)
                {
                    case "mark": _mark = value; break;
                    case "model": _model = value; break;
                    case "color": _color = value; break;
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"mark - {_mark}");
            Console.WriteLine($"model - {_model}");
            Console.WriteLine($"color - {_color}");
            Console.WriteLine($"age - {_age}");
        }
        public virtual void AddBasicData() { }
        public virtual void ShowBasicData() { }
        public virtual void Job() { }

        ~Car() { }
    }


    class MarkCar : Car
    {
        enum Manufactured_countres
        {
            Germany,
            Japan,
            Russia,
            China,
            USA,
            UK,
            France,
            Italy,
            Belarus
        }

        private struct BasicData
        {
            public int weight, tank_volume, acceleration_time;
            public string engine_type, drive_unit;
        }

        private BasicData basicData;
        Manufactured_countres Country;
        private string _chassisType;
        public MarkCar(string mark, string model, string color, string chassisType, int country_choice) : base(mark, model, color)
        {
            if (chassisType == "wheeled" || chassisType == "tracked" || chassisType == "mixed" || chassisType == "magnetic cushion")
                _chassisType = chassisType;
            else _chassisType = "unknown";
            if (country_choice > 8) country_choice = 8;
            Country = (Manufactured_countres)country_choice;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"mark - {Mark}");
            Console.WriteLine($"model - {Model}");
            Console.WriteLine($"color - {Color}");
            Console.WriteLine($"manufacturer country - {Country}");
            Console.WriteLine($"chassis type - {_chassisType}");
            Console.WriteLine($"age - {Age}");
        }

        public override void AddBasicData()
        {
            Console.WriteLine("drive unit:");
            basicData.drive_unit = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("engine type:");
            basicData.engine_type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("weight:");
            int.TryParse(Console.ReadLine(), out basicData.weight);
            Console.Clear();
            Console.WriteLine("tank volume:");
            int.TryParse(Console.ReadLine(), out basicData.tank_volume);
            Console.Clear();
            Console.WriteLine("acceleration time:");
            int.TryParse(Console.ReadLine(), out basicData.acceleration_time);
            Console.Clear();
        }

        public override void ShowBasicData()
        {
            Console.WriteLine($"drive unit: {basicData.drive_unit}");
            Console.WriteLine($"engine_type: {basicData.engine_type}");
            Console.WriteLine($"weight: {basicData.weight}");
            Console.WriteLine($"tank volume: {basicData.tank_volume}");
            Console.WriteLine($"acceleration time: {basicData.acceleration_time}");
        }
    }


    class PassengerCar : MarkCar
    {
        string choice;
        public PassengerCar(string mark, string model, string color, string chassisType, int countryChoice) : base(mark, model, color, chassisType, countryChoice) { }
        public override void Job()
        {
            Console.WriteLine("You can work in a taxi!\nDo you want to open your own business(enter 1) or work in an existing company(enter 2)?\n(enter something else if you don't want to work in a taxi)");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Do you have money to open your own business, or are you ready to take a loan for this (1,045.9 BYN initially and then about 500 a month)?\ny/n");
                choice = Console.ReadLine();
                if (choice == "y") { Console.WriteLine("According to statistics, this business is not very profitable now, so there will be some losses. But if this is the dream of your life, then forward to success!"); }
                else Console.WriteLine("it’s unfortunate that nothing will work out :(");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter the number of hours you can work per week");
                choice = Console.ReadLine();
                Console.WriteLine($"your average earnings per month can be about {Convert.ToInt32(choice) * 15} BYN");
            }
        }

    }


    class Autotruck : MarkCar
    {
        string choice;
        public Autotruck(string mark, string model, string color, string chassisType, int countryChoice) : base(mark, model, color, chassisType, countryChoice) { }
        public override void Job()
        {
            Console.WriteLine("Are you ready to be away for a long time(enter 1) or do you have a family and people you love(enter 2)?\nEnter something else if you don't want to work in freight");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("If you have CE category rights (if not, you can unlearn it), then you can work as a trucker. How many weeks per month are you willing to work?");
                choice = Console.ReadLine();
                Console.WriteLine($"Then your salary may be about {Convert.ToInt32(choice) * 840} BYN per month");
            }
            if (choice == "2")
            {
                Console.WriteLine("You can create your own business and taking into account all the expenses every month, you can earn about 1400 BYN (working 5 days a week). Good luck!");
            }
        }
    }


    class Bus : MarkCar, ICarInfo
    {
        
        string choice;

        public int MaxSpeed { get; set ; }
        public int MinSpeed { get; set; }
        public int FuelConsumption { get; set; }

        public Bus(string mark, string model, string color, string chassis_type, int country_choice, int max, int min ,int fuel) : base(mark, model, color, chassis_type, country_choice)
        {
            MaxSpeed = max;
            MinSpeed = min;
            FuelConsumption = fuel;
        }
        public override void Job()
        {
            Console.WriteLine("Depending on the type of your bus, you can deal with either passenger transportation within the city (enter 1) or international transportation(enter 2).");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Just transporting passengers on a particular route(enter 1) or a city tour(enter 2)?");
                choice = Console.ReadLine();
                if (choice == "1")
                    Console.WriteLine("Your salary at work on the Minsk transport with a shift schedule will be from 1000 BYN");
                if (choice == "2")
                    Console.WriteLine("You can open your own business and then the earnings will be around 1500 BYN per month (if you have an interesting excursion). If you get a job in an existing company, then your income will be about 700 BYN");
            }
            if (choice == "2")
            {
                Console.WriteLine("You can get a company (having your own bus will be a big plus)(enter 1) or open your own individual company(enter 2).");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Enter the number of days you can work per week");
                    choice = Console.ReadLine();
                    Console.WriteLine($"Your salary will be about {Convert.ToInt32(choice) * 320} BYN per month");
                }
                if (choice == "2")
                    Console.WriteLine("It is very difficult, but international transportation is well paid, taking into account all the costs you can earn about 2000 - 3000 BYN per month");
            }
        }
    }


    class BusComparer : IComparer<Bus>
    {
        public int Compare(Bus a, Bus b)
        {
            if (a.FuelConsumption > b.FuelConsumption)
                return 1;
            else if (a.FuelConsumption < b.FuelConsumption)
                return -1;
            else return 0;
        }
    }


    class Program
    {
        static void Main()
        {
            bool flag = true;
            string choice;
            string model, color, chassisType, mark;
            int productionYear = 0, countryChoice;

            Console.WriteLine("Enter mark, model and color your car");
            mark = Console.ReadLine();
            model = Console.ReadLine();
            color = Console.ReadLine();
            Console.WriteLine("Select country of origin\nGermany - 0\nJapan - 1\nRussia - 2\nChina - 3\nUSA - 4\nUK - 5\nFrance - 6\nItaly - 7\nBelarus - 8");
            int.TryParse(Console.ReadLine(), out countryChoice);
            Console.Clear();

            Console.WriteLine("Enter chassis_type (wheeled/tracked/mixed/magnetic cushion)");
            chassisType = Console.ReadLine();
            Console.Clear();
            Car car;
            do
            {
                Console.WriteLine("Enter production year");
                int.TryParse(Console.ReadLine(), out productionYear);
                if (productionYear <= 2020)
                    flag = false;
                else Console.WriteLine("Incorrect input. Now we in 2020 year");
            } while (flag);
            Console.Clear();

            Car.productionYear = productionYear;
            car = new MarkCar(mark, model, color, chassisType, countryChoice);

            do
            {
                Console.WriteLine("1 - Show info\n2 - You can add basic data\n3 - Change mark\n4 - Change model" +
                    "\n5 - Change color\n6 - You can show basic data\n7 - Show mark and model\n8 - I want to work!\n9 - Test Interface ICarInfo and IComparer");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        car.ShowInfo();
                        Console.ReadKey();
                        break;
                    case "2":
                        car.AddBasicData();
                        break;
                    case "3":
                        Console.Write("mark - ");
                        car["mark"] = Console.ReadLine();
                        break;
                    case "4":
                        Console.Write("model - ");
                        car["model"] = Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("color - ");
                        car["color"] = Console.ReadLine();
                        break;
                    case "6":
                        car.ShowBasicData();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        Console.Write("Your car is " + car["mark"] + " " + car["model"]);
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Choose your car type\n1 - Passenger car\n2 - Autotruck\n3 - Bus");
                        choice = Console.ReadLine();
                        if (choice == "1")
                            car = new PassengerCar(mark, model, color, chassisType, countryChoice);
                        else if (choice == "2")
                            car = new Autotruck(mark, model, color, chassisType, countryChoice);
                        else if (choice == "3")
                            car = new Bus(mark, model, color, chassisType, countryChoice,90,0,15);
                        else { Console.WriteLine("You do not want to work!"); break; }
                        Console.Clear();
                        car.Job();
                        Console.ReadKey();
                        break;
                    case "9":
                        Console.WriteLine("Test Interface ICarInfo and IComparer Begin");
                        var Bus1 = new Bus("Mercedes","A100","Blue","Wheel",1,90,10,15);
                        var Bus2 = new Bus("MAZ", "103", "Green", "Wheel", 8, 95, 5, 18);
                        var Bus3 = new Bus("Radzimich", "92", "Yellow", "Wheel", 8, 100, 0, 9);
                        var Bus4 = new Bus("Neman", "88", "White", "Wheel", 8, 95, 0, 7);
                        Bus[] buses = new Bus[] { Bus1, Bus2, Bus3, Bus4 };
                        Array.Sort(buses, new BusComparer());
                        foreach (Bus bus in buses)
                        {
                            bus.ShowInfo();
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (true);
        }
    }
}
