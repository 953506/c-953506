using System;

namespace Pudge
{
    class Student : Human, IStudent, IComparable
    {
        protected string socialStatus, university, faculty;
        protected int course, averageMark;
        protected bool isInArmy, isKicked;

        //Конструктор
        public Student() : base() { }

        public Student(string name, int averageMark) : this()
        {
            this.name = name;
            this.averageMark = averageMark;
        }

        public Student(string name, string surname, string gender, int birthYear) : base(name, surname, gender, birthYear)
        {
            averageMark = 0;
            
            if (age > 17)
            {
                course = age - 17;
                socialStatus = "Student";
            }
        }

        //Свойства
        public string SocialStatus 
        { 
            get => socialStatus; 
            set => socialStatus = value; 
        }

        public int AverageMark
        {
            get => averageMark; 
            set => averageMark = value; 
        }
        
        public bool IsInArmy
        {
            get => isInArmy;
        }

        public bool IsKicked
        {
            get => isKicked;
        }

        public string University
        {
            get => university; 
            set => university = value; 
        }

        public string Faculty 
        {
            get => faculty;
            set => faculty = value; 
        }

        public int Course 
        {
            get => course; 
            set => course = value; 
        }

        //Методы
        public int CompareTo(object obj)
        {
            Student otherStudent = obj as Student;

            if (otherStudent is null)
            {
                throw new ArgumentException();
            }

            if(otherStudent.averageMark == 0 || averageMark == 0)
            {
                throw new ArgumentNullException();
            }

            return AverageMark.CompareTo(otherStudent.AverageMark);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"University - {university}");
            Console.WriteLine($"Faculty - {faculty}");
            Console.WriteLine($"Course - {course}");
            Console.WriteLine($"Average mark - {averageMark}");
            Console.WriteLine($"Social status - {socialStatus}");
            Console.Write("Is in army - ");
            Console.WriteLine(isInArmy ? "Yes" : "No");
        }

        public delegate void GoToArmyHandler(string message);
        public event GoToArmyHandler ArmyNotify;

        public void GoToArmy()
        {
            ArmyNotify?.Invoke("+1 recruit");
            socialStatus = "recruit";
            isInArmy = true;
        }

        public void Expel()
        {
            faculty = university = "none";
            socialStatus = "Kicked from university";
            isKicked = true;
            course = 0;
        }

        public virtual void Shout()
        {
            Console.WriteLine("Student's shout");
        }
    }
}