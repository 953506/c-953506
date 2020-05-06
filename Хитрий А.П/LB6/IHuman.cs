using System;
using static System.Console;

    public interface IHuman
    {
        public static int _number = 1_000_001;

        public void HCout()
        {
            WriteLine("Имя: {0}", Name);
            WriteLine("Фамилия: {0}", SurName);
            WriteLine("Возраст: {0}", Age);
            WriteLine("Рост: {0}", High);
            WriteLine("Вес: {0}", Weight);
            WriteLine("Национальность: {0}", Nationality);
            WriteLine("День рождения: {0}", Birthdate.ToString("D"));
            WriteLine("Пол: {0}", Sex);
        }

        public string[] Parent { get; set; }
        public int ID { get; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int High { get; set; }
        public float Weight { get; set; }
        public string Nationality { get; set; }
        public DateTime Birthdate { get; set; }
        public string Sex { get; set; }
        public float IMT { get => Weight * 100 / High * 100 / High; }

        public void CalculateAge() => WriteLine("{0}",DateTime.Now.Year - Birthdate.Year);

        public void ImportantDates() { }

        public void Date()
        {
            try
            {
                Write("Введите день рождения(день)");
                int day = int.Parse(ReadLine());
                Write("Введите день рождения(месяц)");
                int month = int.Parse(ReadLine());
                Write("Введите день рождения(год)");
                int year = int.Parse(ReadLine());
                DateTime z = new DateTime(year, month, day);
                Birthdate = z;
            }
            catch (FormatException e)
            {
                WriteLine("{0}", e.Message);
                Clear();
            }
            catch (Exception e)
            {
                WriteLine("{0}", e.Message);
                Clear();
            }
        }
    }
