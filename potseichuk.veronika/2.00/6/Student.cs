using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class Student : Human, IComparable<Student>
    {
        private const int numexams = 4;
        public Exams[] examsNotes = new Exams[numexams];
        private int _stage;
        private float _rating;

        public float Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }

        public int Stage
        {
            get
            { return _stage; }
            set
            {
                if (value < 1) _stage = 1;
                else if (value > 5) _stage = 5;
                else _stage = value;
            }
        }

        public Student(string name, string lastname, int age, int stage) : base(name, lastname, age)
        {
            this.Stage = stage;

            examsNotes[0].Subject = "Foreign language";
            examsNotes[1].Subject = "Higher math";
            examsNotes[2].Subject = "Physical culture";
            examsNotes[3].Subject = "Math logic";

            SetNotes();
            SetRating();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Student {0} stage",  Stage);
            ShowNotes();
            Console.WriteLine("Rating (in %): {0}", Rating);
        }
        public void SetRating()
        {
            float sum = SumRating();
            this.Rating = sum / numexams * 10;
        }
        private float SumRating()
        {
            float sum = 0;
            for (int i = 0; i < numexams; i++)
            {
                sum += examsNotes[i].Note;
            }
            return sum;
        }

        public void SetNotes()
        {
            for (int i = 0; i < numexams; i++)
            {
                Console.Write("{0}: ", examsNotes[i].Subject);
                examsNotes[i].Note = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void ShowNotes()
        {
            for (int i = 0; i < numexams; i++)
            {
                Console.WriteLine("{0}: {1};", examsNotes[i].Subject, examsNotes[i].Note);
            }
        }
        public int CompareTo(Student two)
        {
            return this.Rating.CompareTo(two.Rating);
        }

        public override void Complain()
        {
            base.Complain();
            Console.WriteLine("Session is soon(");
        }
    }

    struct Exams
    {
        string subject;
        int note;
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }
        public int Note
        {
            get
            { return note; }
            set
            {
                if (value < 1) note = 1;
                else if (value > 10) note = 10;
                else note = value;
            }
        }
    }
}
