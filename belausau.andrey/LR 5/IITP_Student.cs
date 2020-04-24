using System;

namespace pudge
{
    sealed class IITP_Student : BSUIR_Student
    {
        //Конструктор
        public IITP_Student(string name, string surname, string gender) : base(name, surname, gender){
            _faculty = "KSIS";
            _specialty = "IITP";
            _group += "5350";
            _curator = "Ani$$imov Uladzimir Jakovlevich";
        }

        //Методы
        public override void UseGoto()
        {
            Console.WriteLine($"{_fio.name} used goto...");
            Die();
            Console.ReadKey();
        }
    }
}
