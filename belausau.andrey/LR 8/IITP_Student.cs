using System;

namespace Pudge
{
    sealed class IITP_Student : Student
    {
        //Конструкторы
        public IITP_Student()
        {
            university = "BSUIR";
            faculty = "FCSaN";
        }
        public IITP_Student(string name, int averageMark) : this()
        {
            this.name = name;
            this.averageMark = averageMark;
        }

        public IITP_Student(string name, string surname, string gender, int birthYear)
            : base(name, surname, gender, birthYear)
        {
            university = "BSUIR";
            faculty = "FCSaN";
        }

        public override void Shout()
        {
            if(isKicked)
            {
                throw new Exception("kicked students can't shout");
            }
            Console.WriteLine("IITP student's shout");
        }
    }
}
