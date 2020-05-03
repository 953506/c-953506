using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    sealed class Basketballer : Sportsman
    {
        //Конструктор
        public Basketballer(string name, string surname, string gender) : base(name, surname, gender)
        {
            _category = "Basketballer";
            _coach = "Michael Jordan";
        }

        //Методы
        public override void Score()
        {
            Console.WriteLine($"{_fio.name} scored a three-pointer. Wow!");
            Console.ReadKey();
        }
    }
}
