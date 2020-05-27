using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    sealed class Vmsis:Abiturient
    {
        private int _course;
        //конструктор 
        public Vmsis() : base()
        {
            Console.WriteLine("Write course");
            Kurs = int.Parse(Console.ReadLine());
            Status = "Vmsis student";
        }
        public override string Status
        {
            get => base.Status;
            set
            {
                _current_status = value;
            }
        }
        enum Semesetr
        {
            First = 12,
            Second = 10,
            Thirst = 9,
            Fourth = 8
        }
        public override int Kurs
        {
            set
            {
                if (value > 0 && value < 5)
                {
                    _course = value;
                }
                else
                {
                    Console.WriteLine("Write normal number from 1 to 4");
                    Console.ReadKey();
                }
            }

        }
        public override void SemPredm()
        {
            switch (_course)
            {
                case 1: Console.WriteLine($"You have {(int)Semesetr.First} subjects"); break;
                case 2: Console.WriteLine($"You have {(int)Semesetr.Second} subjects"); break;
                case 3: Console.WriteLine($"You have {(int)Semesetr.Thirst} subjects"); break;
                case 4: Console.WriteLine($"You have {(int)Semesetr.Fourth} subjects"); break;
                default: Console.WriteLine("Write normal course"); return;
            }

        }
        public override void Vivod()
        {
            Console.WriteLine($"FIO:{_surname} {_name } {_patronymic}");
            Console.WriteLine($"Age: {_age}");
            Console.WriteLine($"Current status:{Status}");
            Console.WriteLine($"Your course:{_course}");
            Console.WriteLine($"Your ct balli:{Balli}");
            Console.WriteLine($"Current army status:{_army}");
        }
        public override void Vivod(string status)
        {
            Status = status;
            Console.WriteLine($"FIO:{_surname} {_name } {_patronymic}");
            Console.WriteLine($"age: {_age}");
            Console.WriteLine($"Current status:{Status}");
            Console.WriteLine($"Your course:{_course}");
            Console.WriteLine($"Current army status:{_army}");
        }
        public override void Menu()
        {
            Console.WriteLine("1) Show inforamiton");
            Console.WriteLine("2) Show info with new status");
            Console.WriteLine("3) Show your subjects");
            Console.WriteLine("4) Change course");
            Console.WriteLine("5) Show human info");
            Console.WriteLine("0) Exit");
        }

    }
}
