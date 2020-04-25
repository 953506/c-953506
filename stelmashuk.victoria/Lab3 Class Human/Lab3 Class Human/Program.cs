using System;

namespace human
{
    class Person
    {
        //_Поля_
        private string _name, _surname;
        private int _height;
        private int _weight;
        private string _gender;
        private int _age;
        private static string _start = "Здравствуйте, введите параметры определенного человека.";

        //_Свойства_
        public int Age//свойство для проверки по возрасту
        {
            get { return _age; }
            set
            {
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(-1);
                }
                else
                {
                    _age = value;
                }
            }
        }

        //_Конструкторы_
        public Person(int age)
        {
            Age = age;
        }

        public Person(string name, string surname, int height, int weight, string gender, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _height = height;
            _weight = weight;
            _gender = gender;
        }

        //_Индексатор_
        public string this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "_name": return "Имя: " + _name;
                    case "_surname": return "Фамилия: " + _surname;
                    case "_gender": return "Пол:" + _gender;
                    default: return null;
                }
            }
            set
            {
                switch (choice)
                {
                    case "_name":
                        _name = value;
                        break;
                    case "_surname":
                        _surname = value;
                        break;
                    case "_gender":
                        _gender = value;
                        break;
                }
            }
        }

        //_Методы_ (перегрузка)
        public void GetInfo()
        {
            Console.WriteLine($"Возраст: {Age} ");
            Console.WriteLine($"Рост:{_height} ");
            Console.WriteLine($"Вес:{_weight} ");
        }

        public void GetInfo(int height, int weight, string gender, int age)//расчет нормы килокалорий
        {
            if (gender == "м")
            {
                double norma = 88.36 + 13.4 * weight + 4.8 * height - 5.7 * age;
                Console.WriteLine(norma);

            }
            else if (gender == "ж")
            {
                double norma = 447.6 + 9.2 * weight + 3.1 * height - 4.3 * age;
                Console.WriteLine(norma);
            }
        }

        public void GetInfo(int weight, string gender)//расчет нормы воды
        {
            if (gender == "м")
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == "ж")
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
        }

        public void GetInfo2(int age, string gender)//расчет нормы нижнего и верхнего давления
        {
            if (gender == "м")
            {
                if (age <= 20)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 123/76");
                }
                else if (age > 20 && age <= 30)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 126/79");
                }
                else if (age > 30 && age <= 40)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 129/81");
                }
                else if (age > 40 && age <= 50)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 135/83");
                }
                else if (age > 50 && age <= 70)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 142/85");
                }
                else if (age > 70)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 142/80");
                }
            }
            else if (gender == "ж")
            {
                if (age <= 20)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 116/72");
                }
                else if (age > 20 && age <= 30)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 120/75");
                }
                else if (age > 30 && age <= 40)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 127/80");
                }
                else if (age > 40 && age <= 50)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 137/84");
                }
                else if (age > 50 && age <= 70)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 144/85");
                }
                else if (age > 70)
                {
                    Console.WriteLine("Норма давления в мм.рт.ст.(усредненные клинические показатели): 159/80");
                }
            }
        }

        public void GetInfo3(double weight, double height)//расчет индекса массы тела и вывод информации о результате
        {
            double index;
            index = weight / (height * height / 100 * 100);
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

        static public string Start()
        {
            return _start;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string otvet;
            do
            {
                Console.WriteLine(Person.Start());
                Console.WriteLine("Введите возраст: ");
                string agestring;
                agestring = Console.ReadLine();
                int age;
                if (!Int32.TryParse(agestring, out age))
                {
                    Console.WriteLine("Ошибка!");
                }
                Person personage = new Person(age);
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите фамилию: ");
                string surname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите рост(см): ");
                string heightstring = Console.ReadLine();
                Console.Clear();
                int height;
                if (!Int32.TryParse(heightstring, out height))
                {
                    Console.WriteLine("Ошибка!");
                }
                Console.WriteLine("Введите вес(кг): ");
                string weightstring = Console.ReadLine();
                int weight;
                if (!Int32.TryParse(weightstring, out weight))
                {
                    Console.WriteLine("Ошибка!");
                }
                Console.Clear();
                Console.WriteLine("Введите пол - 'м' или 'ж': ");
                string gender = Console.ReadLine();
                Console.Clear();
                Person person = new Person(name, surname, height, weight, gender, age);
                Console.WriteLine("Вывод информации о данном человеке: ");
                Console.WriteLine(person["_name"]);
                Console.WriteLine(person["_surname"]);
                Console.WriteLine(person["_gender"]);
                Console.WriteLine("Суточная норма килокалорий по формуле Харриса-Бенедикта: ");
                person.GetInfo(height, weight, gender, age);
                Console.WriteLine("Суточная норма потребления воды (в мл): ");
                person.GetInfo(weight, gender);
                person.GetInfo2(age, gender);
                Console.WriteLine("Состояние тела человека по ИМТ: ");
                person.GetInfo3(weight, height);
                Console.WriteLine("Хотите ввести информацию о другом человеке?");
                otvet = Console.ReadLine();
                Console.Clear();
            } while (otvet == "да");
        }
    }
}
