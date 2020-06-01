using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class StudentBudjet : Student
    {
        private int _stepuha;
        public int Stepuha
        {
            get { return _stepuha; }
            set { _stepuha = value; }
        }

        public StudentBudjet(string name, string lastname, int age, int stage) : base( name,  lastname,  age,  stage)
        {
            SetStepuha();
        }

        private void SetStepuha()
        {
            if (base.Rating > 80) Stepuha = 150;
            else if (base.Rating > 60 && base.Rating < 90) Stepuha = 100;
            else if (base.Rating == 60) Stepuha = 80;
            else Stepuha = 0;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Scholarship is {0} rubles.", Stepuha);
        }
    }
}
