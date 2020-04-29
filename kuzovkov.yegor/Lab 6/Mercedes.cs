using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_Ind_1
{
    class Mercedes : Car
    {
        //fields
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

        //constructors
        public Mercedes(string Name, string Color, string ComfortLevel, uint YearMade, uint NumberOfSeats, uint TrunkSize, Model NeededModel, CarType NeededType)
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
            Console.WriteLine("Get low, get low, get looow!");
        }
    }
}
