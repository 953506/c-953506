using System;

namespace Pudge
{
    class IITP_Student : Student
    {
        //Конструкторы
        public IITP_Student()
        {
            University = "BSUIR";
            Faculty = "FCSaN";
        }
        public IITP_Student(string name, int averageMark) : this()
        {
            Name = name;
            AverageMark = averageMark;
        }

        public IITP_Student(string name, string surname, string gender, int birthYear)
            : base(name, surname, gender, birthYear)
        {
            University = "BSUIR";
            Faculty = "FCSaN";
        }

        public override void Shout()
        {
            Console.WriteLine("IITP student's shout");
        }

        public void SayIITP()
        {
            Console.WriteLine("IITP TOP");
        }
    }
}
