using System;

namespace Pudge
{
    class Human : IHuman
    {
        //Конструктор
        public Human()
        {
            IsDead = IsIll = false;
            GetDisease = "none";
        }

        public Human(string name, string surname, string gender, int birthYear) : base()
        {
            Name = name;
            SurName = surname;
            Gender = gender;
            Age = 2020 - birthYear;
        }

        //Свойства
        public string Name { get; set; }

        public string SurName { get; set; }

        public string Gender { get; set; }

        public string GetDisease { get; protected set; }

        public bool IsDead { get; protected set; }

        public bool IsIll { get; protected set; }
        
        public int Age { get; }

        //Методы
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name - {Name}");
            Console.WriteLine($"Surname - {SurName}");
            Console.WriteLine($"Gender - {Gender}");
            Console.Write("Dead status - ");
            Console.WriteLine((IsDead) ? "dead" : "alive");
            Console.WriteLine($"Illness - {GetDisease}");
            Console.WriteLine($"Age - {Age}");
        }
        public void Die()
        {
            IsDead = true;
        }

        public void Resurrect()
        {
            IsDead = IsIll = false;
        }

        public void BecomeIll(string illnessName)
        {
            GetDisease = illnessName;
            IsIll = true;
        }
    }
}
