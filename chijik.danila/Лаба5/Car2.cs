using System;

    class Car2 : Car
    {
        //Mercedes
        public enum Model
        {
            W123,
            W201,
            W140,
            W210,
            Gelandewagen
        }

        private Model _currentModel;
        private CarType _currentType;

        public Car2(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
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
            Console.WriteLine("Test drive went very well!");
        }
    }
