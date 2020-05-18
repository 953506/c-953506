using System;
using System.Collections.Generic;
using System.Text;

enum Groups
{
    Nursery=2,
    Younger=3,
    Middle=4,
    Senior=5,
}
namespace laba6
{
    
    class Pedagogue : Kindergarten
    {
        private Groups _group;
        private int _salary;
        private string _education;

        //------------ Конструктор
        public Pedagogue(string name, string surname, int age, Groups group, int salary, string education)
            :base (name , surname, age)
        {
            _group = group;
            _salary = salary;
            _education = education;
        }

        //------------ Свойства
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary= value / 2;
            }
        }

        //------------ Методы
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}"); ;
            Console.WriteLine("Возраст:{0}", Age);
            Console.WriteLine("Группа детей :{0}", _group);
            Console.WriteLine("Зарплата(BYN):{0}", _salary);
            Console.WriteLine("Образование:{0}", _education);
        }
 
        public override void KnowHealth()
        {
            if ((_group == Groups.Senior || _group == Groups.Middle) && Age < 50)
                Console.WriteLine("Отлично!");
            if ((_group == Groups.Younger || _group == Groups.Nursery) && Age >= 50)
                Console.WriteLine("Великолепно. Как может быть иначе!");
        }

        public void Spirits (int premium)
        {
            double percent = (double) premium / (double)_salary * 100;
            if (percent < 5)
            {
                _spirits = Mood.Normal; ;
                Console.WriteLine("{0} рублей. На телефон положу! ", premium);
            }
            else if(percent >= 5 && percent <10)
            {
                _spirits = Mood.Good;
                Console.WriteLine("Делаю ремонт!");
            }
            else
            {
                _spirits = Mood.Great;
                Console.WriteLine("Заказываю билеты на Бали");
            }
        }
    }
}
