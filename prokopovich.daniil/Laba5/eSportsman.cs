using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    sealed class eSportsman : Sportsman
    {
        //Конструктор
        public eSportsman(string name, string surname, string gender) : base(name, surname, gender)
        {
            _category = "eSportsman";
            _coach = "Mikhaylo 'Kane' Blagin";
        }

        //Методы
        public override void ChopWatermelon()
        {
            Console.WriteLine($"{_fio.name} trying to chop a watermelon, but doesn't succeed.");
            Console.ReadKey();
        }
    }
}
