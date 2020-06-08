using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student : Person, IComparable<Student>, IComplainable
    {
        private int _id;
        private double _midmarks;
        private int _course;
        private string _speciality;

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string Speciality
        {
            get
            {
                return _speciality;
            }
            set
            {
                _speciality = value;
            }
        }
        public double MidMarks
        {
            get
            {
                return _midmarks;
            }
            set
            {
                _midmarks = value;
            }
        }
        public int Course
        {
            get
            { return _course; }
            set
            {
                _course = value;
            }
        }
        public double Marks()
        {
            int mark;
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter mark");
                mark = Convert.ToInt32(Console.ReadLine());
                sum += mark;
            }
            return sum;
        }
        public void SetMarks()
        {
            double sum = Marks();
            this.MidMarks = sum / 5;
        }
        public static Student Create(bool budget, string name, string surname, int ID, int birthYear, int course, string gender, string speciality, string paysornot)
        {
            if (budget) return new BudgetStudent(name, surname, ID, birthYear, course, gender, speciality, paysornot);
            return new PStudent(name, surname, ID, birthYear, course, gender, speciality, paysornot);
        }
        public Student(string name, string surname, int ID, int birthYear, int course, string gender, string speciality, string paysornot) : base(name, surname, birthYear, gender)
        {
            PaysOrNot = paysornot;
            this.ID = ID;
            Course = course;
            Speciality = speciality;
            SetMarks();
        }
        
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Student  course: {Course}");
            Console.WriteLine($"Student speciality: {Speciality} ");
            Console.WriteLine($"Mid marks: {MidMarks}");
        }
        public int CompareTo(Student two)
        {
            return this.MidMarks.CompareTo(two.MidMarks);
        }
        public override void Complain()
        {
            Console.WriteLine("Just a student");
        }
    }
}
