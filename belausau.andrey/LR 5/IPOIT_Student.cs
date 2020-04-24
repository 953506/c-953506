using System;

namespace pudge
{
    sealed class IPOIT_Student : BSUIR_Student
    {
        //Конструктор
        public IPOIT_Student(string name, string surname, string gender) : base(name, surname, gender)
        {
            _faculty = "FCP";
            _specialty = "IPOIT";
            _group += "1100";
            _curator = "Best FCP curator";
        }

        //Методы
        public override void GoToArmy()
        {
            Console.WriteLine($"{_fio.name} went to the army");
            _faculty = _specialty = null;
            _group = "54'th motorized rifle division";
            _curator = "Lieutenant Zhamoidzik";
            _fio.name = "Dnevalnyi";
            Console.ReadKey();
        }
    }
}
