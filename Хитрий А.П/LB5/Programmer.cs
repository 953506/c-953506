using System;
using static System.Console;
using System.Windows.Forms;

sealed class Programmer : Worker
{
    private string[] _programLanguage = new string[1];
    private string Education { get; set; }
    private string Specialization { get; set; }
    private string Job { get; set; } 

    public Programmer() : base()
    {
        Education = "";
        Specialization = "";
        Job = "";
        _programLanguage[0] = "";
    }

    public Programmer(string name, string surname, int age, int high, float weight, string nationality,
                      DateTime birthdate, string parent0, string parent1, string sex, uint salary, uint employmenthistory,
                      uint managerialexperience, uint otherallowances, uint daysofsick, uint daysofvacation, string educacion,
                      string specializacion, string job) : base(name, surname, age, high, weight, nationality, birthdate,
                      parent0, parent1, sex, salary, employmenthistory, managerialexperience, otherallowances, daysofsick, daysofvacation)
    {
        Education = educacion;
        Specialization = specializacion;
        Job = job;
        _programLanguage[0] = "";
    }

    public new void ImportantDates()
    {
        WriteLine(" {0} {1}, {2}, возраст: {3}, {4}, {5}", Name, SurName, Sex, Age, Nationality, Job);
    }

    public new void Cout()
    {
        Clear();
        base.Cout();
        WriteLine("Образование: {0}",Education);
        WriteLine("Специализация: {0}", Specialization);
        WriteLine("Должность: {0}", Job);
        WriteLine("Известные языки программирования");
        for (int i = 0; i < _programLanguage.Length; ++i)
            WriteLine(_programLanguage[i]);
    }

    public override void AddComment()
    {
        Clear();
        Write("Введите номер уточняющей информации.\n 0 - выход\n 1 - награды\n 2 - взыскания\n 3 - языки\n 4 - языки программирования\n ");
        int a = int.Parse(ReadLine());
        switch (a)
        {
            case 0: return;
            case 1: AddReSize(ref _award); break;
            case 2: AddReSize(ref _penalty); break;
            case 3: AddReSize(ref _languages); break;
            case 4: AddReSize(ref _programLanguage); break;
            default: WriteLine("Неверный ввод"); return;
        }
    }

    public override void DeletComment()
    {
        Write("Введите номер уточняющей информации.\n 0 - выход\n 1 - награды\n 2 - взыскания\n 3 - языки\n 4 - языки программирования\n ");
        int a = int.Parse(ReadLine());
        switch (a)
        {
            case 0: return;
            case 1: DeletReSize(ref _award); break;
            case 2: DeletReSize(ref _penalty); break;
            case 3: DeletReSize(ref _languages); break;
            case 4: DeletReSize(ref _programLanguage); break;
            default: WriteLine("Неверный ввод"); return;
        }
    }

    public void WriteString()
    {
        Clear();
        Write("Для вывода введите номер элемента\n 0 - выход\n 1 - имя\n 2 - фамилия\n 3 - возраст\n 4 - рост\n 5 - вес\n 6 - национальность\n" +
              " 7 - день рождения\n 8 - пол\n 9 - имя отца\n 10 - имя матери\n 11 - оклад\n 12 - трудовой стаж\n 13 - стаж в руководящей должности\n" +
              " 14 - множитель за другие заслуги\n 15 - кол-во дней больничного\n 16 - кол-во дней отпуска\n 17 - образование\n" +
              " 18 - специализация\n 19 - должность\n ");
        int choose = int.Parse(ReadLine());
        switch(choose)
        {
            case 0:  return;
            case 1:  WriteLine(Name); break;
            case 2:  WriteLine(SurName); break;
            case 3:  WriteLine(Age); break;
            case 4:  WriteLine(High); break;
            case 5:  WriteLine(Weight); break;
            case 6:  WriteLine(Nationality); break;
            case 7:  WriteLine(Birthdate.ToString("D")); break;
            case 8:  WriteLine(Sex); break;
            case 9:  WriteLine(_parent[0]); break;
            case 10: WriteLine(_parent[1]); break;
            case 11: WriteLine(Salary); break;
            case 12: WriteLine(EmploymentHistory); break;
            case 13: WriteLine(ManagerialExperience); break;
            case 14: WriteLine(OtherAllowances); break;
            case 15: WriteLine(DaysOfSick); break;
            case 16: WriteLine(DaysOfVacation); break;
            case 17: WriteLine(Education); break;
            case 18: WriteLine(Specialization); break;
            case 19: WriteLine(Job); break;
        }
    }

    public void ChangeString()
    {
        try 
        { 
            Clear();
            Write("Для ввода введите номер элемента\n 0 - выход\n 1 - имя\n 2 - фамилия\n 3 - возраст\n 4 - рост\n 5 - вес\n 6 - национальность\n" +
                  " 7 - день рождения\n 8 - пол\n 9 - имя отца\n 10 - имя матери\n 11 - оклад\n 12 - трудовой стаж\n 13 - стаж в руководящей должности\n" +
                  " 14 - множитель за другие заслуги\n 15 - кол-во дней больничного\n 16 - кол-во дней отпуска\n 17 - образование\n" +
                  " 18 - специализация\n 19 - должность\n ");
            int choose = int.Parse(ReadLine());
            switch (choose)
            {
                case 0:  return;
                case 1:  Name=ReadLine(); break;
                case 2:  SurName = ReadLine(); break;
                case 3:  Age = int.Parse(ReadLine()); break;
                case 4:  High = int.Parse(ReadLine()); break;
                case 5:  Weight = int.Parse(ReadLine()); break;
                case 6:  Nationality = ReadLine(); break;
                case 7:  Date(); break;
                case 8:  Sex = ReadLine(); break;
                case 9:  _parent[0] = ReadLine(); break;
                case 10: _parent[1] = ReadLine(); break;
                case 11: Salary = uint.Parse(ReadLine()); break;
                case 12: EmploymentHistory = uint.Parse(ReadLine()); break;
                case 13: ManagerialExperience = uint.Parse(ReadLine()); break;
                case 14: OtherAllowances = uint.Parse(ReadLine()); break;
                case 15: DaysOfSick = uint.Parse(ReadLine()); break;
                case 16: DaysOfVacation = uint.Parse(ReadLine()); break;
                case 17: Education = ReadLine(); break;
                case 18: Specialization = ReadLine(); break;
                case 19: Job = ReadLine(); break;
            }
        }
        catch (FormatException e)
        {
            MessageBox.Show(e.Message);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    public void ExtraInfo()
    {
        WriteLine("ID: {0}",ID);
        WriteLine("Возрат относительно дня рождения: {0}", CalculateAge());
        WriteLine("Индекс массы тела: {0}", IMT);
    }

    public void ClarifyInfo()
    {
        WriteLine("Известные языки программирования");
        for (int i = 0; i < _programLanguage.Length; ++i)
            WriteLine(_programLanguage[i]);
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

    public void Creat(Programmer a)
    {
        try
        {
            Clear();
            Write("Введите 0 для создания шаблонного класса или 1 для самостоятельного ввода\n ");
            int choose = int.Parse(ReadLine());
            if(choose == 0)
            {
                a = new Programmer();
                return;
            }
            if( choose != 0 && choose != 1 )
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
