using System;

namespace laba3
{
    class Human
    {
        
        public enum _Gender 
        { 
            male,
            female,
            indefined
        }

        private DateTime _dateOfDeath;
        private DateTime _dateOfBirth;
        private DateTime _age;
        private int _height;
        private int _weight;
        private string _name;
        private String _surname;
        private string _nationality;
        private int _id;
        private _Gender _gender;
        private bool _isLife;
        private static int id = 0;

        public Human()
        {
            _isLife = false;
            _age = new DateTime();
            _dateOfBirth = new DateTime();
            _height = 0;
            _weight = 0;
            _name = "-";
            _surname = "-";
            _nationality = "-";
            _id = id;
            id++;
            _dateOfDeath = new DateTime();
            _gender = _Gender.indefined;
        }

        public Human(string name, string surname, int height, int weight, string nationality, _Gender gender, int day, int month, int year, int dayOfDeath, int monthOfDeath, int yearOfDeath) 
        {
            _name = name;
            _surname = surname; 
            _height = height;
            _weight = weight;
            _nationality = nationality;
            _dateOfBirth = new DateTime(year, month, day);
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, yearOfDeath);
            _gender = gender;
            _age = _dateOfDeath;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _isLife = false;
            _id = id;
            id++;
        }

        public Human(string name, string surname, int height, int weight, string nationality, _Gender gender, int day, int month, int year)
        {
            _name = name;
            _surname = surname;
            _height = height;
            _weight = weight;
            _nationality = nationality;
            _gender = gender;
            _dateOfBirth = new DateTime(year, month, day);
            _dateOfDeath = new DateTime();
            _age = DateTime.Now;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _isLife = true;
            _id = id;
            id++;
        }

        public Human(string name, string surname, string nationality) 
        {
            _name = name;
            _surname = surname;
            _nationality = nationality;
            _isLife = true;
            _age = new DateTime();
            _dateOfBirth = new DateTime();
            _dateOfDeath = new DateTime();
            _height = 0;
            _weight = 0;
            _id = id;
            id++;
            _gender = _Gender.indefined;
        }

        public Human(string name, string surname, string nationality, _Gender gender, int day, int month, int year)
        {
            _name = name;
            _surname = surname;
            _nationality = nationality;
            _gender = gender;
            _dateOfBirth = new DateTime(year, month, day);
            _isLife = true;
            _height = 0;
            _weight = 0;
            _id = id;
            id++;
            _age = DateTime.Now;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _dateOfDeath = new DateTime(); 
        }

        public DateTime DateOfDeath
        {

            get 
            {
                return _dateOfDeath;
            }

            set 
            {
                _dateOfDeath = value;
            }
        }

        public DateTime DateOfBirth
        {

            get
            {
                return _dateOfBirth;
            }

            set
            {
                _dateOfBirth = value;
            }
        }

        public int Weight
        {

            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public int Height
        {

            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public string Name
        {

            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Surname
        {

            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }

        public string Nationality
        {

            get
            {
                return _nationality;
            }

            set
            {
                _nationality = value;
            }
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public _Gender Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public int Age
        { 
            get
            {
                return _age.Year-1;
            }
        }

        public void getInfo()
        {
            if(_isLife)
                Console.WriteLine(@$"
        Имя: {_name}
        Фамилия: {_surname}
        Национальность:{_nationality}
        Дата рождения: {Convert.ToString(_dateOfBirth)}
        Возраст: {Convert.ToString(Age-1)} лет
        Рост: {Convert.ToString(_height)}
        Вес: {Convert.ToString(_weight)}
        Пол: {Convert.ToString(_gender)}
        id: {_id}");
            
            else
                    Console.WriteLine(@$"
        Имя: {_name}
        Фамилия: {_surname}
        Национальность:{_nationality}
        Дата рождения: {Convert.ToString(_dateOfBirth)}
        Дата смерти: {Convert.ToString(_dateOfDeath)}
        Возраст: {Convert.ToString(Age-1)} лет
        Рост: {Convert.ToString(_height)}
        Вес: {Convert.ToString(_weight)}
        Пол: {Convert.ToString(_gender)}
        id: {_id}");
        }

        public void setInfo(int day, int month, int year, int height, int weight, string name, string surname, string nationality, int dayOfDeath, int monthOfDeath, int yearOfDeath)
        {
            _dateOfBirth = new DateTime(year, month, day);
            _height = height;
            _weight = weight;
            _name = name;
            _surname = surname;
            _nationality = nationality;
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, yearOfDeath);
            _age = _dateOfDeath;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _isLife = false;
        }

        public void setInfo(string name, string surname, int height, int weight, string nationality, _Gender gender, int day, int month, int year)
        {
            _dateOfBirth = new DateTime(year, month, day);
            _height = height;
            _weight = weight;
            _name = name;
            _surname = surname;
            _nationality = nationality;
            _age = DateTime.Now;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _isLife = true;
            _gender = gender;
        }

        public void Death(int dayOfDeath, int monthOfDeath, int yearOfDeath) 
        {
            _isLife = false;
            _dateOfDeath = new DateTime(yearOfDeath, monthOfDeath, yearOfDeath);
            _age = _dateOfDeath;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            
        }

        public void Resurrection()
        {
            Console.WriteLine("ДА ЭТО ЖЕ САМ ИИСУС");
            _name = "Иисус";
            _surname = "Хрстос";
            _nationality = "Еврей";
            _dateOfBirth = new DateTime(1, 1, 7);
            _dateOfDeath = new DateTime(34, 4, 29);
            _age = _dateOfDeath;
            _age.AddDays(-_dateOfBirth.Day);
            _age.AddMonths(-_dateOfBirth.Month);
            _age.AddYears(-_dateOfBirth.Year+1);
            _height = 182;
            _weight = 79;
            _gender = _Gender.male;
        }

        public string this[int index] 
        { 
            get
            {
                if (_isLife)
                    switch (index) 
                    {
                        case 0: return _name;
                        case 1: return _surname;
                        case 2: return _nationality;
                        case 3: return Convert.ToString(_gender);
                        case 4: return _dateOfBirth.ToString();
                        case 5: return Convert.ToString(_height);
                        case 6: return Convert.ToString(_weight);
                        case 7: return Convert.ToString(_age.Year);
                        case 8: return Convert.ToString(_id);
                        default: return "null";
                    }
                else
                    switch (index)
                    {
                        case 0: return _name; 
                        case 1: return _surname;
                        case 2: return _nationality;
                        case 3: return Convert.ToString(_gender);
                        case 4: return _dateOfBirth.ToString();
                        case 5: return Convert.ToString(_height);
                        case 6: return Convert.ToString(_weight);
                        case 7: return Convert.ToString(_age.Year);
                        case 8: return Convert.ToString(_id);
                        case 9: return _dateOfDeath.ToString();
                        default: return "null";
                    }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Resurrection();
            human.getInfo();
        }
    }
}