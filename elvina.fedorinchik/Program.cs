using System;

namespace laba_3_edit
{
    class Transport
    {
        protected static int ID = 0;
    }


    abstract class Car : Transport
    {
        public Car(int mark)
        {
            this.Mark = mark;
        }

        private int mark;
        public abstract void Ride();
        public string NameOfModel { get; protected set; }
        public string TypeOfEngine { get; protected set; }
        public int Price { get; protected set; }
        int _maxSpeed = 0;

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value < 0 || value > 453)
                {
                    Console.WriteLine("Wrong data.");
                    Environment.Exit(-1);
                }
                else
                {
                    _maxSpeed = value;
                }
            }
        }

        public int Mark { get { return mark; } protected set { mark = value; } }
    }


    class Tesla : Car
    {
        public Tesla(string nameofmodel, int maxspeed, int price, string typeofengine, int mark)
            : base(mark)
        {
            Console.WriteLine("Elon says hello to you");
            NameOfModel = nameofmodel;
            MaxSpeed = maxspeed;
            Price = price;
            if (typeofengine != "electrical")
                Console.WriteLine("Wrong type od engine. It will be seted to electrical.");
            TypeOfEngine = "electrical";
        }

        public override void Ride()
        {
            Console.WriteLine(". . .");
        }
    }


    class MercedezBenz : Car
    {
        public MercedezBenz(string nameofmodel, int maxspeed, int price, string typeofengine, int mark)
            : base(mark)
        {
            Console.WriteLine("Creative technilogy");
            NameOfModel = nameofmodel;
            MaxSpeed = maxspeed;
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
        public Bugatti(string nameofmodel, int maxspeed, int price, string typeofengine, int mark)
            : base(mark)
        {
            Console.WriteLine("One of the fastest cars in the world");
            NameOfModel = nameofmodel;
            MaxSpeed = maxspeed;
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
                    case 1:
                        Console.Write("Bugatti ");
                        break;
                    case 2:
                        Console.Write("Mercedez-Benz ");
                        break;
                    case 3:
                        Console.Write("Tesla ");
                        break;
                }

                Console.WriteLine($"{cars[i].NameOfModel}");
                Console.WriteLine($"Type of engine is {cars[i].TypeOfEngine}");
                Console.WriteLine($"Price: {cars[i].Price}");
                Console.WriteLine($"Max speed: {cars[i].MaxSpeed}\n");
            }
        }
    }


    class Program
    {
        public static void RideOnACar(Car car)
        {
            switch (car.Mark)
            {
                case 2:
                    ((MercedezBenz)car).Ride();
                    break;
                case 1:
                    ((Bugatti)car).Ride();
                    break;
                case 3:
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

                switch (choice)
                {
                    case 1:
                        collection[i] = new MercedezBenz(nameofmodel, maxSpeed, price, typeofengine, 2);
                        break;
                    case 2:
                        collection[i] = new Bugatti(nameofmodel, maxSpeed, price, typeofengine, 1);
                        break;
                    case 3:
                        collection[i] = new Tesla(nameofmodel, maxSpeed, price, typeofengine, 3);
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