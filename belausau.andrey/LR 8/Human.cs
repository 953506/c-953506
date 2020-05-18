using System;

namespace Pudge
{
    class Human : IHuman
    {
        protected string name, surname, gender, disease;
        protected bool isIll, isDead;
        protected int age;

        public delegate void ShowInfoHandler();

        //Конструктор
        public Human()
        {
            disease = "none";
            isDead = isIll = false;
            age = 0;
        }

        public Human(string name, string surname, string gender, int birthYear) : this()
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = 2020 - birthYear;
        }

        //Свойства
        public string Name 
        { 
            get => name; 
        }

        public string SurName 
        { 
            get => surname; 
        }

        public string Gender
        {
            get => gender;
            set => gender = value; 
        }

        public string GetDisease
        { 
            get => disease; 
        }

        public bool IsDead 
        {
            get => isDead; 
        }

        public bool IsIll 
        {
            get => isIll; 
        }

        public int Age 
        { 
            get => age;
        }

        //Методы
        public virtual void GetInfo()
        {
            Console.WriteLine($"Name - {name}");
            Console.WriteLine($"Surname - {surname}");
            Console.WriteLine($"Gender - {gender}");
            Console.Write("Dead status - ");
            Console.WriteLine((isDead) ? "dead" : "alive");
            Console.WriteLine($"Illness - {disease}");
            Console.WriteLine($"Age - {age}");
        }
        public void Die()
        {
            isDead = true;
        }

        public void Resurrect()
        {
            isDead = isIll = false;
        }

        public void BecomeIll(string illnessName)
        {
            disease = illnessName;
            isIll = true;
        }
    }
}
