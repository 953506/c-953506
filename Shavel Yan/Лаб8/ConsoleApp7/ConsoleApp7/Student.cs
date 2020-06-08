using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student : Person, IComparable<Student>
    {
        private int _id;
        private double _midmarks;
        private int _course;
        private string _speciality;

        delegate void Delegate(string message);
        event Delegate Notify;

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
                Notify?.Invoke("Enter mark");
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
        public Student(string name, string surname, int ID, int birthYear, int course, string gender, string speciality, string paysornot) : base(name, surname, birthYear, gender)
        {
            this.PaysOrNot = paysornot;
            this.ID = ID;
            this.Course = course;
            this.Speciality = speciality;
            SetMarks();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Notify?.Invoke($"Student  course: {Course}");
            Notify?.Invoke($"Student speciality: {Speciality}  ");
            Notify?.Invoke($"Mid marks: {MidMarks}");
        }
        public int CompareTo(Student two)
        {
            return this.MidMarks.CompareTo(two.MidMarks);
        }
        public override void Complain()
        {
            Notify?.Invoke("Just a student");
        }
    }
}
