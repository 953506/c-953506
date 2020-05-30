using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Human
    {
        //полe
        protected string _name;
        protected string _surname;
        protected string _patronymic;
        protected int _age;
        protected int _weight;
        protected int _height;
        protected string _profession;
        protected int[] PIN = new int[4] { 0, 8, 0, 9 };
        protected static int count;

        //конструктор
        public Human()
        {
            _name = "Dima";
            _surname = "Vasilev";
            _patronymic = "Vadimovich";
            _age = 18;
            _weight = 81;
            _height = 191;
            count++;
        }

        public Human(string name, string surname, string patronymic)
        {
            this._name = name;
            this._surname = surname;
            this._patronymic = patronymic;
            count++;
        }
        public delegate void Named(string message);
        public event Named IsName;
        public Named ex1;

        public void Del()
        {
            if (this._age > 0)
            {
                ex1 = Output;
            }
            else
            {
                ex1 = OutputAge;
            }
        }
        //свойство(автосвойство)
        public string Information { private set; get; }

        public int Parameters { private set; get; }
        // свойство
        public virtual int IfAge
        {
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Age must be from 0 to 100 years");
                }

                else
                {
                    _age = value;
                }

            }

            get
            {
                return _age;
            }
        }
        //1
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                    _name = value;
            }
        }
        // индексатор
        public int this[int i]
        {
            get
            {
                return PIN[i];
            }
            set
            {
                PIN[i] = value;
            }
        }

        //метод
        public void ShowCount()
        {

            IsName?.Invoke($"Count of people: {count}");
        }
        public void Parameter(int age, int weight, int height)
        {
            this._age = age;
            this._weight = weight;
            this._height = weight;
        }
        public void Parameter()
        {
            _age = 60;
            _weight = 75;
            _height = 190;
        }

        public void Prof()
        {
            _profession = "Builder";
            for (int i = 0; i < 3; i++)
            {
                PIN[i] = i + 2;
            }
        }

        public string Prof(int age)
        {
            _profession = "Designer";
            return _profession;
        }
        public void Output(string name)
        {
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
        }
        public void OutputAge(string name)
        {
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}");
        }
        public void Cout()
        {
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.Write("PIN: ");
            Random rand = new Random();
        }
        public void Cout(int age, int weight, int height, string profession)
        {
            Console.WriteLine();
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{age}, Weidgt:{weight}, Height:{height}");
            Console.WriteLine($"Profession:{profession}");
            Console.Write("PIN: ");
        }
        //индексатор
        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "name":
                        return _name;
                    case "surname":
                        return _surname;
                    default: return null;
                }
            }
            set
            {
                switch (index)
                {
                    case "name":
                        _name = value;
                        break;
                    case "surname":
                        _surname = value;
                        break;
                }
            }
        }

    }
}
