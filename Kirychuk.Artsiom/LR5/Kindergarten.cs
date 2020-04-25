using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{   
    //------------ Структура
    struct Time
    {
        public double atHome;
        public double inGarten;
    }
    //------------ Перечисление
    enum Mood
    {
        Great,
        Good,
        Normal,
        SoSo,
        Bad,
    }
    abstract class Kindergarten
    {
        //------------ Поля
        protected Time _timok = new Time();
        protected string _name;
        protected string _surname;
        protected int _age;
        protected Mood _spirits= 0;

        //------------ Конструктор
        public Kindergarten(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        //------------Свойства
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 100)
                    _age = value;
            }
        }

        public Mood Spirit
        {
            get { return _spirits; }
            set { _spirits = value; }
        }

        public double GetAtHome()
        { return _timok.atHome; }

        public void SetAtHome(double atHome)
        {
            _timok.atHome = atHome;
        }

        public double GetInGarten()
        { return _timok.inGarten; } 

        public void SerInGarten(double inGarten)
        {
            _timok.inGarten = inGarten;
        }

        //------------Методы
        public abstract void KnowHealth();
        public abstract void GetInfo();    
    }
}
