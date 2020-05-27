using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Sportsman : Human, ICloneable, IComparable
    {
        //Перечисление
        enum Categories
        {
            Basketballer,
            eSportsman,
            Footballer
        }

        //Поля
        protected string coach, category, country;

        //Конструкторы
        public Sportsman() : base() { }

        public Sportsman(string name, string surname, string gender) : base(name, surname, gender)
        {
            coach = category = null;
            country = "Belarus";
        }

        public Sportsman(string Name, string Surname, string Gender, uint Salary) : base(Name, Surname, Gender)
        {
            salary = Salary;
        }

        //Свойства
        public string Curator
        {
            get
            {
                return coach;
            }
            set
            {
                coach = value;
            }
        }
        
        public override string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (value == Categories.Basketballer.ToString())
                {
                    coach = "Michael Jordan";
                    category = Categories.Basketballer.ToString();
                }

                if (value == Categories.eSportsman.ToString())
                {
                    coach = "Mikhaylo 'Kane' Blagin";
                    category = Categories.eSportsman.ToString();
                }

                if (value == Categories.Footballer.ToString())
                {
                    coach = "Zinedine Zidane";
                    category = Categories.Footballer.ToString();
                }
                category = value;
            }
        }

        //Методы 
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"country - {country}");
            Console.WriteLine($"category - {category}");
            Console.WriteLine($"coach - {coach}");
        }

        public override void Die()
        {
            base.Die();
            country = "Better place";
        }

        public override void Resurrect()
        {
            base.Resurrect();
            country = "Belarus";
        }

        public new void Sing()
        {
            if (isDead || isIll)
                Console.WriteLine($"{fio.name} is not currently able for singing. Create another object.");
            else
                Console.WriteLine($"{fio.name} sings : ZOZH SILA, VODKA MOGILA! ");
            Console.ReadKey();
        }

        //Использование ICloneable
        public object Clone()
        {
            return new Sportsman(this.Name, this.Surname, this.gender, this.salary);
        }
        
        //Использование IComparable
        public int CompareTo(object o)
        {
            Sportsman p = o as Sportsman;
            if (p != null)
                return this.salary.CompareTo(p.salary);
            else
                throw new Exception("Unable to compare these two objects!");
        }

        //Деструктор
        ~Sportsman() { }
    }
}
