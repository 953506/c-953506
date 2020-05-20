using System;
using static System.Console;

public interface IWorker : IHuman
{
    public string[] Award { get; set; }
    public string[] Penalty { get; set; }
    public string[] Languages { get; set; }
    public uint Salary { get; set; }
    public uint EmploymentHistory { get; set; }
    public uint ManagerialExperience { get; set; }
    public uint OtherAllowances { get; set; }
    public uint DaysOfSick { get; set; }
    public uint DaysOfVacation { get; set; }
    public uint SalaryScale { get => Salary + 15 * ManagerialExperience + 10 * EmploymentHistory + 5 * OtherAllowances; }

    public new void ImportantDates()
    {
        WriteLine("{0} {1}, {2}, возраст: {3}, {4}", Name, SurName, Sex, Age, Nationality);
    }

    public void  WCout()
    {
        HCout();
        WriteLine("Оклад: {0}", Salary);
        WriteLine("Трудовой стаж: {0}", EmploymentHistory);
        WriteLine("Опыт на руководящей должности: {0}", ManagerialExperience);
        WriteLine("Другие достижения :{0}", OtherAllowances);
        WriteLine("Дней(максимум) на больничном: {0}", DaysOfSick);
        WriteLine("Дней(максимум) на отпуск: {0}", DaysOfVacation);
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

    public void AddComment()
    {
        try
        {
            Write("Введите номер уточняющей информации.\n 1 - награды\n 2 - взыскания\n 3 - языки\n ");
            int a = int.Parse(ReadLine());
            string[] str = Award;
            switch (a)
            {
                case 1: str = Award; break;
                case 2: str = Penalty; break;
                case 3: str = Languages; break;
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

    public void DeletComment()
    {
        try
        {
            WriteLine("Введите номер уточняющей информации.\n 1 - награды\n 2 - взыскания\n 3 - языки");
            int choose = int.Parse(ReadLine());
            string[] a;
            _ = Award;
            switch (choose)
            {
                case 1: a = Award; break;
                case 2: a = Penalty; break;
                case 3: a = Languages; break;
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
}