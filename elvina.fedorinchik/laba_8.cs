using System;

namespace laba_8
{
    interface IComparer<T>
    {
        void Compare(T o1, T o2);
    }

    interface IRider
    {
        void Ride();
    }

    public struct TechnicalProperties     //проверочка технических свойств 
    {
        private int _maxSpeed;
        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value < 0 || value > 453)
                {
                    Console.WriteLine("Wrong data");
                    Environment.Exit(-1);
                }
                else
                {
                    _maxSpeed = value;
                }
            }
        }

        private float _enginCapacity;
        public float EngineCapacity        
        {
            get => _enginCapacity;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Wrong data");
                    Environment.Exit(-1);
                }
                _enginCapacity = value;
            }
        }

        public void ShowTechinicalProp(Marks mark)
        {
            if (mark != Marks.tesla)
            {
                Console.WriteLine($"Engine capacity: {EngineCapacity}");
                Console.WriteLine($"Max speed: {MaxSpeed}");
            }
        }
    }


    class CarComparer : IComparer<Car>
    {
        public void Compare(Car o1, Car o2)     //неявная реализация метода
        {
            if (o1.technicalProperties.MaxSpeed > o2.technicalProperties.MaxSpeed)
            {
                Console.WriteLine($"{o1.NameOfModel} is faster than {o2.NameOfModel}");
            }
            else
            {
                if (o2.technicalProperties.MaxSpeed > o1.technicalProperties.MaxSpeed)
                    Console.WriteLine($"{o2.NameOfModel} is faster than {o1.NameOfModel}");
                else
                {
                    Console.WriteLine($"{o1.NameOfModel}'s speed equals {o2.NameOfModel}");
                }
            }
        }
    }

    class Price
    {
        public delegate void Price(string message);   
        public event Price Notify;                       
        public int newprice;

        public void PriceList(int pricelist)
        {
            newprice = pricelist;
            Notify?.Invoke($"Your car costs {pricelist}");  
        }

        public void Sell(int pricelist)
        {
            newprice += pricelist;
            Notify?.Invoke($"Price increase by {pricelist}");        
        }

        public void Buy(int pricelist)
        {
            newprice -= pricelist;
            Notify?.Invoke($"Price reduction by {pricelist}");       
        }
    }


    abstract class Car : CarPrice, IRider
    {
        public Car(Marks mark)
        {
            this.Mark = mark;
        }

        public TechnicalProperties technicalProperties;
        private Marks _mark;
        public abstract void Ride();
        public string NameOfModel { get; protected set; }
        public string TypeOfEngine { get; protected set; }
        public int Price { get; protected set; }
        public Marks Mark
        {
            get
            {
                return _mark;
            }
            protected set
            {
                _mark = value;
            }
        }
    }


    class Tesla : Car
    {
        public Tesla(string nameofmodel, int maxspeed, int price, string typeofengine, Marks mark)
            : base(mark)
        {
            Console.WriteLine("Elon says hello to you");
            NameOfModel = nameofmodel;
            technicalProperties.MaxSpeed = maxspeed;
            Price = price;
            if (typeofengine != "electrical")
                Console.WriteLine("Wrong type of engine. It will be seted to electrical");
            TypeOfEngine = "electrical";
        }

        public override void Ride()
        {
            Console.WriteLine(". . .");
        }
    }


    class MercedezBenz : Car
    {
        public MercedezBenz(string nameofmodel, int maxspeed, int price, string typeofengine, float engineCapacity, Marks mark)
            : base(mark)
        {
            technicalProperties.EngineCapacity = engineCapacity;
            Console.WriteLine("Creative technilogy");
            NameOfModel = nameofmodel;
            technicalProperties.MaxSpeed = maxspeed;
            Price = price;
            TypeOfEngine = typeofengine;
        }
        public override void Ride()
        {
            Console.WriteLine("r r r");
        }
    }


    class Bugatti : Car
    {
        public Bugatti(string nameofmodel, int maxspeed, int price, string typeofengine, float engineCapacity, Marks mark)
            : base(mark)
        {
            technicalProperties.EngineCapacity = engineCapacity;
            Console.WriteLine("One of the fastest cars in the world");
            NameOfModel = nameofmodel;
            technicalProperties.MaxSpeed = maxspeed;
            Price = price;

            if (typeofengine != "combsution")
            {
                Console.WriteLine("Type of engine of Bugatti can be only combustion");
            }
            TypeOfEngine = "combsution";
        }
        public override void Ride()
        {
            Console.WriteLine("RRRRRRRRRRRRRRRRRRRRRRR");
        }
    }


    class Collection
    {
        Car[] cars;
        private int _quantity;
        public Collection(int count)
        {
            cars = new Car[count];
            Quantity = count;
        }
        public Car this[int index]
        {
            get
            {
                return cars[index];
            }
            set
            {
                cars[index] = value;
            }
        }

        public int Quantity { get => _quantity; private set => _quantity = value; }

        public void showInfo()
        {
            Console.WriteLine("\nGeneral info\n");
            for (int i = 0; i < Quantity; i++)
            {
                Console.WriteLine($"Car #{i + 1}");
                switch (cars[i].Mark)
                {
                    case Marks.bugatti:
                        Console.Write("Bugatti ");
                        break;
                    case Marks.mercedez:
                        Console.Write("Mercedez-Benz ");
                        break;
                    case Marks.tesla:
                        Console.Write("Tesla ");
                        break;
                }
                Console.WriteLine($"{cars[i].NameOfModel}");
                Console.WriteLine($"Type of engine is {cars[i].TypeOfEngine}");
                cars[i].technicalProperties.ShowTechinicalProp(cars[i].Mark);
                Console.WriteLine($"Price: {cars[i].Price}\n");
                Console.WriteLine("\nDo you want to change the price of a car? \n1. yes i want to raise; \n2. yes, i want to reduce;\n3. nope, thanks.");

                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        carprice.PriceList(pricelist);
                        Console.WriteLine($"How much do you want to increase the price of the car? ");
                        int increase = Convert.ToInt32(Console.ReadLine());
                        carprice.Increase(increase);
                        Console.WriteLine($": {carprice.newprice}");
                        break;
                    case "2":
                        carprice.PriceList(pricelist);
                        Console.WriteLine($"How much do you want to reduce the price of the car? ");
                        int reduce = Convert.ToInt32(Console.ReadLine());
                        carprice.Increase(reduce);
                        Console.WriteLine($": {carprice.newprice}");
                        break;
                    case "3";
                        break;
                    default:
                        Console.WriteLine("Please, enter 'yes' or 'no'.");
                        break;
                }
            }
        }
    }

    public enum Marks
    {
        mercedez,
        bugatti,
        tesla
    }

    class Program
    {
        delegate void Show();
        delegate void MenuHandler(string message);

        private static void Hi()
        {
            Console.WriteLine("Hi driver!");
        }

        private static void Bye()
        {
            Console.WriteLine("Bye driver!");
        }

        public static void RideOnACar(Car car)
        {
            IRider rider = car;
            rider.Ride();
        }

        static void Main(string[] args)
        {
            Show show = Hi;
            show();
            int age = 0;
            string name = "";
            try
            {
                Console.WriteLine("What is your name? ");
                name = Console.ReadLine();
                Console.WriteLine("How old are you? ");
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException)     
            {
                Console.WriteLine("\nWrong data. You did not enter a number in the \"age\" field.");
            }

            Console.WriteLine("Create a cars collection!");
            Console.WriteLine("\nHow much cars do you want to collect? Enter a number");
            int _quantity = Convert.ToInt32(Console.ReadLine());
            Collection collection = new Collection(_quantity);

            for (int i = 0; i < _quantity; i++)
            {
                Console.WriteLine($"\nChoose a mark of the car #{i + 1}");
                Console.WriteLine("\n1 - Mercedez\n2 - Bugatti\n3 - Tesla\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 3 || choice < 1)
                {
                    Console.WriteLine("Wrong data.");
                    Environment.Exit(-1);
                }

                Console.WriteLine("Enter the name of model:");
                string nameofmodel = Console.ReadLine();
                Console.WriteLine("Enter the max speed of your car:");
                int maxSpeed = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Enter the price of your car:");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the type of engine:");
                string typeofengine = Console.ReadLine();

                float engineCapacity = 0;
                if (choice != 3)
                {
                    Console.WriteLine("Enter the engine capacity:");
                    engineCapacity = (float)Convert.ToDouble(Console.ReadLine());
                }
                switch (choice)
                {
                    case 1:
                        collection[i] = new MercedezBenz(nameofmodel, maxSpeed, price, typeofengine, engineCapacity, Marks.mercedez);
                        break;
                    case 2:
                        collection[i] = new Bugatti(nameofmodel, maxSpeed, price, typeofengine, engineCapacity, Marks.bugatti);
                        break;
                    case 3:
                        collection[i] = new Tesla(nameofmodel, maxSpeed, price, typeofengine, Marks.tesla);
                        break;
                }
            }

            collection.showInfo();
            Console.WriteLine("Press any key . . . \n");
            Console.ReadKey();
            Console.WriteLine("Choose a car which you wanna ride (enter the number):");

            int c = Convert.ToInt32(Console.ReadLine());
            if (c < 1 || c > collection.Quantity)
            {
                Environment.Exit(-1);
            }
            else
            {
                RideOnACar(collection[c - 1]);
            }
            if (collection.Quantity >= 2)
            {
                Console.WriteLine("Enter 2 cars which you want to compare:");

                c = Convert.ToInt32(Console.ReadLine());
                int c1 = Convert.ToInt32(Console.ReadLine());
                if (c < 1 || c > collection.Quantity || c1 < 1 || c1 > collection.Quantity)
                {
                    Environment.Exit(-1);
                }
                else
                {
                    CarComparer carComparer = new CarComparer();
                    carComparer.Compare(collection[c - 1], collection[c1 - 1]);
                }
            }
            show -= Hi;
            show += Bye;
            show();
        }
    }
}