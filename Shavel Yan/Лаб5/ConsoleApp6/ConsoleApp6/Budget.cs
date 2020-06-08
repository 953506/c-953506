using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class BudgetStudent : Student
    {
        private double _grant;
        public double Grant
        {
            get
            {
                return _grant;
            }
            set
            {
                _grant = value;
            }
        }
        public BudgetStudent(string name, string surname,int ID, int birthYear, int course, string gender, string speciality)
            : base(name, surname, ID, birthYear, course, gender, speciality)
        {
            SetGrant();
        }
        private void SetGrant()
        {
            if (base.MidMarks > 9) Grant = 147.00;
            else if (base.MidMarks > 6 && base.MidMarks < 9) Grant = 99.99;
            else if (base.MidMarks == 6) Grant = 79.99;
            else Grant = 0;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Your grant is {Grant} rubles.");
        }
    }
}
