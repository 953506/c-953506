﻿using System;

namespace ЛР5
{
    abstract class UniversityPerson
    {
        public struct NS
        {
            public string _name;
            public string _surname;
        }
        
        public NS _ns;
        public string _university;
        public static int _currentYear = 2020;
        public int _birthYear;

        public UniversityPerson(string name, string surname,string univer, int birthYear)
        {
            _ns._name = name;
            _ns._surname = surname;
            _university = univer;
            _birthYear = birthYear;
        }
        
        public abstract void WriteCommonInformatoin();
        public abstract void WriteUniversityInformation();
    };
    
    class Employee : UniversityPerson
    {
        private string  _importantInformation;
        
        public Employee(string name, string surname, string univer, int birthYear)
                   : base(name, surname, univer, birthYear) { }
                   
        public override void WriteCommonInformatoin()
        {
            Console.WriteLine($"Имя:{_ns._name}");
            Console.WriteLine($"Фамилия:{_ns._surname}");
            Console.WriteLine($"Возраст:{_currentYear - _birthYear}");
        }
        
        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{_university}");
        }

        public virtual void EnterImportantInformation()
        {
            _importantInformation = Console.ReadLine();
        }
        
        public virtual void WriteImportantInformation()
        {
            Console.WriteLine($"Важная информация: {_importantInformation}");
        }
    };
    
    class Teacher : Employee
    {
        private string _classes, _academicRanc, _importantScientificInformation, __importantPersonalInformation;
        
        public Teacher(string name, string surname, string univer, int birthYear,string classes,string aсademicRanc)
                : base(name, surname, univer, birthYear)
        {
            _classes = classes;
            _academicRanc = aсademicRanc;
        }
        
        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{_university}");
            Console.WriteLine($"Предмет преподавания:{_classes}");
            Console.WriteLine($"Учёное звание:{_academicRanc}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Введите важную информацию о научной деятельности преподавателя");
            _importantScientificInformation  = Console.ReadLine();
            Console.WriteLine("Помоги другим студентам. Проинформируй о характере и фишках ");
            __importantPersonalInformation = Console.ReadLine();
        }
        
        public override void WriteImportantInformation()
        {
            Console.WriteLine($"Информация о научной деятельности преподавателя: {_importantScientificInformation}");
            Console.WriteLine($"Информация о характере и особенностях: {__importantPersonalInformation}");

        }
    };
    
    class ImportantPerson : Employee 
    {
        private string _status;
        
        public ImportantPerson(string name, string surname, string univer, int birthYear, string status)
                : base(name, surname, univer, birthYear)
        {
            _status = status;
        }
       
        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{_university}");
            Console.WriteLine($"Звание:{_status}");
        }
    };
    
    class Student : UniversityPerson
    {
        private string _specialty;
        private int _course;
        private double _scholarship;
        
        public Student(string name, string surname, string university, int birthYear,string specialty,int course) 
            : base(name, surname,university,birthYear)
        {
            _specialty = specialty;
            _course = course;
        }
        
        public double MiddleMark { get; set; }
        
        public override void WriteCommonInformatoin()
        {
            Console.WriteLine($"Имя:{_ns._name}");
            Console.WriteLine($"Фамилия:{_ns._surname}");
            Console.WriteLine($"Возраст:{_currentYear - _birthYear}");
        }
        
        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{_university}");
            Console.WriteLine($"Специальность:{_specialty}");
            Console.WriteLine($"Курс:{_course}");
        }
       
        public void WriteRaitingsAndScholarship()
        {
            Console.WriteLine($"Средний балл:{MiddleMark}");
            if (MiddleMark <= 4.0)
                _scholarship = 0.0;
            if (MiddleMark >= 4.0 && MiddleMark <= 6.0)
                _scholarship = 40.35;
            if (MiddleMark >= 6.0 && MiddleMark <= 8.0)
                _scholarship = 62.29;
            if (MiddleMark >= 8.0 && MiddleMark <= 9.0)
                _scholarship = 89.35;
            if (MiddleMark >= 9.0 && MiddleMark <= 10.0)
                _scholarship = 100.0;
            Console.WriteLine($"Степендия:{_scholarship}");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Student student = new Student("Влад", "Демьянов", "БГУИР", 2001, "ИиТП", 1);
            Teacher teacher = new Teacher("Иван", "Прокопьев", "БГУИР", 1982, "Программирование", "Доцент");
            ImportantPerson  rector = new ImportantPerson("Валерий", "Денько", "БГУИР", 1978, "ректор");        
            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("1-вывести информацтю о студенте");
                Console.WriteLine("2-проставить средний балл");
                Console.WriteLine("3-вывести информацию о преподавателе");
                Console.WriteLine("4-внести важную информацию о преподавателе");
                Console.WriteLine("5-вывести  информацию о ректоре");
                Console.WriteLine("6-внести важную инвормацию о ректоре");
                Console.WriteLine("7-завершить программу");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            Console.Clear();
                            student.WriteCommonInformatoin();
                            student.WriteUniversityInformation();
                            student.WriteRaitingsAndScholarship();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите средний балл:");
                            student.MiddleMark = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            teacher.WriteCommonInformatoin ();
                            teacher.WriteUniversityInformation();
                            teacher.WriteImportantInformation();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            teacher.EnterImportantInformation();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            rector.WriteCommonInformatoin();
                            rector.WriteUniversityInformation();
                            rector.WriteImportantInformation();
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            rector.EnterImportantInformation ();
                            break;
                        }
                    case 7: return;
                    default:return;   
                }
            }
        }
    }
}

