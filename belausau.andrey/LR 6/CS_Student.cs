namespace Pudge
{
    class CS_Student : Student//CS - computer science
    {
        //Конструкторы
        public CS_Student(string name, int averageMark)
        {
            Name = name;
            AverageMark = averageMark;
            University = "BSU";
            Faculty = "FAMCS";
        }

        public CS_Student(string name, string surname, string gender, int birthYear)
            : base(name, surname, gender, birthYear)
        {
            University = "BSUIR";
            Faculty = "FITM";
        }

        public override void Shout()
        {
            System.Console.WriteLine("CS student's shout");
        }
    }
}
