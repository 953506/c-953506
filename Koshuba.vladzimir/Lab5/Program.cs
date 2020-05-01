using System;

namespace _5._1
{
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

    class Сertificate : Person
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

        public Сertificate()
        {
            AverageMark = 0;
            NeedMark = 7;
        }
        ~Сertificate() { Console.WriteLine("Norm"); }

        //method
        public virtual void Nice() { Console.WriteLine("Nice!\a"); }
        public void AvMark()
        {
            if (AverageMark > 7) { Console.WriteLine("congratulations you are entered!\a"); }
            else if (AverageMark < 7) { Console.WriteLine("lucky next time)"); }
            else { Console.WriteLine("False"); }
        }

    }

    abstract class Person
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
    }

    class Student : Person
    {
        protected string Speciality;
        protected int NumberGroup;
        protected int cost;
        //статическиt св-ва класса -  подсчет количества  Student
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
            else { cost = 0; }    //не учишься в BSUIR(
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Filling("Koshuba", 25, "ПОИТ", 07);   //полный метод
            double pay = student1.Payment(); //можно получить если поставить public в методе класса
            student1.Info();
            

            Student student2 = new Student();
            student2.Filling("\tВМСиС", 02);   //Сокращенный перегруженный метод
            student2.Info();
            Console.WriteLine();

            Student student3 = new Student();
            student3.Filling("ИиТП", 06);   // Сокращенный перегруженный метод
            student3.name = "Novikov";   // + свойства
            student3.age = 17;
            student3.Info();
            Console.WriteLine();
            
            Console.WriteLine("Всего работников: {0}", Student.Counter.ToString());

            University univ1 = new University();
            univ1.Fill("BSUIR", "st. Petrusya Brovka 6",6,7);
            univ1.Inf();
            univ1.AvMark();
            Console.WriteLine();
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}