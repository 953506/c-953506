using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    abstract class Human
    {
        public const int numexams = 4;
        protected Exams[] examsNotes = new Exams[numexams];
        string _name;
        string _lastname;
        int _age;
        int _stage;
        float _rating;

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

