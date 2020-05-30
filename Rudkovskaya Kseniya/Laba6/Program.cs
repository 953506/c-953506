using System;

namespace Laba6
{
    /* Интерфейсы */
    interface IBeg
    {
        static void Welcome()   //определение реализации по умолчанию
        {
            Console.WriteLine("Поступление");
        }

        void GetInfo();
    }

    interface IСomparison<T>
    {
        void AgeComparison(T o1, T o2);

        void MathComparison(T o1, T o2);

        void RusComparison(T o1, T o2);

        void PhysComparison(T o1, T o2);
    }

    public struct Data
    {
        private int _age;
        private int _levelMath;
        private int _levelRus;
        private int _levelPhys;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 50)
                {
                    Environment.Exit(0);
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Math
        {
            get { return _levelMath; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Environment.Exit(0);
                }
                else
                {
                    _levelMath = value;
                }
            }
        }

        public int Rus
        {
            get { return _levelRus; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Environment.Exit(0);
                }
                else
                {
                    _levelRus = value;
                }
            }
        }

        public int Phys
        {
            get { return _levelPhys; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Environment.Exit(0);
                }
                else
                {
                    _levelPhys = value;
                }
            }
        }
    }

    class EntranceComparison : IСomparison<Entrance>
    {
        public void AgeComparison(Entrance o1, Entrance o2)//неявная реализация метода
        {
            if (o1.data.Age > o2.data.Age)
            {
                Console.WriteLine($"{o1._name} старше, чем {o2._name}");
            }
            else
            {
                if (o2.data.Age > o1.data.Age)
                {
                    Console.WriteLine($"{o2._name} старше, чем {o1._name}");
                }
                else
                {
                    Console.WriteLine($"{o1._name} одногодки с {o2._name}");
                }
            }
        }

        public void MathComparison(Entrance o1, Entrance o2)//неявная реализация метода
        {
            if (o1.data.Math > o2.data.Math)
            {
                Console.WriteLine($"Балл по математике у {o1._name} выше, чем у {o2._name}");
            }
            else
            {
                if (o2.data.Math > o1.data.Math)
                {
                    Console.WriteLine($"Балл по математике у {o2._name} выше, чем у {o1._name}");
                }
                else
                {
                    Console.WriteLine($"Баллы по математике у {o1._name} и {o2._name} одинаковые");
                }
            }
        }

        public void RusComparison(Entrance o1, Entrance o2)//неявная реализация метода
        {
            if (o1.data.Rus > o2.data.Rus)
            {
                Console.WriteLine($"Балл по русскому у {o1._name} выше, чем у {o2._name}");
            }
            else
            {
                if (o2.data.Rus > o1.data.Rus)
                {
                    Console.WriteLine($"Балл по русскому у {o2._name} выше, чем у {o1._name}");
                }
                else
                {
                    Console.WriteLine($"Баллы по русскому у {o1._name} и {o2._name} одинаковые");
                }
            }
        }

        public void PhysComparison(Entrance o1, Entrance o2)//неявная реализация метода
        {
            if (o1.data.Phys > o2.data.Phys)
            {
                Console.WriteLine($"Баллы по физике у {o1._name} выше, чем у {o2._name}");
            }
            else
            {
                if (o2.data.Phys > o1.data.Phys)
                {
                    Console.WriteLine($"Баллы по физике у {o2._name} выше, чем у {o1._name}");
                }
                else
                {
                    Console.WriteLine($"Баллы по физике у {o1._name} и {o2._name} одинаковые");
                }
            }
        }
    }

    class Entrance : IBeg, IComparable
    {
        public Data data;
        public string _name;

        void IBeg.GetInfo()//явная реализация
        {
            Console.WriteLine($"Имя: {_name} \nВозраст: {data.Age} \nМатематика: {data.Math} \nРусский:{data.Rus} \nФизика:{data.Phys}\n");
        }

        public Entrance(string name, int age, int[] bally)
        {
            _name = name;
            data.Age = age;
            data.Math = bally[0];
            data.Rus = bally[1];
            data.Phys = bally[2];
        }

        public static int[] CT(int levelMath, int levelRus, int levelPhys)
        {

            Random x = new Random();
            int[] result = new int[3];
            Console.WriteLine("Вы сдаёте ЦТ по математике...");
            result[0] = x.Next(levelMath * 10 - 20, levelMath * 10 + 1);
            Console.WriteLine($"Ваш балл {result[0]}");
            Console.WriteLine("Вы сдаёте ЦТ по русскому...");
            result[1] = x.Next(levelRus * 10 - 20, levelRus * 10 + 1);
            Console.WriteLine($"Ваш балл {result[1]}");
            Console.WriteLine("Вы сдаёте ЦТ по физике...");
            result[2] = x.Next(levelPhys * 10 - 20, levelPhys * 10 + 1);
            Console.WriteLine($"Ваш балл {result[2]}");
            return result;
        }

        public int CompareTo(object obj)//IComparable реализация
        {
            if (obj == null) return 1;
            Entrance otherPerson = obj as Entrance;
            if (otherPerson != null)
                return this.data.Age.CompareTo(otherPerson.data.Age);
            else
                throw new ArgumentException("Невозможно сравнить два объекта");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IBeg.Welcome();
            Random x = new Random();
            int[] nothing = { 1, 1, 1 };
            Entrance chel1 = new Entrance("", 18, nothing);
            Entrance chel2 = new Entrance("", 18, nothing);

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Уровень подготовки к математике (от 1 до 10): ");
                int levelMath = Convert.ToInt32(Console.ReadLine());
                Console.Write("Уровень подготовки к русскому: ");
                int levelRus = Convert.ToInt32(Console.ReadLine());
                Console.Write("Уровень подготовки к физике: ");
                int levelPhys = Convert.ToInt32(Console.ReadLine());
                int[] bally = Entrance.CT(levelMath, levelRus, levelPhys);
                if (i == 0)
                {
                    chel1 = new Entrance(name, age, bally);        
                }
                else
                {
                    chel2 = new Entrance(name, age, bally);
                }
            }     
            do
            {
                Console.WriteLine("Выберите действие:\n1.Вывод информации о поступающих\n2.Сравнение возраста поступающих\n3.Сравнение баллов по математике\n4.Сравнение баллов по русскому\n5.Сравнение баллов по физике\n6.Выход");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (num)
                {
                    case 1:
                        {
                            IBeg beg1 = chel1;
                            IBeg beg2 = chel2;
                            beg1.GetInfo();
                            beg2.GetInfo();
                            break;
                        }
                    case 2:
                        {
                            EntranceComparison chelComp = new EntranceComparison();
                            chelComp.AgeComparison(chel1, chel2);
                            break;
                        }
                    case 3:
                        {
                            EntranceComparison chelComp = new EntranceComparison();
                            chelComp.MathComparison(chel1, chel2);
                            break;
                        }
                    case 4:
                        {
                            EntranceComparison chelComp = new EntranceComparison();
                            chelComp.RusComparison(chel1, chel2);
                            break;
                        }
                    case 5:
                        {
                            EntranceComparison chelComp = new EntranceComparison();
                            chelComp.RusComparison(chel1, chel2);
                            break;
                        }
                    case 6:
                        return;
                }
            } while (true);
        }
    }
}
