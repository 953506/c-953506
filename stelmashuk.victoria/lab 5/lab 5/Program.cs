using System;

namespace lab5
{
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
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(0);
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
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(0);
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
                if (value <= 0 || value > 250)
                {
                    Console.WriteLine("Такого человека не существует");
                    Environment.Exit(0);
                }
                else
                {
                    _weight = value;
                }
            }
        }
    }

    class Person
    {
        public enum Gender
        {
            Male = 0,
            Female = 1,
        }

        public Provero4ka provero4ka;
        public string _name, _surname;

        public virtual void Сaloric(int height, int weight, Gender gender, int age)//полиморфный метод класса
        {
            if (gender == Gender.Male)
            {
                double norma = 88.36 + 13.4 * weight + 4.8 * height - 5.7 * age;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 447.6 + 9.2 * weight + 3.1 * height - 4.3 * age;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

        public virtual void Water(int weight, Gender gender)//полиморфный метод класса
        {
            if (gender == Gender.Male)
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

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
    }

    class Disabled : Person
    {
        public Disabled(string name, string surname, int age, int height, int weight)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }

        public override void Сaloric(int height, int weight, Gender gender, int age)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = 88.36 + 13.4 * weight + 4.8 * height - 5.7 * age;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 447.6 + 9.2 * weight + 3.1 * height - 4.3 * age;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

        public override void Water(int weight, Gender gender)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }
    }

    class Sedentary : Person
    {
        public Sedentary(string name, string surname, int age, int height, int weight)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }

        public override void Сaloric(int height, int weight, Gender gender, int age)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.2;
                Console.WriteLine(norma);

            }
            else if (gender == Gender.Female)
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.2;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

        public override void Water(int weight, Gender gender)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = 40 * weight;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 30 * weight;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }
    }

    class Healthy : Person
    {
        public Healthy(string name, string surname, int age, int height, int weight)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }

        public override void Сaloric(int height, int weight, Gender gender, int age)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.5;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.5;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

        public override void Water(int weight, Gender gender)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = 40 * weight + 400;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 30 * weight + 400;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }
    }

    class Sports : Person
    {
        public Sports(string name, string surname, int age, int height, int weight)
        {
            _name = name;
            _surname = surname;
            provero4ka.Age = age;
            provero4ka.Height = height;
            provero4ka.Weight = weight;
        }

        public override void Сaloric(int height, int weight, Gender gender, int age)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = (88.36 + 13.4 * weight + 4.8 * height - 5.7 * age) * 1.8;
                Console.WriteLine(norma);

            }
            else if (gender == Gender.Female)
            {
                double norma = (447.6 + 9.2 * weight + 3.1 * height - 4.3 * age) * 1.8;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }

        public override void Water(int weight, Gender gender)//переопределение виртуального метода базового класса Person
        {
            if (gender == Gender.Male)
            {
                double norma = 40 * weight + 800;
                Console.WriteLine(norma);
            }
            else if (gender == Gender.Female)
            {
                double norma = 30 * weight + 800;
                Console.WriteLine(norma);
            }
            else { Console.WriteLine("Вы неправильно ввели значение, поэтому не возможно правильно посчитать вашу норму."); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string otvet2;
            Console.WriteLine("Здравствуйте введите нужные данные о человеке: ");
            do
            {
                Person person = new Person();
                Person.Gender sex;
                Console.WriteLine("Имя: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Фамилия: ");
                string surname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Пол(введите 0, если мужской, а 1 если женский): ");
                string gender1 = Console.ReadLine();
                int gender;
                if (!Int32.TryParse(gender1, out gender))
                {
                    Console.WriteLine("Ошибка ввода");
                }
                sex = (Person.Gender)gender;
                Console.Clear();
                Console.WriteLine("Возраст: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Рост: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Вес: ");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("если вы человек с ограничеными возможностями - введите 1, если у вас сидячий образ жизни - 2, если вы ведете умеренный, здоровый образ жизни - 3, если вы спортсмен -4");
                int version = Convert.ToInt32((Console.ReadLine()));
                Console.Clear();
                switch (version)
                {
                    case 1:
                        {
                            person = new Disabled(name, surname, age, height, weight);
                            Console.WriteLine("Норма калорий: ");
                            person.Сaloric(height, weight, sex, age);
                            Console.WriteLine("Норма воды: ");
                            person.Water(weight, sex);
                            Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                            person.IMT(weight, height);
                            break;
                        }
                    case 2:
                        {
                            person = new Sedentary(name, surname, age, height, weight);
                            Console.WriteLine("Норма калорий: ");
                            person.Сaloric(height, weight, sex, age);
                            Console.WriteLine("Норма воды: ");
                            person.Water(weight, sex);
                            Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                            person.IMT(weight, height);
                            break;
                        }
                    case 3:
                        {
                            person = new Healthy(name, surname, age, height, weight);
                            Console.WriteLine("Норма калорий: ");
                            person.Сaloric(height, weight, sex, age);
                            Console.WriteLine("Норма воды: ");
                            person.Water(weight, sex);
                            Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                            person.IMT(weight, height);
                            break;
                        }
                    case 4:
                        {
                            person = new Sports(name, surname, age, height, weight);
                            Console.WriteLine("Ваша норма калорий: ");
                            person.Сaloric(height, weight, sex, age);
                            Console.WriteLine("Ваша норма воды: ");
                            person.Water(weight, sex);
                            Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                            person.IMT(weight, height);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ваша норма калорий без учета физической активности: ");
                            person.Сaloric(height, weight, sex, age);
                            Console.WriteLine("Ваша норма воды без учета физической активности: ");
                            person.Water(weight, sex);
                            Console.WriteLine("Показатель состояния вашего тела по ИМТ: ");
                            person.IMT(weight, height);
                            break;
                        }
                }
                Console.WriteLine("Хотите ввести данные другого человека? ");
                otvet2 = Console.ReadLine();
            } while (otvet2 == "да" || otvet2 == "Да" || otvet2 == "yes" || otvet2 == "Yes");
        }
    }
}
