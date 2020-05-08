using System;
using static System.Console;
using System.Windows.Forms;

sealed class Person : Programmer
{
    public Person() : base() { }

    public Person(string name, string surname, int age, int high, float weight, string nationality, DateTime birthdate, string parent0, string parent1, string sex,
        uint salary, uint employmenthistory, uint managerialexperience, uint otherallowances, uint daysofsick, uint daysofvacation, string educacion,
        string specializacion, string job) : base(name, surname, age, high, weight, nationality, birthdate, parent0, parent1, sex, salary,
        employmenthistory, managerialexperience, otherallowances, daysofsick, daysofvacation, educacion, specializacion, job) { }

    public override void Creat(Programmer a)
    {
        try
        {
            Clear();
            Write("Введите 0 для создания шаблонного класса или 1 для самостоятельного ввода\n ");
            int choose = int.Parse(ReadLine());
            if (choose == 0)
            {
                a = new Person();
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
            WriteLine("Введите: 1 - Мужской пол, 2 - Женский, 3 - Ввести другой пол");
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
            WriteLine("");
            string education = ReadLine();
            WriteLine("");
            string specialization = ReadLine();
            WriteLine("");
            string job = ReadLine();
            if (age < 0 || high < 1 || weight < 1 || salary < 0 || employmentHistory < 0 || managerialExperience < 0
                        || otherAllowances < 0 || daysOfSick < 0 || daysOfVacation < 0)
                throw new Exception("Данные неверно введены (присутствуют отрицательные или невозможные числа) ");
            a = new Person(name, surname, age, high, weight, nationality, birthdate, parent0, parent1, sex, (uint)salary,
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
