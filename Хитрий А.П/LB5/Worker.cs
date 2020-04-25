using System;
using static System.Console;
using System.Windows.Forms;

class Worker : Human
{
    protected string[] _award = new string[1];
    protected string[] _penalty = new string[1];
    protected string[] _languages = new string[1];

    public Worker() : base()
    {
        Salary = 0;
        EmploymentHistory = 0;
        ManagerialExperience = 0;
        OtherAllowances = 0;
        DaysOfSick = 0;
        DaysOfVacation = 0;
        _award[0] = "";
        _penalty[0] = "";
        _languages[0] = "";
    }

    public Worker(string name, string surname, int age, int high, float weight, string nationality, 
                  DateTime birthdate, string parent0, string parent1, string sex, uint salary, 
                  uint employmenthistory, uint managerialexperience, uint otherallowances, uint daysofsick, uint daysofvacation) :
                  base(name, surname, age, high, weight, nationality, birthdate, parent0, parent1, sex)
    {
        Salary = salary;
        EmploymentHistory = employmenthistory;
        ManagerialExperience = managerialexperience;
        OtherAllowances = otherallowances;
        DaysOfSick = daysofsick;
        DaysOfVacation = daysofvacation;
        _award[0] = "";
        _penalty[0] = "";
        _languages[0] = "";
    }

    public uint Salary { get; set; }
    public uint EmploymentHistory { get; set; }
    public uint ManagerialExperience { get; set; }
    public uint OtherAllowances { get; set; }
    public uint DaysOfSick { get; set; }
    public uint DaysOfVacation { get; set; }

    public uint SalaryScale { get => Salary + 15 * ManagerialExperience + 10 * EmploymentHistory + 5 * OtherAllowances; }

    public new void Cout()
    {
        base.Cout();
        WriteLine("Оклад: {0}", Salary);
        WriteLine("Трудовой стаж: {0}", EmploymentHistory);
        WriteLine("Опыт на руководящей должности: {0}", ManagerialExperience);
        WriteLine("Другие достижения :{0}", OtherAllowances);
        WriteLine("Дней(максимум) на больничном: {0}", DaysOfSick);
        WriteLine("Дней(максимум) на отпуск: {0}", DaysOfVacation);
        WriteLine("Языки");
        for (int i = 0; i < _languages.Length; ++i)
            WriteLine(_languages[i]);
        WriteLine("Награды ");
        for (int i = 0; i < _award.Length; ++i)
            WriteLine(_award[i]);
        WriteLine("Взыскания");
        for (int i = 0; i < _penalty.Length; ++i)
            WriteLine(_penalty[i]);
    }

    public void AddReSize(ref string[] str)
    {
        for (int i = 0; i < str.Length; ++i)
        {
            if (str[i] == "")
            {
                Write("Введите уточн. информацию\n ");
                str[i]=ReadLine();
                return;
            }
            if (i == str.Length - 1)
            {
                Array.Resize(ref str, str.Length + 1);
                str[str.Length - 1] = "";
            }
        }
    }

    public virtual void AddComment()
    {
        Write("Введите номер уточняющей информации.\n 1 - награды\n 2 - взыскания\n 3 - языки\n ");
        int a = int.Parse(ReadLine());
        switch (a)
        {
            case 1: AddReSize(ref _award); break;
            case 2: AddReSize(ref _penalty); break;
            case 3: AddReSize(ref _languages); break;
        }
    }

    public void DeletReSize(ref string[] a)
    {
        Write("Введите номер элемента, который вы хотите удалить\n ");
        int choose = int.Parse(ReadLine());
        if (choose == 0 && a.Length == 1)
        {
            a[0] = "";
            return;
        }
        if (choose < 0 || choose >= a.Length)
        {
            WriteLine("Неверный ввод");
            return;
        }
        for (int i = choose; i < a.Length - 1; ++i)
            a[i] = a[i + 1];
        Array.Resize(ref a, a.Length - 1);
        WriteLine("Элемент удален");
    }

    public virtual void DeletComment()
    {
        WriteLine("Введите номер уточняющей информации.\n 1 - награды\n 2 - взыскания\n 3 - языки");
        int a = int.Parse(ReadLine());
        switch (a)
        {
            case 1: DeletReSize(ref _award); break;
            case 2: DeletReSize(ref _penalty); break;
            case 3: DeletReSize(ref _languages); break;
            default: return;
        }
    }

    public override void ImportantDates()
    {
        WriteLine("{0} {1}, {2}, возраст: {3}, {4}",Name,SurName,Sex, Age, Nationality);
    }

    public void Creat(Worker a)
    {
        try
        {
            Clear();
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
            if (age < 0 || high < 1 || weight < 1 || salary < 0 || employmentHistory < 0 || managerialExperience < 0
                        || otherAllowances < 0 || daysOfSick < 0 || daysOfVacation < 0)
                throw new Exception("Данные неверно введены (присутствуют отрицательные или невозможные числа) ");
            a = new Worker(name, surname, age, high, weight, nationality, birthdate, parent0, parent1, sex, (uint)salary,
                           (uint)employmentHistory, (uint)managerialExperience, (uint)otherAllowances, (uint)daysOfSick, (uint)daysOfVacation);
        }
        catch (FormatException e)
        {
            MessageBox.Show(e.Message);
            Creat(a);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            Creat(a);
        }
        return;
    }
}
