using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Student : UniversityPerson, IStudent, ICloneable
    {
        public Student(string name, string surname, string university, int birthYear, string specialty, int yearOfReceipt)
            : base(name, surname, university, birthYear)
        {
            Specialty = specialty;
            Course = currentYear-yearOfReceipt;
        }

        public string Specialty { get; set; }
        public double MiddleMark { get; set; }
        public int Course { get; }

        public override void WriteCommonInformation()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Фамилия:{SurName}");
            Console.WriteLine($"Возраст:{Age}");
        }

        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{University}");
            Console.WriteLine($"Специальность:{Specialty}");
            Console.WriteLine($"Курс:{Course}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Введите достижения студента:");
            ImportantInformation = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {
            Console.WriteLine($"Достижения:{ImportantInformation}");
        }

        public void AcademicPerformance()
        {
            Console.WriteLine($"Средний балл:{MiddleMark}");
            if (AdmittedToExams())
                Console.WriteLine("Студент допущен к экзаменам");
            else
                Console.WriteLine("Студент не допущен к экзаменам");
        }

        private bool AdmittedToExams()
        {
            if (MiddleMark > 4.0)
                return true;
            else
                return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
