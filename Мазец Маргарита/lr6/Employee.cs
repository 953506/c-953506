using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Employee : UniversityPerson
    {
        public Employee(string name, string surname, string univer, int birthYear, string profession)
                   : base(name, surname, univer, birthYear) 
        {
            Profession = profession;
        }

        public string Profession { get; set; }
        public override void WriteCommonInformation()
        {
            Console.WriteLine($"Имя:{Name}");
            Console.WriteLine($"Фамилия:{SurName}");
            Console.WriteLine($"Возраст:{Age}");
        }

        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{University}");
            Console.WriteLine($"Должность:{Profession}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Помогите другим студентам! Введите информацию о себе:");
            ImportantInformation = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {
            Console.WriteLine($"Важная информация: {ImportantInformation}");
        }
    }
}
