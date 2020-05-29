using System;

    class Car1 : Car, IModels
    {
        //BMW
        public enum Model
        {
            Z8,
            I8,
            M5,
            M3,
            X5
        }

        private Model _currentModel;
        private CarType _currentType;
        private bool _available = true;

        public Car1(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
        {
            name = Name;
            color = Color;
            comfortLevel = ComfortLevel;
            yearMade = YearMade;
            numberOfSeats = NumberOfSeats;
            trunkSize = TrunkSize;
            _currentModel = NeededModel;
            _currentType = NeededType;
        }

        public Model CurrentModel
        {
            get => _currentModel;
        }

        public CarType CurrentType
        {
            get => _currentType;
        }

        public bool Available { get; set; }

        public override void TestDrive()
        {
            Console.WriteLine("Test drive went very well!\a\n");
        }

        public void ShowModels()
        {
            Console.WriteLine("The models of BMW are: ");
            for (Model toShow = Model.Z8; toShow <= Model.X5; toShow++)
            {
                Console.WriteLine(toShow);
            }
            Console.WriteLine();
        }

        public delegate void PurchaseHandler(string message);
        public event PurchaseHandler Notify;
        public void Purchase(int money)
        {
            if (money < price)
                Notify?.Invoke("Something went wrong...");
            else
                Console.WriteLine("Successful!");
        }
        ~Car1() { Console.WriteLine(""); }
    }