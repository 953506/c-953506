using System;

    class Car : Transport
    {
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

        public uint Price
        {
            get => price;
            set => price = value;
        }

        public Car()
        {
            price = 0;
            numberOfSeats = 0;
            trunkSize = 0;
        }

        public virtual void TestDrive() { Console.WriteLine("Test drive went well!\a"); }

        public void Calculate()
        {
            price = numberOfSeats * 20 + trunkSize * 2;
            if (ComfortLevel == "high")
                price *= 4;
            else if (ComfortLevel == "medium")
                price *= 2;
        }
        ~Car() { Console.WriteLine(""); }
    }