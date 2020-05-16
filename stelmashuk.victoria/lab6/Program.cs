using System;
using System.Collections.Generic;
using System.Collections;

namespace lab6
{
    //интерфейсы
    interface IFoo
    {
        static void Welcome() //определение реализации по умолчанию
        {
            Console.WriteLine("Здравствуйте!");
        }

        void GetInfo();
    }

    interface IComparison<T>
    {
        void AgeComparison(T o1, T o2);

        void HeightComparison(T o1, T o2);

        void WeightComparison(T o1, T o2);
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

    class PersonCompare : IComparison<Person>
    {
        public void AgeComparison(Person o1, Person o2)//неявная реализация метода
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

        public void HeightComparison(Person o1, Person o2)//неявная реализация метода
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

        public void WeightComparison(Person o1, Person o2)//неявная реализация метода
        {
            if (o1.provero4ka.Weight > o2.provero4ka.Weight)
            {
                Console.WriteLine($"у {o1._name} вес больше, чем у {o2._name}");
            }
            else
            {
                if (o2.provero4ka.Weight > o1.provero4ka.Weight)
                {
                    Console.WriteLine($"у {o2._name} вес больше, чем у {o1._name}");
                }
                else
                {
                    Console.WriteLine($"у {o1._name} одинаковый вес с {o2._name}");
                }
            }
        }
    }

    class Person : IFoo, IComparable
    {
        public string _name;
        public Provero4ka provero4ka;

        void IFoo.GetInfo()//явная реализация
        {
            Console.WriteLine($"Имя: {_name} \nВозраст: {provero4ka.Age} \nВес: {provero4ka.Weight} \nРост:{provero4ka.Height}");
        }

        public Person(string name, int age, int height, int weight)
        {
            _name = name;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }
        //реализация интерфейса IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Person otherPerson = obj as Person;
            if (otherPerson != null)
                return this.provero4ka.Age.CompareTo(otherPerson.provero4ka.Age);
            else
                throw new ArgumentException("Невозможно сравнить два объекта");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFoo.Welcome();
            Person person1 = new Person("григорий", 37, 179, 67);
            Person person2 = new Person("алексей", 21, 175, 70);
            Person person3 = new Person("иоанна", 56, 165, 60);
            Person person4 = new Person("фиона", 24, 180, 58);
            Console.WriteLine("Введите 1, если хотите просмотреть информацию о людях\n" + 
                "введите 2, если хотите сравнить параметры мужчин\n" + 
                "введите 3, если хотите сравнить параметры женщин\n" + 
                "введите 4, если хотите остсортировать данных людей по возросту");
            int otvet2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (otvet2)
            {
                case 1:
                    {
                        IFoo foo = person1;// переменная интерфейса
                        foo.GetInfo();//получили доступ к элементам интерфейса
                        IFoo foo2 = person2;
                        foo2.GetInfo();
                        IFoo foo3 = person3;
                        foo3.GetInfo();
                        IFoo foo4 = person4;
                        foo4.GetInfo();
                        break;
                    }
                case 2:
                    {
                        PersonCompare personComparer = new PersonCompare();
                        Console.WriteLine("Сравнение параметров мужчин: ");
                        personComparer.AgeComparison(person1, person2);
                        personComparer.HeightComparison(person1, person2);
                        personComparer.WeightComparison(person1, person2);
                        break;
                    }
                case 3:
                    {
                        PersonCompare personComparer = new PersonCompare();
                        Console.WriteLine("Сравнение параметров женщин: ");
                        personComparer.AgeComparison(person3, person4);
                        personComparer.HeightComparison(person3, person4);
                        personComparer.WeightComparison(person3, person4);
                        break;
                    }
                case 4:
                    {
                        Person[] people = new Person[] { person1, person2, person3, person4 };
                        Array.Sort(people);
                        foreach (Person p in people)
                        {
                            Console.WriteLine(p._name + "(" + p.provero4ka.Age + ")");
                        }
                        break;
                    }
            }
        }
    }
}
