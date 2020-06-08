using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class PStudent : Student
    {
        private int _cost;
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        private void SetCost()
        {
            if (base.MidMarks > 8) Cost = 1050;
            else if (base.MidMarks > 6 && base.MidMarks < 9) Cost = 1337;
            else Cost = 1488;
        }
        public PStudent(string name, string surname,int ID, int birthYear, int course, string gender, string speciality)
            : base(name, surname, ID, birthYear, course, gender , speciality)
        {
            SetCost();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"You have no grant and you should pay {Cost} every term");
        }

    }
}
