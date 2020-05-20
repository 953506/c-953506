using System;
using System.Collections.Generic;
using System.Text;

namespace lr6
{
    class Rector:Employee
    {
        public Rector(string name, string surname, string univer, int birthYear, string profession)
                  : base(name, surname, univer, birthYear, profession ){}

        public override void WriteUniversityInformation()
        {
            Console.WriteLine($"Университет:{University}");
            Console.WriteLine($"Звание:{Profession}");
        }
    }
}
