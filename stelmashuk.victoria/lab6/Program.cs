using System;

namespace lab6
{
    interface IFoo
    {
        void GetInfo();
        void IMT(int weight, double height);
    }

    interface IComparer<T>
    {
        void Compare(T o1, T o2);
    }

    public struct Provero4ka
    {
        private int _age;
        private int _height;
        private int _weight;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    value = 0;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value <= 20 || value > 250)
                {
                    value = 0;
                }
                else
                {
                    _height = value;
                }
            }
        }

        public int Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0 || value > 250)
                {
                    value = 0;
                }
                else
                {
                    _weight = value;
                }
            }
        }
    }

    class PersonComparer : IComparer<Person>
    {
        public void Compare(Person o1, Person o2)
        {
            if (o1.provero4ka.Age > o2.provero4ka.Age)
            {
                Console.WriteLine($"{o1._name} старше, чем {o2._name}");
            }
            else
            {
                if (o2.provero4ka.Age > o1.provero4ka.Age)
                {
                    Console.WriteLine($"{o2._name} старше, чем {o1._name}");
                }
                else
                {
                    Console.WriteLine($"{o1._name} одногодки с {o2._name}");
                }
            }
        }

        public void Compare2(Person o1, Person o2)
        {
            if (o1.provero4ka.Height > o2.provero4ka.Height)
            {
                Console.WriteLine($"{o1._name} выше, чем {o2._name}");
            }
            else
            {
                if (o2.provero4ka.Height > o1.provero4ka.Height)
                {
                    Console.WriteLine($"{o2._name} выше, чем {o1._name}");
                }
                else
                {
                    Console.WriteLine($"{o1._name} одинакового роста с {o2._name}");
                }
            }
        }

        public void Compare3(Person o1, Person o2)
        {
            if (o1.provero4ka.Weight > o2.provero4ka.Weight)
            {
                Console.WriteLine($"у {o1._name} вес больше, чем {o2._name}");
            }
            else
            {
                if (o2.provero4ka.Weight > o1.provero4ka.Weight)
                {
                    Console.WriteLine($"у {o2._name} вес больше, чем {o1._name}");
                }
                else
                {
                    Console.WriteLine($"у {o1._name} одинаковый вес с {o2._name}");
                }
            }
        }
    }

    class Person : IFoo
    {
        public void IMT(int weight, double height)
        {
            double index;
            index = weight / ((height / 100) * (height / 100));
            if (index < 16)
            {
                Console.WriteLine("Ярко выраженный дефицит массы тела");
            }
            else if (index > 16 && index < 18.5)
            {
                Console.WriteLine("Дефицит массы тела");
            }
            else if (index > 18.5 && index < 25)
            {
                Console.WriteLine("Норма");
            }
            else if (index > 25 && index < 30)
            {
                Console.WriteLine("Предожирение");
            }
            else if (index > 30 && index < 35)
            {
                Console.WriteLine("Ожирение первой степени");
            }
            else if (index > 35 && index < 40)
            {
                Console.WriteLine("Ожирение второй степени");
            }
            else if (index > 40)
            {
                Console.WriteLine("Ожирение третьей степени");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {_name} \nВозраст: {provero4ka.Age} \nВес: {provero4ka.Weight} \nРост:{provero4ka.Height}");
        }

        public Provero4ka provero4ka;
        public string _name;

        public Person(string name, int age, int height, int weight)
        {
            _name = name;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, введите нужные данные о первом человеке: ");
            Console.WriteLine("Имя: ");
            string name1 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Возраст: ");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Рост: ");
            int height1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Вес: ");
            int weight1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Person person1 = new Person(name1, age1, height1, weight1);   
            Console.WriteLine("Введите нужные данные о втором человеке: ");
            Console.WriteLine("Имя: ");
            string name2 = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Возраст: ");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Рост: ");
            int height2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Вес: ");
            int weight2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Person person2 = new Person(name2, age2, height2, weight2);
            Console.WriteLine("Введите 1, если хотите просмотреть информацию о первом человеке; введите 2, есди хотите просмотреть информацию о втором человеке; введите 3, если хотите сравнить их параметры");
            int otvet2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (otvet2)
            {
                case 1:
                    {
                        person1.GetInfo();
                        person1.IMT(weight1, height1);
                        break;
                    }
                case 2:
                    {
                        person2.GetInfo();
                        person1.IMT(weight2, height2);
                        break;
                    }
                case 3:
                    {
                        PersonComparer personComparer = new PersonComparer();
                        Console.WriteLine("Сравнение параметров {0} c {1} :", name1, name2);
                        personComparer.Compare(person1, person2);
                        personComparer.Compare2(person1, person2);
                        personComparer.Compare3(person1, person2);
                        break;
                    }
            }
        }
    }
}
