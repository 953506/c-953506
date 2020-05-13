﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    class Student:Human
    {
        public void Display()
        {
            Console.WriteLine("{0} {1} (age {2} years), student {3} course", this["lastname"], this["name"], Age, Stage);
            ShowNotes();
            Console.WriteLine("\nStudent {0}", this["lastname"]);
            Console.WriteLine("Rating (в %): {0}", Rating);
        }
        public void SetRating()
        {
            float sum = 0;
            for (int i = 0; i < numexams; i++)
            {
                sum += examsNotes[i].Note;
            }
            this.Rating = sum / numexams * 10;
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
}
