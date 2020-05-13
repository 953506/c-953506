using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Notes : Student
    {
        public Notes(string name, string lastname, int age, int stage)
        {
            this["name"] = name;
            this["lastname"] = lastname;
            this.Age = age;
            this.Stage = stage;
            examsNotes[0].Subject = "Foreigh language";
            examsNotes[1].Subject = "Highet Math";
            examsNotes[2].Subject = "Physical Culture";
            examsNotes[3].Subject = "Math Logic";

            SetNotes();
            SetRating();
        }
        public void Display()
        {
            base.Display();
            ShowNotes();
            Console.WriteLine("\nStudent {0}", this["lastname"]);
            Console.WriteLine("Rating (в %): {0}", Rating);
        }
    }
}
