using System;

    class Car2 : Car, IMovable
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

        public Car2(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
        {
            name = Name;
            color = Color;
            comfortLevel = ComfortLevel;
            yearMade = YearMade;
            numberOfSeats = NumberOfSeats;
            trunkSize = TrunkSize;
            CurrentModel = NeededModel;
            CurrentType = NeededType;
        }

        public Model CurrentModel { get; }

        public CarType CurrentType { get; }

        public override void TestDrive()
        {
            Console.WriteLine("Test drive went well!\a\n");
        }

        public void ShowModels()
        {
            Console.WriteLine("The models of Mercedes are: ");
            for (Model toShow = Model.W123; toShow <= Model.Gelandewagen; toShow++)
            {
                Console.WriteLine(toShow);
            }
            Console.WriteLine();
        }
    }