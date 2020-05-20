using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Transport: IComparable<Transport>
    {
        protected string _name;
        protected int _weight;
        protected string _category;
        protected string _characteristic;
        protected int _NumberOfPassengers;
        protected int _age;
        protected int _power;

        public Transport()
        {
             _weight = 2;
             _category = "Passenger";
             _characteristic = "Automobile";
            _NumberOfPassengers = 3;
        }
        public Transport(int weight):this()
        {
            _weight = weight;
            _category = "Passenger";
            _characteristic = "Automobile";
            _NumberOfPassengers = 3;
        }
        public Transport(int weight, string category) : this(weight)
        {
            _weight = weight;
            _category = category;
            _characteristic = "Automobile";
            _NumberOfPassengers = 3;
        }
        public Transport(string category) : this()
        {
            _weight = 2;
            _category = category;
            _characteristic = "Automobile";
            _NumberOfPassengers = 3;
        }
        public int CompareTo(Transport obj)
        {  
            if(this._weight > obj._weight)
                return 1;
            if (this._weight < obj._weight)
                return -1;
            else
                return 0;
        }
        public int Weight { private set; get; }
        string Name { get; set; }

        public string Characteristic
        {
            get
            {
                return _characteristic;
            }
            set
            {
                switch (value)
                {
                    case "Water":
                    case "Automobile":
                    case "Railway":
                    case "Air":
                        break;
                    default:
                        {
                            Console.WriteLine("Characteristic enter is not correct");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                switch (value)
                {
                    case "Freight":
                    case "Passenger":
                        break;
                    default:
                        {
                            Console.WriteLine("Type enter is not correct");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "Category": return _category;
                    case "characteristic": return _characteristic;
                    default:
                        {
                            Console.WriteLine("Index enter id not correct");
                            Environment.Exit(0);
                            return null;
                        }
                }
            }
            set
            {
                switch (index)
                {
                    case "Category": _category = value; break;
                    case "characteristic": _characteristic = value; break; ;
                    default:
                        {
                            Console.WriteLine("Index enter id not correct");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        public int NumberOfPassengers
        {
            get
            {
                return _NumberOfPassengers;
            }
            set
            {
                if (_category == "Freight")
                {
                    _NumberOfPassengers = 0;
                }
                else
                {
                    _NumberOfPassengers = value; 
                }
            }
        }
    }
}
