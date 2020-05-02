using System;
using System.Collections.Generic;
using System.Text;

namespace Chelovek
{
    sealed class Footballer : Sportsman
    {
        //Конструктор
        public Footballer(string name, string surname, string gender) : base(name, surname, gender)
        {
            _category = "Footballer";
            _coach = "Zinedine Zidane";
        }

        //Методы
        public override void Bounce()
        {
            Console.WriteLine($"{_fio.name} bouncing the ball.");
            Console.ReadKey();
        }
    }
}
