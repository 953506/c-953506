using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Student : UniversityPerson, IStudent, ICloneable
    {
        public delegate void StudentHandler(string mes);
        public event StudentHandler Notify;

        public Student(string name, string surname, string university, int birthYear, string specialty, int yearOfReceipt)
            : base(name, surname, university, birthYear)
        {
            #region
            if (string.IsNullOrWhiteSpace(specialty))
            {
                throw new ArgumentNullException("Специальность не может быть пустой или null", nameof(specialty));
            }
            if (yearOfReceipt<1950 && yearOfReceipt>currentYear)
            {
                throw new ArgumentNullException($"Год поступления не может быть меньше 1950 и больше {currentYear}", nameof(yearOfReceipt));
            }
            #endregion

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
                Notify?.Invoke("Студент допущен к экзаменам");
            else
                Notify?.Invoke("Студент не допущен к экзаменам");
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
