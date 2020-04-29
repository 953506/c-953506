using System;

namespace Lab_5_Ind_1
{
    class Car : Transport
    {
        //fields
        protected uint price = 0;
        protected uint numberOfSeats;
        protected uint trunkSize;

        public enum CarType
        {
            Sedan,
            Universal,
            Hatchback,
            Pickup,
            Crossover,
            SUV
        }

        public struct Engine
        {
            private uint _volume;
            private uint _power;
            private uint _cylinders;
            private string _ecoClass;
            public Engine(uint volume, uint cylinders, uint power, string ecoClass)
            {
                _volume = volume;
                _cylinders = cylinders;
                _power = power;
                _ecoClass = ecoClass;
            }

            public uint Volume
            {
                get => _volume;
            }

            public uint Power
            {
                get => _power;
            }

            public uint Cylinders
            {
                get => _cylinders;
            }

            public string EcoClass
            {
                get => _ecoClass;
            }
        }

        //properties
        public uint Price
        {
            get => price;
            set => price = value;
        }

        public uint Seats
        {
            get => numberOfSeats;
            set => numberOfSeats = value;
        }

        public uint TrunkSize
        {
            get => trunkSize;
            set => trunkSize = value;
        }

        //constructors
        public Car()
        {
            price = 0;
            numberOfSeats = 0;
            trunkSize = 0;
        }

        //destructor
        ~Car(){Console.WriteLine("KEKW!");}

        //methods
        public virtual void Beep() {Console.WriteLine("BEEP!\a");}
       

        public void Calculate()
        {
            price = numberOfSeats * 2000 + trunkSize * 2;
            if (ComfortLevel == "high")
                price *= 3;
            else if (ComfortLevel == "medium")
                price *= 2;
        }
    }
}
