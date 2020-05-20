using System;
using static System.Console;

public interface IProgrammer : IWorker
{
    public string[] ProgramLanguage { get; set; }
    public string Education { get; set; }
    public string Specialization { get; set; }
    public string Job { get; set; }

    public new void ImportantDates()
    {
        WriteLine("\n {0} {1}, {2}, возраст: {3}, {4}, {5}", Name, SurName, Sex, Age, Nationality, Job);
    }

    public void Cout()
    {
        Clear();
        WCout();
        WriteLine("Образование: {0}",Education);
        WriteLine("Специализация: {0}", Specialization);
        WriteLine("Должность: {0}", Job);
        WriteLine("Известные языки программирования");
        for (int i = 0; i < ProgramLanguage.Length; ++i)
            WriteLine(ProgramLanguage[i]);
    }

    public new void AddComment()
    {
        try
        { 
            Clear();
            Write("Введите номер уточняющей информации.\n 0 - выход\n 1 - награды\n 2 - взыскания\n 3 - языки\n 4 - языки программирования\n ");
            int a = int.Parse(ReadLine());
            string[] str = Award;
            switch (a)
            {
                case 0: return;
                case 1: str = Award; break;
                case 2: str = Penalty; break;
                case 3: str = Languages; break;
                case 4: str = ProgramLanguage; break;
            }
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == "")
                {
                    Write("Введите уточн. информацию\n ");
                    str[i] = ReadLine();
                    return;
                }
                if (i == str.Length - 1)
                {
                    Array.Resize(ref str, str.Length + 1);
                    str[^1] = "";
                }
            }
        }
        catch (Exception e)
        {
            WriteLine("{0}", e.Message);
            Clear();
        }
    }

    public  new void DeletComment()
    {
        try
        {
            Clear();
            Write("Введите номер уточняющей информации.\n 0 - выход\n 1 - награды\n 2 - взыскания\n 3 - языки\n 4 - языки программирования\n ");
            int choose = int.Parse(ReadLine());
            string[] a;
            _ = Award;
            switch (choose)
            {
                case 0: return;
                case 1: a = Award; break;
                case 2: a = Penalty; break;
                case 3: a = Languages; break;
                case 4: a = ProgramLanguage; break;
                default: return;
            }
            Write("Введите номер элемента, который вы хотите удалить\n ");
            choose = int.Parse(ReadLine());
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
        catch (Exception e)
        {
            WriteLine("{0}", e.Message);
            Clear();
        }
    }

    public void WriteString()
    {
        try
        {
            Clear();
            Write("Для вывода введите номер элемента\n 0 - выход\n 1 - имя\n 2 - фамилия\n 3 - возраст\n 4 - рост\n 5 - вес\n 6 - национальность\n" +
                  " 7 - день рождения\n 8 - пол\n 9 - имя отца\n 10 - имя матери\n 11 - оклад\n 12 - трудовой стаж\n 13 - стаж в руководящей должности\n" +
                  " 14 - множитель за другие заслуги\n 15 - кол-во дней больничного\n 16 - кол-во дней отпуска\n 17 - образование\n" +
                  " 18 - специализация\n 19 - должность\n ");
            int choose = int.Parse(ReadLine());
            switch (choose)
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
                case 9:  WriteLine(Parent[0]); break;
                case 10: WriteLine(Parent[1]); break;
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
        catch (Exception e)
        {
            WriteLine("{0}", e.Message);
            Clear();
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
                case 9:  Parent[0] = ReadLine(); break;
                case 10: Parent[1] = ReadLine(); break;
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
            WriteLine("{0}", e.Message);
        }
        catch (Exception ex)
        {
            WriteLine("{0}", ex.Message);
        }
    }

    public void ExtraInfo()
    {
        WriteLine("ID: {0}",ID);
        CalculateAge();
        WriteLine("Индекс массы тела: {0}", IMT);
    }

    public void ClarifyInfo()
    {
        WriteLine("Известные языки программирования");
        for (int i = 0; i < ProgramLanguage.Length; ++i)
            WriteLine(ProgramLanguage[i]);
        WriteLine("Языки");
        for (int i = 0; i < Languages.Length; ++i)
            WriteLine(Languages[i]);
        WriteLine("Награды ");
        for (int i = 0; i < Award.Length; ++i)
            WriteLine(Award[i]);
        WriteLine("Взыскания");
        for (int i = 0; i < Penalty.Length; ++i)
            WriteLine(Penalty[i]);
    }
}
