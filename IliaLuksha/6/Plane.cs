using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Plane:Transport, Informatoin
    {
        private int _length;
        public string Name {get; set;}
        
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0 && value < 77)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Length enter is not correct");
                    Environment.Exit(0);
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value > 0 && value < 100)
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
        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                if (value > 0 && value < 25000)
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
        public void Cout()
        {
            Console.WriteLine($"Weight in tons = {_weight}; Category is {_category}; Characteristic is {_characteristic}");
            Console.WriteLine($"Number Of Passengers = {_NumberOfPassengers}");
            Console.WriteLine($"Name of the plane = {_name}; Age of the plane = {_age}");
            Console.WriteLine($"plane is = {_power}");
        }
    }
}
