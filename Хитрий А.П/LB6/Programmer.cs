using System;
using static System.Console;

class Programmer : IProgrammer
{
    public static int _number;
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

    public string[] Award { get; set; }
    public string[] Penalty { get; set; }
    public string[] Languages { get; set; }
    public uint Salary { get; set; }
    public uint EmploymentHistory { get; set; }
    public uint ManagerialExperience { get; set; }
    public uint OtherAllowances { get; set; }
    public uint DaysOfSick { get; set; }
    public uint DaysOfVacation { get; set; }

    public string[] ProgramLanguage { get; set; }
    public string Education { get; set; }
    public string Specialization { get; set; }
    public string Job { get; set; }
    public Programmer()
    {
        ID = _number++ + 1;
        Name = "Name";
        SurName = "Surname";
        Age = 1;
        High = 1;
        Weight = 1;
        Nationality = "English";
        Birthdate = new DateTime(1900, 1, 1);
        Parent = new string[2];
        Parent[0] = "";
        Parent[1] = "";
        Sex = "";

        Salary = 0;
        EmploymentHistory = 0;
        ManagerialExperience = 0;
        OtherAllowances = 0;
        DaysOfSick = 0;
        DaysOfVacation = 0;
        Award = new string[1];
        Award[0] = "";
        Penalty = new string[1];
        Penalty[0] = "";
        Languages = new string[1];
        Languages[0] = "";

        Education = "";
        Specialization = "";
        Job = "";
        ProgramLanguage = new string[1];
        ProgramLanguage[0] = "";
    }

    public Programmer(string name, string surname, int age, int high, float weight, string nationality, DateTime birthdate, string parent0, string parent1, string sex,
        uint salary, uint employmenthistory, uint managerialexperience, uint otherallowances, uint daysofsick, uint daysofvacation, string educacion,
        string specializacion, string job)
    {
        ID = _number++ + 1;
        Name = name;
        SurName = surname;
        Age = age;
        High = high;
        Weight = weight;
        Nationality = nationality;
        Birthdate = birthdate;
        Parent = new string[2];
        Parent[0] = parent0;
        Parent[1] = parent1;
        Sex = sex;

        Salary = salary;
        EmploymentHistory = employmenthistory;
        ManagerialExperience = managerialexperience;
        OtherAllowances = otherallowances;
        DaysOfSick = daysofsick;
        DaysOfVacation = daysofvacation;
        Award = new string[1];
        Award[0] = "";
        Penalty = new string[1];
        Penalty[0] = "";
        Languages = new string[1];
        Languages[0] = "";

        Education = educacion;
        Specialization = specializacion;
        Job = job;
        ProgramLanguage = new string[1];
        ProgramLanguage[0] = "";
    }

    public void Creat(Programmer a)
    {
        try
        {
            Clear();
            Write("Введите 0 для создания шаблонного класса или 1 для самостоятельного ввода\n ");
            int choose = int.Parse(ReadLine());
            if (choose == 0)
            {
                a = new Programmer();
                return;
            }
            if (choose != 0 && choose != 1)
            {
                WriteLine("Неверный ааод");
                return;
            }
            WriteLine("Введите имя");
            string name = ReadLine();
            WriteLine("Введите фамилию");
            string surname = ReadLine();
            WriteLine("Введите возраст");
            int age = int.Parse(ReadLine());
            WriteLine("Введите рост(см)");
            int high = int.Parse(ReadLine());
            WriteLine("Введите массу(кг)");
            int weight = int.Parse(ReadLine());
            WriteLine("Введите национальность");
            string nationality = ReadLine();
            WriteLine("Введите день рождения(день)");
            int day = int.Parse(ReadLine());
            WriteLine("Введите день рождения(месяц)");
            int month = int.Parse(ReadLine());
            WriteLine("Введите день рождения(год)");
            int year = int.Parse(ReadLine());
            DateTime birthdate = new DateTime(year, month, day);
            WriteLine();
            string sex = ReadLine();
            WriteLine("Введите имя папы");
            string parent0 = ReadLine();
            WriteLine("Введите имя мамы");
            string parent1 = ReadLine();
            WriteLine("Введите оклад(в рублях)");
            int salary = int.Parse(ReadLine());
            WriteLine("Введите трудовой стаж(в годах)");
            int employmentHistory = int.Parse(ReadLine());
            WriteLine("Введите стаж в руководящей должности(в годах)");
            int managerialExperience = int.Parse(ReadLine());
            WriteLine("введите множитель зарплаты за другие достижения(умножается на 5 р.)");
            int otherAllowances = int.Parse(ReadLine());
            WriteLine("Введите количество свободных для больничного дней");
            int daysOfSick = int.Parse(ReadLine());
            WriteLine("Введите количество свободных для отпуска дней");
            int daysOfVacation = int.Parse(ReadLine());
            WriteLine();
            string education = ReadLine();
            WriteLine();
            string specialization = ReadLine();
            WriteLine();
            string job = ReadLine();
            if (age < 0 || high < 1 || weight < 1 || salary < 0 || employmentHistory < 0 || managerialExperience < 0
                        || otherAllowances < 0 || daysOfSick < 0 || daysOfVacation < 0)
                throw new Exception("Данные неверно введены (присутствуют отрицательные или невозможные числа) ");
            a = new Programmer(name, surname, age, high, weight, nationality, birthdate, parent0, parent1, sex, (uint)salary,
                           (uint)employmentHistory, (uint)managerialExperience, (uint)otherAllowances, (uint)daysOfSick, (uint)daysOfVacation,
                           education, specialization, job);
        }
        catch (FormatException e)
        {
            WriteLine("{0}", e.Message);
            Creat(a);
        }
        catch (Exception ex)
        {
            WriteLine("{0}", ex.Message);
            Creat(a);
        }
    }
}
