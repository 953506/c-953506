using System;

namespace Pudge
{
    class Student : Human, IStudent, IComparable
    {
        //Конструктор
        public Student() { }

        public Student(string name, int averageMark)
        {
            Name = name;
            AverageMark = averageMark;
        }
        public Student(string name, string surname, string gender, int birthYear) : base(name, surname, gender, birthYear)
        {
            AverageMark = 0;
            if (Age > 17)
            {
                Course = Age - 17;
                SocialStatus = "Student";
            }
        }

        //Свойства
        public string SocialStatus { get; set; }

        public int AverageMark { get; set; }

        public bool IsInArmy { get; set; }
        
        public bool IsKicked { get; set; }

        public string University { get; set; }

        public string Faculty { get; set; }
        
        public int Course { get; set; }

        //Методы
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Student otherStudent = obj as Student;
            if (otherStudent != null)
            {
                return AverageMark.CompareTo(otherStudent.AverageMark);
            }
            else
            {
                throw new ArgumentException("Object is not a BSUIR Student");
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"University - {University}");
            Console.WriteLine($"Faculty - {Faculty}");
            Console.WriteLine($"Course - {Course}");
            Console.WriteLine($"Average mark - {AverageMark}");
            Console.WriteLine($"Social status - {SocialStatus}");
            Console.Write("Is in army - ");
            Console.WriteLine(IsInArmy ? "Yes" : "No");
        }

        public void GoToArmy()
        {
            SocialStatus = "recruit";
            IsInArmy = true;
        }

        public virtual void Shout()
        {
            Console.WriteLine("Student's shout");
        }
    }
}
