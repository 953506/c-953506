using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class StudentBudjet : Student
    {
        private int _stepuha;
        public int Stepuha
        {
            get { return _stepuha; }
            set { _stepuha = value; }
        }

        public StudentBudjet(string name, string lastname, int age, int stage) : base(name, lastname, age, stage)
        {
            SetStepuha();
        }

        private void SetStepuha()
        {
            if (base.Rating > 8) Stepuha = 150;
            else if (base.Rating > 6 && base.Rating < 9) Stepuha = 100;
            else if (base.Rating == 6) Stepuha = 80;
            else Stepuha = 0;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Степендия составляет {0} рублей.", Stepuha);
        }

        public override void Complain()
        {
            base.Complain();
            Console.WriteLine("Степендия маденькая(((");
        }
    }

}
