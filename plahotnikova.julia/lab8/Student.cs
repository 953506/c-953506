using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Student : Human
    {
        public delegate void Warning();
        public event Warning University;
        public delegate void Enter();

        private int _year;
        private string _speciality;
        private int _groupnum;
        private string _university;
        private string _universityType;
        private string _dormitory;

        public Student(string firstname, string lastname, DateTime birthdate, Sex sex,
            int height, int weight, int age, string speciality, int year, int groupnum, string university)
            : base(firstname, lastname, birthdate, sex, height, weight, age)
        {
            _year = year;
            _speciality = speciality;
            _groupnum = groupnum;
            _university = university;
        }

        public override void InstitutionType()
        {
            Console.WriteLine("Enter your university type( private/state ): ");
            _universityType = Console.ReadLine();
            if (_universityType!="private" || _universityType != "state")
            {
                throw new Exception("Incorrect format of university type.");
            }
        }

        public void EnterAnotherUniversity()
        {
            int choose;
            Console.WriteLine("Transfer student to another university?\n1.Yes\n2.No\n ");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:

                    {
                        Console.WriteLine("Enter the university where you want to transfer the student: ");
                        _university = Console.ReadLine();
                        if (_university == "BSUIR")
                        {
                            University();
                        }
                        break;
                    }

                case 2: Console.WriteLine("Operation canceled."); break;
            }
        }

        public void Dormitory()
        {
            string answer;
            string answer1;
            Console.WriteLine("Does the student live in a dormitory?");
            answer = Console.ReadLine();
            if (answer == "Yes")
            {
                _dormitory = "Yes";
                Console.WriteLine("Evict?");
                answer1 = Console.ReadLine();
                if (answer1 == "Yes")
                {
                    Message(Evicting);
                    _dormitory = "No";
                }
                else Console.WriteLine("Operation canceled.");
            }

            else
            {
                _dormitory = "No";
                Console.WriteLine("Check?");
                answer1 = Console.ReadLine();
                if (answer1 == "Yes")
                {
                    Message(Entering);
                    _dormitory = "Yes";
                }
                else Console.WriteLine("Operation canceled.");
            }
        }

        private static void Message(Enter ent)
        {
            ent?.Invoke();
        }

        private static void Entering()
        {
            Console.WriteLine("Person checked.");
        }

        private static void Evicting()
        {
            Console.WriteLine("Person evicted.");
        }

        public override string ToString()
        {
            return $"Name: {firstname}, {lastname};" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine +
                $"Birthdate: {birthdate.ToShortDateString()}" + Environment.NewLine +
                $"Sex: {sex};" + Environment.NewLine +
                $"Height: {height} cm;" + Environment.NewLine +
                $"Weight: {weight} kg." + Environment.NewLine +
                $"University: {_university};" + Environment.NewLine +
                $"Year of entering: {_year}" + Environment.NewLine +
                $"Type of university: {_universityType}" + Environment.NewLine +
                $"Speciality: {_speciality}" + Environment.NewLine +
                $"Number og group: {_groupnum}" + Environment.NewLine +
                $"Dormitory: {_dormitory}";
        }
    }
}