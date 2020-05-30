using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    //------------ Перечисление 
    enum Toy
    {
        Bear,
        Elephant,
        Car,
        Fairy,
        Constructor,
    }

     delegate bool MarkHandler(int choice);


    class Child : Kindergarten
    {
        private Toy _bauble; 
        private bool _satiety;

        //------------ Конструктор
        public Child(string name, string surname, int age, Toy bauble, double intGatren)
        : base(name, surname, age)
        {
            _bauble = bauble;
            _timok.inGarten = intGatren;
        }

        //------------ Свойство
        public bool Satiety
        {
            get
            {
                return _satiety;
            }
            set
            {
                _satiety = value;
            }
        }

        // Событие       
        public event MarkHandler GetMark;
      
        //------------ Методы
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}"); ;
            Console.WriteLine("Возраст:{0}", Age);
            Console.WriteLine("Любимая игрушка:{0}", _bauble);
            Console.WriteLine("Время проведённое в саду(часов):{0}", _timok.inGarten);
            Console.WriteLine("Cытый:{0}", _satiety);
            Console.WriteLine("Настроение:{0}", _spirits);
        }    
        
        public override void KnowHealth()
        {
            if (_timok.inGarten <= 3)
                Console.WriteLine("Всё отлично!");
            else if (_satiety)
                Console.WriteLine("Хорошо, но болит животик");
            else Console.WriteLine("Пойду на горшок(");
        }

        public void Spirits(bool satiety)
        {
            if (satiety && _timok.inGarten <= 3)
                _spirits = Mood.Great;
            else if (satiety && _timok.inGarten <= 5)
                _spirits = Mood.Good;
            else if (satiety)
                _spirits = Mood.Normal;
            else if (!satiety && _timok.inGarten >= 5)
                _spirits = Mood.SoSo;
            else if (!satiety && _timok.inGarten >= 7)
                _spirits = Mood.Bad;
            else _spirits = Mood.Normal;
            _satiety = satiety;
            Console.WriteLine("Настроение:{0}", _spirits);
        }

        public void Addiction()
        {
            if (_bauble == Toy.Bear || _bauble == Toy.Elephant)
                Console.WriteLine("Будущий врач!");
            if (_bauble == Toy.Constructor || _bauble == Toy.Car)
                Console.WriteLine("Будущий инженер!");
            if (_bauble == Toy.Fairy)
                Console.WriteLine("Если это мальчик, то родителям стоит задуматься");
        } 
        
        public void EnglishLesson( )
        {          
            Console.WriteLine("choose an extra word" +
                "\n1.Pelican" +
                "\n2.Owl" +
                "\n3.Bear");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice <= 0||choice>3)
                throw new ArgumentOutOfRangeException();                    //генерируем исключительную ситуацию
            GetMark?.Invoke(choice);
        }
    }
}
