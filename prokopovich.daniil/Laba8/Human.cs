using System;

namespace Lab6
{
    abstract class Human : IPlayable, IEquatable<Human>
    {
        //Структура
        protected struct FIO
        {
            public string name, surname;
        }

        //Поля
        protected int age;
        protected string disease, gender;
        protected bool isIll, isDead;
        protected FIO fio;
        protected uint salary;
        public static int birth_year;
        
        //Конструкторы
        public Human()
        {
            age = 2020 - birth_year;
            isIll = false;
            isDead = false;
        }

        public Human(string name, string surname) : this()
        {
            fio.name = name;
            fio.surname = surname;
        }

        public Human(string name, string surname, string gender) : this(name, surname)
        {
            if (gender == "male" || gender == "female")
                this.gender = gender;
        }

        //Свойства
        public abstract string Category { get; set; }

        public string Name
        {
            get
            {
                return fio.name;
            }
            set
            {
                fio.name = value;
            }
        }

        public int Age
        {
            get
            {
                return 2020 - birth_year;
            }
        }

        public string Surname
        {
            get
            {
                return fio.surname;
            }
            set
            {
                fio.surname = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
        }

        public bool IsDead
        {
            get
            {
                return isDead;
            }
        }

        public string Disease
        {
            get
            {
                if (isIll) return disease;
                return $"{fio.name} is not ill";
            }
            set
            {
                isIll = true;
                disease = value;
            }
        }

        public uint Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        
        //Методы
        public virtual void Bounce() { } //для класса Footballer
        public virtual void Score() { } //для класса Basketballer
        public virtual void ChopWatermelon() { } //для класса eSportsman

        public virtual void ShowInfo()
        {
            Console.WriteLine($"name - {fio.name}");
            Console.WriteLine($"surname - {fio.surname}");
            Console.WriteLine($"gender - {gender}");
            Console.WriteLine($"age - {age}");
            Console.WriteLine($"disease - {Disease}");
            if (isDead)
                Console.WriteLine($"DEAD status - dead (use Die to resurrect)");
            else
                Console.WriteLine($"DEAD status - alive");
        }

        public virtual void Die()
        {
            isDead = true;
        }

        public virtual void Resurrect()
        {
            isDead = false;
            isIll = false;
        }

        public void ChangeGender()
        {
            gender = (gender == "male") ? "female" : "male";
        }

        public void Sing()
        {
            if (isDead || isIll)
                Console.WriteLine($"{fio.name} is not currently able for singing. Create another object or resurrect.");
            else
                Console.WriteLine($"{fio.name} sings : WHAT IS LOVE! BABY DONT HURT ME!");
            Console.ReadKey();
        }

        public bool Equals(Human other)
        {
            if (other == null)
                return false;
            if (this.Name == other.Name && this.Surname == other.Surname)
                return true;
            else
                return false;
        }

        //Заглушки для IPlayable в наследуемых классах
        public void Play(){}

        public int DefinePrise(bool result)
        { return 0;}
        //Деструктор
        ~Human() { }
    }
}
