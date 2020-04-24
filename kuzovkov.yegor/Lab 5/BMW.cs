using System;

namespace Lab_5_Ind_1
{
    class BMW : Car
    {
        //fields
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

        //constructor
        public BMW(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
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

        //destructor
        ~BMW() {Console.WriteLine("LUL");}

        //properties
        public Model CurrentModel
        {
            get => _currentModel;
        }

        public CarType CurrentType
        {
            get => _currentType;
        }

        //methods
        public override void Beep()
        {
            Console.WriteLine("E-RON-DON-DON!!!\a\n");
        }
    }
}
