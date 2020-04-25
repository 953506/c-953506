using System;
using System.Collections.Generic;
using System.Text;

namespace Laba3
{
    class Human
    {
        private string name;
        private string surname;
        private int age;
        private string status;
        public int math, rus, phys;
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
            get
            { return age; }
            set
            { age = value; }
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
            name = "Иван";
            surname = "Иванович";
            age = 18;
            status = "student";
            math = 2;
            rus = 2;
            phys = 2;
            score = 2;
        }
        public string GetName(string name)
        {
            this.name = name;
            return this.name;
        }

        public string GetSurname(string surname)
        {
            this.surname = surname;
            return this.surname;
        }

        public int GetAge(int age)
        {
            this.age = age;
            return this.age;
        }

        public int GetMath()
        {
            Console.WriteLine("Математика: ");
            int.TryParse(Console.ReadLine(), out math);
            return math;

        }

        public int GetRus()
        {
            Console.WriteLine("Русский: ");
            int.TryParse(Console.ReadLine(), out rus);
            return rus;
        }

        public int GetPhys()
        {
            Console.WriteLine("Физика: ");
            int.TryParse(Console.ReadLine(), out phys);
            return phys;
        }

        public double GetScore()
        {
            score = (math + rus + phys) / 3.0;
            Console.WriteLine($"\nОбщий средний балл: {score}");
            return score;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя:{name}\nФамилия:{surname}\nВозраст:{age} Статус:{status}\n");
            Console.WriteLine($"Средние баллы:\nМатем:{math}  Рус:{rus}  Физика:{phys}\nОбщий ср.балл:{score}\n");
        }

        public void GetСhange()
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

        public void GetExpulsion()
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
