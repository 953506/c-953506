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
            //numexams = 4;
            examsNotes[0].Subject = "Иностранный язык";
            examsNotes[1].Subject = "ВышМат";
            examsNotes[2].Subject = "Физкультура";
            examsNotes[3].Subject = "Математическая логика";

            SetNotes();
            SetRating();
        }
        public void Display()
        {
            base.Display();
            ShowNotes();
            Console.WriteLine("\nСтудент {0}", this["lastname"]);
            Console.WriteLine("Рейтинг (в %): {0}", Rating);
        }
    }
}
