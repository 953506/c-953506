using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace lab_3
{
    class Student
    {
        protected Exams[] examsNotes = new Exams[numexams];

        float _rating;
        public const int numexams = 4;
        string _name;
        string _lastname;
        int _age;
        int _stage;

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

        public int Age
        {
            get
            { return _age; }
            set
            {
                if (value > 35) _age = 35;
                else if (value < 17) _age = 17;
                else _age = value;
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

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return _name;
                    case "lastname": return _lastname;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        _name = value;
                        break;
                    case "lastname":
                        _lastname = value;
                        break;
                }
            }
        }

        public Student(string name, string lastname, int age, int stage)
        {
            this["name"] = name;
            this["lastname"] = lastname;
            this.Age = age;
            this.Stage = stage;
            //numexams = 4;
            examsNotes[0].Subject = "Foreigh language";
            examsNotes[1].Subject = "Highet Math";
            examsNotes[2].Subject = "Physical Culture";
            examsNotes[3].Subject = "Math Logic";

            SetNotes();
            SetRating();
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} (возраст {2} лет), студент {3} курса", this["lastname"], this["name"], Age, Stage);
            ShowNotes();
            Console.WriteLine("\nСтудент {0}", this["lastname"]);
            Console.WriteLine("Рейтинг (в %): {0}", Rating);
        }
        public void SetRating()
        {
            float sum = 0;
            for (int i = 0; i < numexams; i++)
            {
                sum += examsNotes[i].Note;
            }
            this.Rating =  sum / numexams * 10;
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
