using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Worker : Human, IMoney
    {
        private int _workTime;
        private string _workExperience;
        private string _headName;
        private string _dresscode;
        private string _workplaceType;
        private int _vacation = 30;

        public Work YourWork = new Work();

        public Worker(string firstname, string lastname, DateTime birthdate, Sex sex,
            int height, int weight, int age)
            : base(firstname, lastname, birthdate, sex, height, weight, age) { }

        public override void InstitutionType()
        {
            Console.WriteLine("Enter type of your place of work( private/state ): ");
            _workplaceType = Console.ReadLine();
        }

        public void InformationAboutJob()
        {
            Console.WriteLine("Do you have any dresscode?");
            _dresscode = Console.ReadLine();
            Console.WriteLine("Enter the time you spend at work(in hours): ");
            _workTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the boss: ");
            _headName = Console.ReadLine();
            Console.WriteLine("Enter your work experience: ");
            _workExperience = Console.ReadLine();
            Console.WriteLine("Enter your position: ");
            YourWork.Position = Console.ReadLine();
            Console.WriteLine("Enter your place of work: ");
            YourWork.PlaceOfWork = Console.ReadLine();
            YourWork.Money();
        }

        public void Vacation()
        {
            string choice;
            int days;
            Console.WriteLine("Do you want to go on vacation?(Yes/No");
            choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Console.WriteLine("Enter the number of vacation days: ");
                days = Convert.ToInt32(Console.ReadLine());
                _vacation -= days;
                Console.WriteLine($"Days left: {_vacation}");
            }
            else
            {
                Console.WriteLine("Operation canceled.");
                Console.WriteLine($"Days left: {_vacation}");
            }
        }

        public int Money { get { return YourWork.Salary; } }

        public void Rise(int money) { YourWork.Salary += money; }

        public void Lose(int money)
        {
            if (YourWork.Salary >= money)
            {
                YourWork.Salary -= money;
            }
        }

        public override string ToString()
        {
            return $"Name: {firstname}, {lastname};" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine +
                $"Birthdate: {birthdate.ToShortDateString()}" + Environment.NewLine +
                $"Sex: {sex};" + Environment.NewLine +
                $"Height: {height} cm;" + Environment.NewLine +
                $"Weight: {weight} kg." + Environment.NewLine +
                $"Place of work: {YourWork.PlaceOfWork};" + Environment.NewLine +
                $"Salary: {YourWork.Salary} $" + Environment.NewLine +
                $"Position: {YourWork.Position}" + Environment.NewLine +
                $"Work time: {_workTime}" + Environment.NewLine +
                $"Work experience: {_workExperience}" + Environment.NewLine +
                $"Type of place of work: {_workplaceType}" + Environment.NewLine +
                $"Head name: {_headName}" + Environment.NewLine +
                $"Dresscode: {_dresscode}";
        }
    }
