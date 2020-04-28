namespace Pudge
{
    class IE_Student : Student
    {
        //Конструкторы
        public IE_Student(string name, int averageMark)
        {
            Name = name;
            AverageMark = averageMark;
            University = "BSUIR";
            Faculty = "FITM";
        }

        public IE_Student(string name, string surname, string gender, int birthYear)
            : base(name, surname, gender, birthYear)
        {
            University = "BSUIR";
            Faculty = "FITM";
        }

        public override void Shout()
        {
            System.Console.WriteLine("IE student's shout");
        }
    }
}
