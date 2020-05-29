using System;

    class Car : Transport, IComparable
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

        public Car()
        {
            price = 0;
            numberOfSeats = 0;
            trunkSize = 0;
        }
        public uint Price
        {
            get => price;
            set => price = value;
        }

        public virtual void TestDrive() { Console.WriteLine("Test drive went well!\a"); }

        public void Calculate()
        {
            price = numberOfSeats * 20 + trunkSize * 2;
            if (comfortLevel == "high")
                price *= 4;
            else if (comfortLevel == "medium")
                price *= 2;
        }

        public int CompareTo(object o)
        {
            Car c = o as Car;
            if (c != null)
                return this.Price.CompareTo(c.Price);
            else
                throw new Exception("Error. Unable to compare these objects.");
        }
        ~Car() { Console.WriteLine(""); }
    }