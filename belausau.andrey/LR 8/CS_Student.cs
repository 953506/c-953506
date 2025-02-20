﻿namespace Pudge
{
    sealed class CS_Student : Student//CS - computer science
    {
        //Конструкторы
        public CS_Student(string name, int averageMark)
        {
            this.name = name;
            this.averageMark = averageMark;
            university = "BSU";
            faculty = "FAMCS";
        }

        public CS_Student(string name, string surname, string gender, int birthYear)
            : base(name, surname, gender, birthYear)
        {
            university = "BSU";
            faculty = "FAFMCS";
        }

        public override void Shout()
        {
            System.Console.WriteLine("CS student's shout");
        }
    }
}
