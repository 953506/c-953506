using System;

    class Car1 : Car
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

        public override void TestDrive()
        {
            Console.WriteLine("Test drive went well!\a\n");
        }
        ~Car1() { Console.WriteLine(""); }
    }