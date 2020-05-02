using System;

namespace ЛабораторнаяСШ3
{
    class Human
    {
        string name;
        string sname;
        int age;
        int course;
        int math,it ,ml ;
        double srb = 0;
        public string Name
        {
            set { }
        }
        public string SName
        {
            set { }
        }
        public int Age
        {
            set { if (value < 0) age = 0;
                if (value > 0) age = value;
            }
        }
        public int Course
        {
            set
            {
                if (value < 1) course = 1;
                if (value > 4) course  = value;
            }
        }
        
        public Human()
        {
             name = "Имя";
             sname = "Фамилия";
             age = 17;
             course = 1;
             math = 1;
             it = 1;
             ml = 1;
        }
        public Human(string name, string sname, int age, int course, int math, int it, int ml)
        {
            this.name = name;
            this.sname = sname;
            this.age = age;
            this.course = course;
            this.math = math;
            this.it = it;
            this.ml = ml;
        }
        public string GetName()
        {
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            return name;
        }
        public string GetSurname()
        {
            Console.WriteLine("Surname: ");
            sname = Console.ReadLine();
            return sname;
        }
        public int GetAge()
        {
            Console.WriteLine("Age: ");
            int.TryParse(Console.ReadLine(), out age);
            return age;
        }

        public int GetCourse()
        {
            Console.WriteLine("Course: ");
            int.TryParse(Console.ReadLine(), out course);
            return course;
        }
        public int GetMath()
        {
            Console.WriteLine("Math: ");
            int.TryParse(Console.ReadLine(), out math);
            return math;

        }

        public int GetIt()
        {
            Console.WriteLine("It: ");
            int.TryParse(Console.ReadLine(), out it);
            return it;
        }

        public int GetMl()
        {
            Console.WriteLine("Ml: ");
            int.TryParse(Console.ReadLine(), out ml);
            return ml;
        }
       public void Srb()
        {
            srb=(math + it + ml) / 3;
            Console.WriteLine("GPA: " + srb);
        }
        public void PrintAll()
        {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Surname: " + sname);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Course: " + course);
                Console.WriteLine("Points for math: " + math);
                Console.WriteLine("Points for it: " + it);
                Console.WriteLine("Points for ml: " + ml); 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students do you want to enter ?");
            string n = Console.ReadLine();
            int N = int.Parse(n);
            Human student = new Human();
            for (int i = 0; i < N; i++)
            { 
                student.GetName();
                student.GetSurname();
                student.GetAge();
                student.GetCourse();
                student.GetMath();
                student.GetIt();
                student.GetMl();
                student.PrintAll();
                student.Srb();
            } 
        }
    }
}
