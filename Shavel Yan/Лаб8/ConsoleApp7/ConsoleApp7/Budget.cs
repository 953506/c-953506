using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
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
        private void Payment()
        {
            PaysOrNot = "You dont have to pay";
        }
        public BudgetStudent(string name, string surname, int ID, int birthYear, int course, string gender, string speciality, string paysornot)
            : base(name, surname, ID, birthYear, course, gender, speciality, paysornot)
        {
            Payment();
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
            Console.WriteLine(PaysOrNot);
            Console.WriteLine($"Your grant is {Grant} rubles.");
            Complain();
        }
        public override void Complain()
        {
            Console.WriteLine("Wow you have a grant");
        }
    }
}
