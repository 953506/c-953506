using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    abstract class Person
    {

        string _name;
        string _surname;
        protected int _birthYear;
        protected string _gender;
        public int YearOfBirth
        {
            get
            {
                return _birthYear;
            }
            set
            {
                _birthYear = value;
            }
        }
        public string this[string SN]
        {
            get
            {
                switch (SN)
                {
                    case "name": return _name;
                    case "surname": return _surname;
                    default: return null;
                }
            }
            set
            {
                switch (SN)
                {
                    case "name":
                        _name = value;
                        break;
                    case "surname":
                        _surname = value;
                        break;
                }
            }
        }
        public Person(string name, string surname, int birthYear, string gender)
        {
            _name = name;
            _surname = surname;
            _birthYear = birthYear;
            _gender = gender;
        }
       public virtual void ShowInfo()
        {
            Console.WriteLine($"{_name} {_surname}, gender:{_gender}, year of birth: {YearOfBirth} ");
        }

    }
}
