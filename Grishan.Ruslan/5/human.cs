using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    abstract class Human
    {
        protected int _age, _height, _weight;
        protected string _name, _surname, _patronymic;
        public static int birthyear = 0;
        protected bool _sick_cov = false, _army = true;
        //конструктор
        public Human()
        {
            if (birthyear != 0)
                _age = 2020 - birthyear;
            else _age = 18;
            Weight = 70;
            Height = 181;
        }
        public Human(string name, string surname, string patronymic) : this()
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
        }
        //свойства
        public string Surname

        {
            get
            {
                return _name;
            }
            set

            {
                _surname = value;
            }
        }
        public int Weight

        {
            get 
            {
                return _weight;
            }
            set
            {
                if (value >= 5 && value <= 600)
                    _weight = value;
                else 
                    Console.WriteLine("Write real weight");
            }
        }
        public int Height

        {
            get 
            {
                return _height;
            }
            set
            {
                if (value >= 5 && value <= 260)
                    _height = value;
                else
                    Console.WriteLine("Write real height");
            }
        }
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
        public string Patronymic

        {
            get
            {
                return _patronymic;
            }
            set

            {
                _patronymic = value;
            }
        }

        public virtual int Age

        {
            get 
            {
                return _age;
            
            }
            set

            {
                if (value >= 0 && value <= 120)
                    _age = value;
                else
                    Console.WriteLine("Write normal age");
            }

        }
        //индексаторы
        public string this[string index]

        {

            get
            {
                switch (index)

                {
                    case "name": return _name;
                    case "surname": return _surname;
                    case "patronymic": return _patronymic;
                    default: return null;
                }

            }

            set

            {
                switch (index)

                {
                    case "name": _name = value; break;
                    case "surname": _surname = value; break;
                    case "patronymic": _patronymic = value; break;
                }
            }
        }
        //методы
        public void Showinf()
        {
            Console.WriteLine($"FIO:{_surname} {_name } {_patronymic}");
            Console.WriteLine($"age - {_age}");
            Console.WriteLine($"height - {_height}");
            Console.WriteLine($"weight - {_weight}");
            Console.WriteLine($"sick Covid-19 - {_sick_cov}");
            if (_army == true)
            {
                Console.WriteLine("You are fit");
            }

        }
        public static void Menu()
        {
            Console.WriteLine("1)Show information");
            Console.WriteLine("2)Change age");
            Console.WriteLine("3)Change name");
            Console.WriteLine("4)Change surname");
            Console.WriteLine("5)Change patronymic");
            Console.WriteLine("6)Change sick status");
            Console.WriteLine("7)Write height");
            Console.WriteLine("8)Write weight");
            Console.WriteLine("9)Army status");
            Console.WriteLine("0)Show FIO");
            Console.WriteLine("Press - to end");
        }
        public void Army()
        {
            if (_age > 17 && _age < 28 && _weight > 35 && _weight < 100 && _height > 160 && _height < 190 && _sick_cov == false)
            {
                _army = true;
                Console.WriteLine("You are fit");
                Console.ReadKey();
            }
        }
        public void Change_sick()
        {
            _sick_cov = (_sick_cov == false) ? true : false;
        }
    }
}
