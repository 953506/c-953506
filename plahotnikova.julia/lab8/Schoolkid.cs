using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Schoolkid : Human
    {
        public delegate void Message();
        public event Message Grade;

        private string _grade;
        private string _holidays;
        private string _schooltype;
        private string _status;
        private double _certificate;


        public Schoolkid(string firstname, string lastname, DateTime birthdate, Sex sex,
            int height, int weight, int age, string grade, string holidays)
            : base(firstname, lastname, birthdate, sex, height, weight, age)
        {
            _grade = grade;
            _holidays = holidays;
        }

        public override void InstitutionType()
        {
            Console.WriteLine("Enter your school type( private/state ): ");
            _schooltype = Console.ReadLine();
        }

        enum Status
        {
            Bummer = 4,
            Hoping = 5,
            Middling = 6,
            Striving = 8,
            Wiseacre = 9
        }

        public void YourStatus()
        {
            Console.WriteLine("Enter your marks(space separated): ");
            string smarks = Console.ReadLine();
            if (smarks == null)
                throw new FormatException(String.Format("The string is empty."));
            char ch = ' ';
            string[] marks = smarks.Split(ch);
            int[] c = new int[marks.Length];
            int sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                c[i] = Convert.ToInt32(marks[i]);
            }

            for (int i = 0; i < c.Length; i++)
            {
                sum += c[i];
            }
            _certificate = sum / c.Length;
            Console.WriteLine($"Your certificate: {_certificate}");

            if (_certificate <= (int)Status.Bummer)
            {
                _status = "Bummer";
            }
            else if (_certificate == (int)Status.Hoping)
            {
                _status = "Hopes for something better";
            }
            else if (_certificate == (int)Status.Middling)
            {
                _status = "Sometimes doing homework";
            }
            else if (_certificate == (int)Status.Striving)
            {
                _status = "Has the ability to study";
            }
            else if (_certificate >= (int)Status.Wiseacre)
            {
                _status = "Wiseacre";
            }

            if (_status != null)
            {
                Grade();
            }
        }

        public bool Equals(Schoolkid other)
        {
            return this.ToString() == other.ToString();
        }

        public override string ToString()
        {
            return $"Name: {firstname}, {lastname};" + Environment.NewLine +
                $"Age: {age}" + Environment.NewLine +
                $"Birthdate: {birthdate.ToShortDateString()}" + Environment.NewLine +
                $"Sex: {sex};" + Environment.NewLine +
                $"Height: {height} cm;" + Environment.NewLine +
                $"Weight: {weight} kg." + Environment.NewLine +
                $"Upcoming vacation: {_holidays};" + Environment.NewLine +
                $"Grade: {_grade}" + Environment.NewLine +
                $"Type of school: {_schooltype}" + Environment.NewLine +
                $"Grade point average: {_certificate}" + Environment.NewLine +
                $"Status: {_status}";

        }

    }
}