using System;
using System.Collections.Generic;
using System.Collections;

namespace LR8
{
    //интерфейсы
    interface IFoo
    {
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

    class PersonComparison : IComparison<Person>
    {
        public void AgeComparison(Person o1, Person o2)
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

        public void HeightComparison(Person o1, Person o2)
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

        public void WeightComparison(Person o1, Person o2)
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

    class Salary
    {
        public delegate void SalaryHandler(string message);
        public event SalaryHandler Notify;  // Определение события
        public int Balance1;
        public void Balance(int balance)
        {
            Balance1 = balance;
            Notify?.Invoke($"зарплата: {balance}");   // Вызов события 
        }
        public void Put(int balance)
        {
            Balance1 += balance;
            Notify?.Invoke($"добавено: {balance}");   // Вызов события 
        }
        public void Take(int balance)
        {
            Balance1 -= balance;
            Notify?.Invoke($"изъято: {balance}");   // Вызов события
        }
    }

    class Person : Salary, IFoo, IComparable
    {
        public string _name;
        public Provero4ka provero4ka;

        void IFoo.GetInfo()
        {
            Console.WriteLine($"{_name} \nВозраст: {provero4ka.Age} \nЗарплата: {Balance1} ");
        }

        public Person(string name, int age, int height, int weight, int balance)
        {
            _name = name;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
            Balance1 = balance;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Person otherPerson = obj as Person;
            if (otherPerson != null)
                return this.provero4ka.Age.CompareTo(otherPerson.provero4ka.Age);
            else
                throw new ArgumentException("Невозможно сравнить два объекта");//вызов исключения
        }
    }

    class Program
    {
        delegate void Welcome();//делегат
        delegate void MessageHandler(string message);
        private static void Show()
        {
            Console.WriteLine("Здравствуйте, директор!");
        }

        private static void AddSecond()
        {
            Console.WriteLine("До свидания, директор!");
        }

        static void Main(string[] args)
        {
            Welcome show = Show;
            show();
            int balance = 2000;
            int age = 0;
            string name = "";

            try
            {
                Console.Write("Введите ваше имя: ");
                name = Console.ReadLine();
                Console.Write("Введите ваш возраст: ");
                age = int.Parse(Console.ReadLine());
            }
            catch (FormatException)//обработка исключения
            {
                Console.WriteLine("\nОшибка: В поле \"возраст\" вы ввели не число");
            }

            Console.WriteLine("Ваши отличившиеся работники: ");
            Person person1 = new Person("Григорий", 37, 179, 67, balance);
            Person person2 = new Person("Алексей", 21, 175, 70, balance);
            Person person3 = new Person("Иоанна", 56, 165, 60, balance);
            Person person4 = new Person("Фиона", 24, 180, 58, balance);
            IFoo foo = person1;// переменная интерфейса
            foo.GetInfo();//получили доступ к элементам интерфейса
            IFoo foo2 = person2;
            foo2.GetInfo();
            IFoo foo3 = person3;
            foo3.GetInfo();
            IFoo foo4 = person4;
            foo4.GetInfo();
            Salary salary = new Salary();
            salary.Notify += delegate (string mes)// Установка в качестве обработчика анонимного метода
            {
                Console.WriteLine(mes);
            };
            MessageHandler handler = message => Console.WriteLine(message);//использование Лямбда-выражения
            handler("\t\t\t\t\t\tМеню");
            handler("\t\t\tВведите 1, если хотите просмотреть информацию о людях");
            handler("\t\t\tвведите 2, если хотите сравнить параметры мужчин");
            handler("\t\t\tвведите 3, если хотите сравнить параметры женщин");
            handler("\t\t\tвведите 4, если хотите повысить зарплату работника");
            handler("\t\t\tвведите 5, если хотите понизить зарплату работника");
            int otvet1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (otvet1)
            {
                case 1:
                    {
                        PersonComparison personComparison = new PersonComparison();
                        Console.WriteLine("Сравнение параметров мужчин: ");
                        personComparison.AgeComparison(person1, person2);
                        personComparison.HeightComparison(person1, person2);
                        personComparison.WeightComparison(person1, person2);
                        break;
                    }
                case 2:
                    {
                        PersonComparison personComparison = new PersonComparison();
                        Console.WriteLine("Сравнение параметров женщин: ");
                        personComparison.AgeComparison(person3, person4);
                        personComparison.HeightComparison(person3, person4);
                        personComparison.WeightComparison(person3, person4);
                        break;
                    }
                case 3:
                    {
                        Person[] people = new Person[] { person1, person2, person3, person4 };
                        Array.Sort(people);
                        foreach (Person p in people)
                        {
                            Console.WriteLine(p._name + "(" + p.provero4ka.Age + ")");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Выберите работника, заработную плату которого вы хотите повысить 1/2/3/4");
                        int otvet2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (otvet2)
                        {
                            case 1: 
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите повысить зарплату 1-го ратотника?");
                                    int put = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Put(put);
                                    Console.WriteLine($"Изменено, теперь у 1-го работника зарплата: {salary.Balance1}");
                                    break; 
                                }
                            case 2:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите повысить зарплату 2-го ратотника?");
                                    int put = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Put(put);
                                    Console.WriteLine($"Изменено, теперь у 2-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                            case 3:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите повысить зарплату 3-го ратотника?");
                                    int put = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Put(put);
                                    Console.WriteLine($"Изменено, теперь у 3-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                            case 4:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите повысить зарплату 4-го ратотника?");
                                    int put = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Put(put);
                                    Console.WriteLine($"Изменено, теперь у 4-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                        }
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Выберите работника, заработную плату которого вы хотите понизить");
                        int otvet2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (otvet2)
                        {
                            case 1:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите понизить зарплату 1-го ратотника?");
                                    int take = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Take(take);
                                    Console.WriteLine($"Изменено, теперь у 1-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                            case 2:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите понизить зарплату 2-го ратотника?");
                                    int take = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Take(take);
                                    Console.WriteLine($"Изменено, теперь у 2-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                            case 3:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите понизить зарплату 3-го ратотника?");
                                    int take = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Take(take);
                                    Console.WriteLine($"Изменено, теперь у 3-го работника зарплата: {salary.Balance1}");
                                    break;
                                }
                            case 4:
                                {
                                    salary.Balance(balance);
                                    Console.WriteLine($"На сколько вы хотите понизить зарплату 4-го ратотника?");
                                    int take = Convert.ToInt32(Console.ReadLine());// Добавляем обработчик для события Notify
                                    salary.Take(take);
                                    Console.WriteLine($"Изменено, теперь у 4-го работника зарплата: {salary.Balance1}");
                                    break; 
                                }
                        }
                        break;
                    }
                case 6:
                    {
                        break;
                    }
            }
            show -= Show;
            show += AddSecond;
            show();
        }
    }
}