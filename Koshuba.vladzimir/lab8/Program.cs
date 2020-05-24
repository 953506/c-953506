using System;

namespace _5._1
{
    interface ISubjects
    {
        public void Exam(bool pass)
        {
            if (pass)
            {
                Console.WriteLine("You are pass exames");
                pass = false;
            }

            else
            {
                Console.WriteLine("Lucky next time");
            }
        }

        public void ShowSubjects();

        bool Available { get; set; }
    }

    interface IPeopls
    {
        public const int minPeople = 0;
        public static int _maxPeople = 200;

        public int MaxPeople
        {
            get { return _maxPeople; }
            set { _maxPeople = value; }
        }

        public double Amount(double groups, double peoples) => peoples / groups;
    }

    class University : Сertificate
    {
        protected string Title;
        protected string Adress;

        public void Fill(string Title, string Adress, uint AverageMark, uint NeedMark)    // полное заполнение 
        {
            this.Title = Title;
            this.Adress = Adress;
            this.AverageMark = AverageMark;
            this.NeedMark = NeedMark;
        }

        public void Inf()
        {
            Console.WriteLine("\nНазвание: {0} \t Адресс: {1} \t", Title, Adress);
            Console.WriteLine("Средний бал: {0}\t \nНужный бал: {1} \t", AverageMark, NeedMark);
        }
    }

    class Сertificate : Person, IPeopls, ISubjects
    {
        protected uint AverageMark = 0;
        protected uint NeedMark = 0;

        public enum Subjects
        {
            Math,
            Russian,
            Philosophy,
            MathematicalLogic
        }

        public void ShowSubjects()
        {
            Console.WriteLine("The Subjects are: ");
            for (Subjects toShow = Subjects.Math; toShow <= Subjects.MathematicalLogic; toShow++)
            {
                Console.WriteLine(toShow);
            }
            Console.WriteLine();
        }

        public struct Marks
        {
            private uint _MathMark;
            private uint _RussianMark;
            private uint _MathematicalLogicMark;
            private uint _PhilosophyMark;

            public Marks(uint MathMark, uint RussianMark, uint MathematicalLogicMark, uint PhilosophyMark)
            {
                _MathMark = MathMark;
                _RussianMark = RussianMark;
                _MathematicalLogicMark = MathematicalLogicMark;
                _PhilosophyMark = PhilosophyMark;
            }

            public uint MathMark
            {
                get => _MathMark;
            }

            public uint RussianMark
            {
                get => _RussianMark;
            }

            public uint MathematicalLogicMark
            {
                get => _MathematicalLogicMark;
            }

            public uint PhilosophyMark
            {
                get => _PhilosophyMark;
            }
        }

        public bool Available { get; set; }

        public Сertificate()
        {
            AverageMark = 0;
            NeedMark = 7;
        }
        ~Сertificate() { Console.WriteLine("Norm"); }

        public virtual void Nice() { Console.WriteLine("Nice!\a"); }

        public void AvMark()
        {
            if (AverageMark > 7) { Console.WriteLine("congratulations you are entered!\a"); }
            else if (AverageMark < 7) { Console.WriteLine("lucky next time)"); }
            else { Console.WriteLine("False"); }
        }

        public void Filling(string name, int age, uint AverageMark, uint NeedMark)
        {
            this.name = name;
            this.age = age;
            this.AverageMark = AverageMark;
            this.NeedMark = NeedMark;
        }

        public void Inf()
        {
            Console.WriteLine("Средний бал:{0}\t \n Нужный бал:{1}", AverageMark.ToString(), NeedMark.ToString());
        }               
    }

    abstract class Person : IComparable
    {
        protected string Name;
        protected int Age;

        public int CompareTo(object o)
        {
            Person p = o as Person;
            if (p != null)
                return this.Name.CompareTo(p.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public string name { set; get; }

        public int age
        {
            set
            {
                if (value < 16) Console.WriteLine("Не учится в Университете", value);
                else Age = value;
            }
            get
            {
                return Age;
            }
        }
    }
      
    class Student : Person
    {
        protected string Name;
        protected int Age;
        //-------- свойства класса ----------
        public string name { set; get; }
        public int age
        {
            set
            {
                if (value < 16) Console.WriteLine("Не учится в Университете", value);
                else Age = value;
            }
            get
            {
                return Age;
            }
        }

        protected string Speciality;
        protected int NumberGroup;
        protected int cost;
        protected static int counter = 0;

        public Student()
        {
            counter++;
        }

        public static int Counter
        {
            get
            {
                return counter;
            }
        }

        public double Payment()
        {
            if (Speciality == "ИиТП") { cost = 980; }
            else if (Speciality == "ПОИТ") { cost = 1000; }
            else if (Speciality == "ВМСиС") { cost = 800; }
            else if (Speciality == "Асои") { cost = 720; }
            else { cost = 0; }  
            return cost;
        }

        public void Filling(string name, int age, string Speciality, int Numbergroup)    // полное заполнение 
        {
            this.name = name;
            this.age = age;
            this.Speciality = Speciality;
            this.NumberGroup = Numbergroup;
        }

        public void Filling(string Speciality, int Numbergroup)  // перегруженный метод для сокр. заполнения
        {
            this.Speciality = Speciality;
            this.NumberGroup = Numbergroup;
        }

        public void Info()
        {
            double need = Payment();
            if (name != null && age != 0) Console.WriteLine("Имя: {0}\t \nВозраст: {1} \t", name, age.ToString());
            Console.WriteLine("Специальность: {0} \t Оплата: {1} \t Номер группы: {2}", Speciality, cost.ToString(), NumberGroup.ToString());
        }

        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;              // 1.Определение события

        public int Mark
        {
            set
            {
                if (value < 6) Console.WriteLine("could be better", value);
                else Mark = value;
            }
            get
            {
                return Mark;
            }
        }

        public void Acc(int Mark)
        {
            if (Mark < 6)
            {
                Notify?.Invoke($"could be better");   // 2.Вызов события
            }
            else
            {
                Notify?.Invoke($"It's ok");
            }
        }
              
    }

    class Program
    {
        delegate void Message(); 

        private static void Yes()
        {
            Console.WriteLine("You so young");
        }
        private static void No()
        {
            Console.WriteLine("Not now");
        }

        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
          
            Student student1 = new Student();
            student1.Filling("Koshuba", 25, "ПОИТ", 07);   //полный метод
            double pay = student1.Payment();//можно получить если поставить public в методе класса
            student1.Info();
            student1.age = 14;
            student1.Notify += DisplayMessage;
            student1.Acc(5);
            Console.WriteLine("Всего работников: {0}", Student.Counter.ToString());

            Message mes; 
            if (student1.age < 16)
            {
                mes = Yes; 
            }
            else
            {
                mes = No;
            }
            mes(); 

            University univ1 = new University();
            univ1.Fill("BSUIR", "st. Petrusya Brovka 6", 6, 7);
            univ1.Inf();
            univ1.AvMark();
            Console.WriteLine();

            Сertificate cert1 = new Сertificate();
            cert1.Filling("Novikov", 15, 7, 6);
            cert1.Inf();
            cert1.ShowSubjects();

            ISubjects sub = new Сertificate();
            sub.Exam(sub.Available);
            Console.WriteLine(sub.Available);

            IPeopls people = new Сertificate();
            Console.WriteLine("Peopls on Stream:");
            Console.WriteLine("People in groups:{0}", people.Amount(6, people.MaxPeople));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}