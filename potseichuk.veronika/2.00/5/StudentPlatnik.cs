using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class StudentPlatnik : Student
    {
        private int _cost;
        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public StudentPlatnik(string name, string lastname, int age, int stage) : base(name, lastname, age, stage)
        {
            SetCost();
        }

        private void SetCost()
        {
            if (base.Rating > 8) Cost = 1000;
            else if (base.Rating > 6 && base.Rating < 9) Cost = 1200;
            else Cost = 1500;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Payment for the semester is {0} rubles.", Cost);
        }
    }
}
