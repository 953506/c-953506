using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Teacher : Employee, ITeacher
    {
        public delegate void EvalutionHandler(string mes);
        public event EvalutionHandler Notify;

        public Teacher(string name, string surname, string univer, int birthYear,string profession, string classes, string aсademicRanc)
                : base(name, surname, univer, birthYear, profession)
        {
            #region проверка условий
            if (string.IsNullOrWhiteSpace(aсademicRanc))
            {
                throw new ArgumentNullException("Научное звание не может быть пустым или null", nameof(aсademicRanc));
            }
            if (string.IsNullOrWhiteSpace(classes))
            {
                throw new ArgumentNullException("Предмет преподавния не может быть пустым или null", nameof(classes));
            }
            #endregion

            Classes = classes;
            AcademicRang = aсademicRanc;
        }

        public string Classes { get; set; }
        public string AcademicRang { get; set; }
        public string ImportantScientificInformation { get; set;}
        public string ImportantPersonalInformation { get; set;}

        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{University}");
            Console.WriteLine($"Должность:{Profession}");
            Console.WriteLine($"Предмет преподавания:{Classes}");
            Console.WriteLine($"Учёное звание:{AcademicRang}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Введите важную информацию о научной деятельности");
            ImportantScientificInformation = Console.ReadLine();
            Console.WriteLine("Помоги другим студентам. Проинформируй о характере и фишках ");
            ImportantPersonalInformation = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {
            Console.WriteLine($"Информация о научной деятельности преподавателя: {ImportantScientificInformation}");
            Console.WriteLine($"Информация о характере и особенностях: {ImportantPersonalInformation}");

        }
        public void PutAnAverageMark(Student student)
        {
            Console.WriteLine("Введите средний балл:");
            double middle;
            try
            {
                Double.TryParse(Console.ReadLine(), out middle );
                if (middle <= 0 || middle>10)
                    throw new Exception("You've entered invalid data!");

                student.MiddleMark = middle;
                Notify?.Invoke($"Студенту {student.Name} {student.SurName} выставлены оценки");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
