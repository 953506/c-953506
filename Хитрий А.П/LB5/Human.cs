using System;
using static System.Console;
using System.Windows.Forms;

abstract class Human
{
    protected static int _number = 1_000_001;
    protected string[] _parent = new string[2];

    public Human()
    {
        ID = _number++ + 1;
        Name = "Name";
        SurName = "Surname";
        Age = 1;
        High = 1;
        Weight = 1;
        Nationality = "English";
        Birthdate = new DateTime(1900, 1, 1);
        _parent[0] = "";
        _parent[1] = "";
        Sex = "";
    }

    public Human(string name, string surname, int age, int high, float weight, string nationality, DateTime birthdate, string parent0, string parent1, string sex)
    {
        ID = _number + 1;
        ++_number;
        Name = name;
        SurName = surname;
        Age = age;
        High = high;
        Weight = weight;
        Nationality = nationality;
        Birthdate = birthdate;
        _parent[0] = parent0;
        _parent[1] = parent1;
        Sex = sex;
    }

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

    public void Cout()
    {
        WriteLine("Имя: {0}",Name);
        WriteLine("Фамилия: {0}",SurName);
        WriteLine("Возраст: {0}",Age);
        WriteLine("Рост: {0}",High);
        WriteLine("Вес: {0}",Weight);
        WriteLine("Национальность: {0}",Nationality);
        WriteLine("День рождения: {0}",Birthdate.ToString("D"));
        WriteLine("Пол: {0}",Sex);
        WriteLine("Папа: {0}",_parent[0]);
        WriteLine("Мама: {0}",_parent[1]);
    }

    public int CalculateAge()
    {
            return DateTime.Now.Year - Birthdate.Year;
    }

    public abstract void ImportantDates();

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
            MessageBox.Show(e.Message);
            Clear();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            Clear();
        }
    }
    ~Human() { }
}
