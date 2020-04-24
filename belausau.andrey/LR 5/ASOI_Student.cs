using System;

namespace pudge
{
    sealed class ASOI_Student : BSUIR_Student
    {
        //Конструктор
        public ASOI_Student(string name, string surname, string gender) : base(name, surname, gender)
        {
            _faculty = "FITU";
            _specialty = "ASOI";
            _group += "3228";
            _curator = "Best FITU curator";
        }

        //Методы
        public override void DrinkBeer()
        {
            Console.WriteLine($"{_fio.name} drank some beer");
            Random x = new Random();

            if(x.Next() % 3 == 0)
            {
                Console.WriteLine($"{_fio.name} had eaten and fell asleep.\n{_fio.name} died");
                Die();
            }
            Console.ReadKey();
        }
    }
}
