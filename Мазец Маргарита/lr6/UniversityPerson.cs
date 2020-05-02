using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    abstract class UniversityPerson:IUniversityPerson
    {
        public static int currentYear=2020;

        public UniversityPerson(string name, string surname, string univer, int birthYear)
        {
            Name = name;
            SurName = surname;
            University = univer;
            Age = currentYear - birthYear;
        }

        public string Name { get; }
        public string SurName { get; }
        public string University { get; set; }
        public int Age { get; }
        public string ImportantInformation { get; set; }

        public abstract void WriteCommonInformation();
        public abstract void WriteUniversityInformation();
        public abstract void EnterImportantInformation();
        public abstract void WriteImportantInformation();
    }
}
