using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    class Sportsman : Human
    {
        //Перечисление
        enum Categories
        {
            Basketballer,
            eSportsman,
            Footballer
        }

        //Поля
        protected string _coach, _category, _country;

        //Конструкторы
        public Sportsman() : base() { }

        public Sportsman(string name, string surname, string gender) : base(name, surname, gender)
        {
            _coach = _category = null;
            _country = "Belarus";
        }

        //Свойства
        public string Curator
        {
            get
            {
                return _coach;
            }
            set
            {
                _coach = value;
            }
        }

        public override string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (value == Categories.Basketballer.ToString())
                {
                    _coach = "Michael Jordan";
                    _category = Categories.Basketballer.ToString();
                }

                if (value == Categories.eSportsman.ToString())
                {
                    _coach = "Mikhaylo 'Kane' Blagin";
                    _category = Categories.eSportsman.ToString();
                }

                if (value == Categories.Footballer.ToString())
                {
                    _coach = "Zinedine Zidane";
                    _category = Categories.Footballer.ToString();
                }
                _category = value;
            }
        }

        //Методы 
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"country - {_country}");
            Console.WriteLine($"category - {_category}");
            Console.WriteLine($"coach - {_coach}");
        }

        public override void Die()
        {
            base.Die();
            _country = "Better place";
        }

        public override void Resurrect()
        {
            base.Resurrect();
            _country = "Belarus";
        }

        public new void Sing()
        {
            if (_isDead || _isIll)
                Console.WriteLine($"{_fio.name} is not currently able for singing. Create another object.");
            else
                Console.WriteLine($"{_fio.name} sings : ZOZH SILA, VODKA MOGILA! ");
            Console.ReadKey();
        }

        //Деструктор
        ~Sportsman() { }
    }
}
