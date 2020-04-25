using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Human
    {
        private string name = "";
        private string surname = "";
        private int age;
        private string status = "student";
        private int math, rus, phys;
        public double score = 0;

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public string Surname
        {
            get
            { return surname; }
            set
            { surname = value; }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value <= 16 || value >= 110)
                {
                    age = 17;
                }
                else
                    age = value;

            }
        }

        public string Status
        {
            get
            { return status; }
            set
            { status = value; }
        }

        public Human()
        {
            name = "";
        }

        public Human(string name)
        {
            this.name = name;
        }

        public int Math
        {
            set 
            {
                Console.WriteLine("Математика: ");
                Random x = new Random();
                math = x.Next(1, 11); 
            }
            get { return math; }
        }

        public int Rus
        {
            set
            {
                Console.WriteLine("Русский: ");
                Random x = new Random();
                rus = x.Next(1, 11);
            }
            get { return rus; }
        }

        public int Phys
        {
            set
            {
                Console.WriteLine("Физика: ");
                Random x = new Random();
                phys = x.Next(1, 11);
            }
            get { return phys; }
        }

        public double SetScore()
        {
            score = (math + rus + phys) / 3.0;
            Console.WriteLine($"\nОбщий средний балл: {score}");
            return score;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Имя:{name}\nФамилия:{surname}\nВозраст:{age} Статус:{status}\n");
            Console.WriteLine($"Средние баллы:\nМатем:{math}  Рус:{rus}  Физика:{phys}\nОбщий ср.балл:{score}\n");
        }

        public void AcscessСhange()
        {
            char predmet;
            int change = 0;
            Console.WriteLine($"Выберите предмет\nМатематика-1  Русский-2  Физика-3");
            predmet = Console.ReadKey().KeyChar;
            Console.WriteLine($"На сколько изменить отметку   пример(2 / -4)");
            int.TryParse(Console.ReadLine(), out change);
            if (predmet == '1')
            {
                if (math + change > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    math += change;
                }
            }
            if (predmet == '2')
            {
                if (rus + change > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    rus += change;
                }
            }
            if (predmet == '3')
            {
                if (phys + change > 10)
                {
                    Console.WriteLine($"Ошибка, повторите ввод снова");
                }
                else
                {
                    phys += change;
                }
            }
        }

        public void Expulsion()
        {
            status = "otchislen";
            math = 0;
            rus = 0;
            phys = 0;
            score = 0;
        }

    }


    class Gruppa : Human
    {
        Human[] items;

        public Gruppa(int kolv)
        {
            items = new Human[kolv + 1];
        }

        public Human this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }
    }
}
