using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car:Transport, Informatoin
    {
        private int _TankVolume;
        public Car()
        {
            _characteristic = "Automobile";
            _NumberOfPassengers = 3;
            _category = "Passenger";
            _name = "Volga";
            _age = 56;
            _power = 1500;
        }
        public string Name { get; set; }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age enter is not correct");
                    Environment.Exit(0);
                }
            }
        }
        public int TankVolume
        {
            get
            {
                return _TankVolume;
            }
            set
            {
                if (value > 1 && value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("TankVolume enter is not correct");
                    Environment.Exit(0);
                }
            }
        }
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                if (value > 0 && value < 10000)
                {
                    _power = value;
                }
                else
                {
                    Console.WriteLine("Power enter is not correct");
                    Environment.Exit(0);
                }
            }
        }

        public void PowerFactor() 
        {
            double ras = 0;
            if(_TankVolume <= 50)
            {
                ras = 0.6;
            }
            if(_TankVolume > 50 && _TankVolume < 70)
            {
                ras = 1;
            }
            if (_TankVolume >= 70 && _TankVolume < 100)
            {
                ras = 1.1;
            }
            if (_TankVolume >= 100 && _TankVolume < 120)
            {
                ras = 1.2;
            }
            if (_TankVolume >= 120 && _TankVolume < 150)
            {
                ras = 1.4;
            }
            if (_TankVolume >= 150)
            {
                ras = 1.6;
            }
            Console.WriteLine($"The power factor of the motor is {ras}");
        }
        public void Cout()
        {
            Console.WriteLine($"Weight in tons = {_weight}; Category is {_category}; Characteristic is {_characteristic}");
            Console.WriteLine($"Number Of Passengers = {_NumberOfPassengers}");
            Console.WriteLine($"Name of the automobile = {_name}; Age of the automobile = {_age}");
            Console.WriteLine($"Power is = {_power}");
        }
    }
}
