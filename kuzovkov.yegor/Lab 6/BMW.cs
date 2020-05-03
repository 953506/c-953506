using System;
using Lab_5_Ind_1;

namespace Lab_6_Ind_1
{
    class BMW : Car, IMovable, IModels
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
        private bool _available = true;

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
        ~BMW() { Console.WriteLine("LUL"); }

        //properties
        public Model CurrentModel
        {
            get => _currentModel;
        }

        public CarType CurrentType
        {
            get => _currentType;
        }

        public bool Available { get; set; }

        //methods
        public override void Beep()
        {
            Console.WriteLine("E-RON-DON-DON!!!\a\n");
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
    }
}