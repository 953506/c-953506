using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    abstract class Human
    {
        //Структура
        protected struct FIO
        {
            public string name, surname;
        }

        //Поля
        protected int _age;
        protected string _disease, _gender;
        protected bool _isIll, _isDead;
        protected FIO _fio;
        public static int birth_year;

        //Конструкторы
        public Human()
        {
            _age = 2020 - birth_year;
            _isIll = false;
            _isDead = false;
        }

        public Human(string name, string surname) : this()
        {
            _fio.name = name;
            _fio.surname = surname;
        }

        public Human(string name, string surname, string gender) : this(name, surname)
        {
            if (gender == "male" || gender == "female")
                _gender = gender;
        }

        //Свойства
        public abstract string Category { get; set; }

        public string Name
        {
            get
            {
                return _fio.name;
            }
            set
            {
                _fio.name = value;
            }
        }

        public int Age
        {
            get
            {
                return 2020 - birth_year;
            }
        }

        public string Surname
        {
            get
            {
                return _fio.surname;
            }
            set
            {
                _fio.surname = value;
            }
        }

        public bool isDead
        {
            get
            {
                return _isDead;
            }
        }

        public string Disease
        {
            get
            {
                if (_isIll) return _disease;
                return $"{_fio.name} is not ill";
            }
            set
            {
                _isIll = true;
                _disease = value;
            }
        }

        //Методы
        public virtual void Bounce() { } //для класса Footballer
        public virtual void Score() { } //для класса Basketballer
        public virtual void ChopWatermelon() { } //для класса eSportsman

        public virtual void ShowInfo()
        {
            Console.WriteLine($"name - {_fio.name}");
            Console.WriteLine($"surname - {_fio.surname}");
            Console.WriteLine($"gender - {_gender}");
            Console.WriteLine($"age - {_age}");
            Console.WriteLine($"disease - {Disease}");
            if (_isDead)
                Console.WriteLine($"DEAD status - dead (use Die to resurrect)");
            else
                Console.WriteLine($"DEAD status - alive");
        }

        public virtual void Die()
        {
            _isDead = true;
        }

        public virtual void Resurrect()
        {
            _isDead = false;
            _isIll = false;
        }

        public void ChangeGender()
        {
            _gender = (_gender == "male") ? "female" : "male";
        }

        public void Sing()
        {
            if (_isDead || _isIll)
                Console.WriteLine($"{_fio.name} is not currently able for singing. Create another object or resurrect.");
            else
                Console.WriteLine($"{_fio.name} sings : WHAT IS LOVE! BABY DONT HURT ME!");
            Console.ReadKey();
        }

        //Деструктор
        ~Human() { }
    }
}
