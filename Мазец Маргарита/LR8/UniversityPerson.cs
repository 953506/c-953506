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
            #region проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым или null", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentNullException("Фамилия не может быть пустой или null", nameof(surname));
            }
            if (string.IsNullOrWhiteSpace(univer))
            {
                throw new ArgumentNullException("Университет не может быть пустым или null", nameof(univer));
            }
            if (birthYear<1920 && birthYear>currentYear)
            {
                throw new ArgumentNullException("Непозволимый год рождения", nameof(birthYear));
            }
            #endregion

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
