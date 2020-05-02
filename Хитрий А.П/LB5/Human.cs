using System;
using static System.Console;
using System.Windows.Forms;

struct Genders
{
    public enum Gender
    {
        Man = 1, Woman, Other
    }
    public Gender gender;
    public string Sex;
}

struct Names
{
    public string Name;
    public string Surname;
} 

abstract class Human
{
    protected static int _number = 1_000_001;
    protected string[] _parent = new string[2];
    public Names _Name;
    public Genders _Gender;

    public Human()
    {
        ID = _number++ + 1;
        _Name.Name = "Name";
        _Name.Surname = "Surname";
        Age = 1;
        High = 1;
        Weight = 1;
        Nationality = "English";
        Birthdate = new DateTime(1900, 1, 1);
        _parent[0] = "";
        _parent[1] = "";
        Sex = "1";
    }

    public Human(string name, string surname, int age, int high, float weight, string nationality, DateTime birthdate, string parent0, string parent1, string sex)
    {
        ID = _number++ + 1;
        _Name.Name = name;
        _Name.Surname = surname;
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
    public int Age { get; set; }
    public int High { get; set; }
    public float Weight { get; set; }
    public string Nationality { get; set; }
    public DateTime Birthdate { get; set; }
    public string Sex 
    { 
        get=>_Gender.Sex;
        set
        {
            try
            {
                int a = int.Parse(value);
                if (a == 1)
                { _Gender.gender = (Genders.Gender)a; _Gender.Sex = "Мужской"; }
                else if (a == 2)
                { _Gender.gender = (Genders.Gender)a; _Gender.Sex = "Женский"; }
                else if (a == 3)
                { _Gender.gender = (Genders.Gender)a; WriteLine("Введите свой пол"); _Gender.Sex = ReadLine(); }
                else WriteLine("Неверный ввод");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                WriteLine("Введите: 1 - Мужской пол, 2 - Женский, 3 - Ввести другой пол");
                Sex = ReadLine();
            }
        }
    }
    public float IMT { get => Weight * 100 / High * 100 / High; }

    public void Cout()
    {
        WriteLine("Имя: {0}", _Name.Name);
        WriteLine("Фамилия: {0}", _Name.Surname);
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
