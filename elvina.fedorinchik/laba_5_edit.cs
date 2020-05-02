using System;

namespace laba_5
{
    abstract class Transport
    {
        protected static int ID = 0;
    }

    public struct TechnicalProperties
    {
        private int _maxSpeed;
        public int MaxSpeed
        {
            get 
            { 
                return _maxSpeed; 
            }
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
            }
            Console.WriteLine($"Max speed: {MaxSpeed}");
        }
    }


    abstract class Car : Transport
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
                Console.WriteLine("Wrong type od engine. It will be seted to electrical");
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
        public static void RideOnACar(Car car)
        {
            switch (car.Mark)
            {
                case Marks.mercedez:
                    ((MercedezBenz)car).Ride();
                    break;
                case Marks.bugatti:
                    ((Bugatti)car).Ride();
                    break;
                case Marks.tesla:
                    ((Tesla)car).Ride();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Create a cars collection");
            Console.WriteLine("How much cars do you want to collect? Enter a number");
            int _quantity = Convert.ToInt32(Console.ReadLine());
            Collection collection = new Collection(_quantity);

            for (int i = 0; i < _quantity; i++)
            {
                Console.WriteLine($"Choose a mark of the car #{i + 1}");
                Console.WriteLine("\n1 - Mercedez\n2 - Bugatti\n3 - Tesla\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 3 || choice < 1)
                {
                    Console.WriteLine("Wrong data");
                    Environment.Exit(-1);
                }

                Console.WriteLine("Enter the name of model");
                string nameofmodel = Console.ReadLine();
                Console.WriteLine("Enter the max speed of your car");
                int maxSpeed = Convert.ToInt32((Console.ReadLine()));
                Console.WriteLine("Enter the price of your car");
                int price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the type of engine");
                string typeofengine = Console.ReadLine();

                float engineCapacity = 0;
                if (choice != 3)
                {
                    Console.WriteLine("Enter the engine capacity");
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
            Console.WriteLine("Choose a car which you wanna ride (enter the number)");

            int c = Convert.ToInt32(Console.ReadLine());
            if (c < 1 || c > collection.Quantity)
            {
                Environment.Exit(-1);
            }
            else
            {
                RideOnACar(collection[c - 1]);
            }
            Console.ReadKey();
        }
    }
}