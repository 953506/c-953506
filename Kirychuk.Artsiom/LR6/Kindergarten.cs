using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
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
    class Kindergarten : IKindergarten
    {
        //------------ Поля
        protected Time _timok;
        protected Mood _spirits = 0;

        //-----------Индексатор
        public double this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "в саду":
                        {
                            return _timok.inGarten;
                        }
                    case "дома":
                        {
                            return _timok.atHome;
                        }
                    default: return -1;
                }
            }
            set
            {
                switch (choice)
                {
                    case "в саду":
                        {
                            _timok.inGarten = value;
                            break;
                        }
                    case "дома":
                        {
                            _timok.atHome = value;
                            break;
                        }
                }
            }
        }

        //------------ Конструктор
        public Kindergarten(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        //------------Свойста
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        //------------Методы
        public virtual void KnowHealth()
        {
            string help = Console.ReadLine();
            if (help == "COVID-19")
                Console.WriteLine("АПЩХИИИИ. ОЙ, Чихннула)");
            else Console.WriteLine("Всё хорошо");
        }
        public virtual void GetInfo()
        {
            Console.WriteLine("ЗАГРУЗКА...");
        }

        public  void Info()
        {
            Console.WriteLine("Хотиславский ясли-сад" +
                "\nОснован в 1980 году" +
                "\nЗдание учреждения  расчитано на 4 группы" +
                "\nПроектная мощность - 90 мест" +
                "\nШтат- 16 сотрудников");
        }
    }
}
