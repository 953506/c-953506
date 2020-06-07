using System;

namespace ЛабораторнаяСШ5
{
    public struct Proverka
    {
        private int age;
        private int math;
        private int phis;
        private int rus;
        private int gpa;
        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("It's false, try again (age)");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Math
        {
            get { return math; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Console.WriteLine("It's false, try again(math)");
                }
                else
                {
                    math = value;
                }
            }
        }
        public int Phis
        {
            get {return phis; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Console.WriteLine("It's false, try again(phisics)");
                }
                else
                {
                    phis = value;
                }
            }
        }
        public int Rus
        {
            get {return rus; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Console.WriteLine("It's false, try again(rus)");
                }
                else
                {
                    rus = value;
                }
            }
        }
        public int Gpa
        {
            get { return gpa; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Console.WriteLine("It's false, try again(GPA)");
                }
                else
                {
                    gpa = value;
                }
            }
        }
    }
    
    public class Human
    {
        protected string name;
        protected string sname;
        public Proverka proverka;
        public enum Choise
        {
            Paid = 0,
            Free = 1,
        }

        public string SName { get { return sname; } }
        public string Name { get {  return name; } }
        public Human(string name, string sname)
        {
            this.name = name;
            this.sname = sname;
        }
        public static int VivodSum(int rus, int math, int phis, int gpa)
        {
            int sum = rus + math + phis + gpa;
            Console.WriteLine("Sum: " + sum);
            return sum;
        }
        public virtual void Univer(int sum, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (sum >= 100)
                    Console.WriteLine("Congratulations, you're on a free");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
            else if (educ == Choise.Paid)
            {
                if (sum <= 100)
                    Console.WriteLine("Congratulations, you're on a paid");
                if (sum == 0) Console.WriteLine("Sorry, maybe you want in other university");
            }
        }

    }
    
    class BGTU : Human
    {
        public BGTU(string name, string sname, int age, int gpa, int math, int phis, int rus) : base(name, sname)
        {
            proverka.Age = age;
            proverka.Math = math;
            proverka.Phis = phis;
            proverka.Rus = rus;
            proverka.Gpa = gpa;
        }
        public override void Univer(int sum, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (sum >= 200)
                    Console.WriteLine("Congratulations, you're on a free");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
            else if (educ == Choise.Paid)
            {
                if (sum >= 180)
                    Console.WriteLine("Congratulations, you're on a paid");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
        }
    }
    
     class BSU : Human
    {
        public BSU(string name, string sname, int age, int gpa, int math, int phis, int rus) : base(name, sname)
        {
            proverka.Age = age;
            proverka.Math = math;
            proverka.Phis = phis;
            proverka.Rus = rus;
            proverka.Gpa = gpa;
        }
        public override void Univer(int sum, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (sum >= 294)
                    Console.WriteLine("Congratulations, you're on a free");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
            else if (educ == Choise.Paid)
            {
                if (sum >= 231)
                    Console.WriteLine("Congratulations, you're on a paid");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
        }
    }
    
    class BSUIR : Human
    {
        public BSUIR(string name, string sname, int age, int gpa, int math, int phis, int rus) : base(name, sname)
        {
            proverka.Age = age;
            proverka.Math = math;
            proverka.Phis = phis;
            proverka.Rus = rus;
            proverka.Gpa = gpa;
        }
        public override void Univer(int sum, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (sum >= 295)
                    Console.WriteLine("Congratulations, you're on a free");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
            else if (educ == Choise.Paid)
            {
                if (sum >= 236)
                    Console.WriteLine("Congratulations, you're on a paid");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
        }
    }
   class BNTU : Human
    {
        public BNTU(string name, string sname, int age, int gpa, int math, int phis, int rus) : base(name, sname)
        {
            proverka.Age = age;
            proverka.Math = math;
            proverka.Phis = phis;
            proverka.Rus = rus;
            proverka.Gpa = gpa;
        }
        public override void Univer(int sum, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (sum >= 196)
                    Console.WriteLine("Congratulations, you're on a free");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
            else if (educ == Choise.Paid)
            {
                if (sum >= 138)
                    Console.WriteLine("Congratulations, you're on a paid");
                else Console.WriteLine("Sorry, maybe you want in other university");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many entrants do you want to enter ?");
            string n = Console.ReadLine();
            int N = int.Parse(n);
            Console.WriteLine("Enter data by an example:");
            Human entrans = new Human("Ivan", "Ivanov");
            Console.WriteLine(entrans.Name);
            Console.WriteLine(entrans.SName);
            Console.WriteLine("Age: 17");
            Console.WriteLine("Math: 1");
            Console.WriteLine("Phisics: 1");
            Console.WriteLine("Rus: 1");
            Console.WriteLine("GPA: 1");
           
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Surname: ");
                string sname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Math: ");
                int math = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Phis: ");
                int phis = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Rus: ");
                int rus = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Gpa: ");
                int gpa = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Choose\nBSUIR - 1\nBSU - 2\nBNTU - 3\nBGTU - 4");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Free(0)/Paid(1)?");
                int choise = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Human.Choise educ;
                educ = (Human.Choise)choise;
                switch (num)
                {
                    case 1:
                        {
                            entrans = new BSUIR(name, sname, age, gpa, math, phis, rus);
                            int sum1 = Human.VivodSum(gpa, math, phis, rus);
                            entrans.Univer(sum1, educ);
                            break;
                        }
                    case 2:
                        {
                            entrans = new BSU(name, sname, age, gpa, math, phis, rus);
                            int sum1 = Human.VivodSum(gpa, math, phis, rus);
                            entrans.Univer(sum1, educ);
                            break;
                        }
                    case 3:
                        {
                            entrans = new BNTU(name, sname, age, gpa, math, phis, rus);
                            int sum1 = Human.VivodSum(gpa, math, phis, rus);
                            entrans.Univer(sum1, educ);
                            break;
                        }
                    case 4:
                        {
                            entrans = new BGTU(name, sname, age, gpa, math, phis, rus);
                            int sum1 = Human.VivodSum(gpa, math, phis, rus);
                            entrans.Univer(sum1, educ);
                            break;
                        }
                }
            }
        }
    }
}
