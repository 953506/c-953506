using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    abstract class Person : IComplainable
    {
        bool _inArmy;
        bool _isStudent=true;
        string _paysornot;
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
                    case "lastname":
                        _surname = value;
                        break;
                }
            }
        }
        public string PaysOrNot
        {
            get
            {
                return _paysornot;
            }
            set
            {
                _paysornot = value;
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
            Console.WriteLine($"{_name} {_surname}, gender:{_gender}, year of birth: {YearOfBirth}. Is student:{_isStudent}. In army:{_inArmy}");
        }
        public virtual void Complain()
        {
        }
        public delegate void Expelling(string message);
        public event Expelling Notify;

       public void Expelle()
        {
            Notify?.Invoke($"{_name} {_surname} was expelled");
            _isStudent = false;
        }

        public delegate void GoToArmyh(string message);
        public event GoToArmyh ArmyNotify;
        public void GoToArmy()
        {
            ArmyNotify?.Invoke("+1 recruit");
            _inArmy = true;
            _isStudent = false;
        }
        public void Restore()
        {
            Notify?.Invoke($"{_name} {_surname} was restored");
            _isStudent = true;
            _inArmy = false;
        }
    }
}
