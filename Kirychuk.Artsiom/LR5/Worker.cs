using System;
using System.Collections.Generic;
using System.Text;

namespace laba5
{
    class Worker: Kindergarten
    {
        private int _skill;
        private bool _storeroom;

        //------------ Конструктор
        public Worker(string name, string surname, int age, int skill, bool storeroom, int atHome)
            :base(name,surname,age)
        {
            _skill = skill;
            _storeroom = storeroom;
            _timok.atHome = atHome;
        }

        //------------ Методы
        public override void GetInfo()
        {
            Console.WriteLine($"{_name} {_surname}"); ;
            Console.WriteLine("Возраст:{0}", _age);
            Console.WriteLine("Навыки:{0}", _skill);
            Console.WriteLine("Собственная подсобка:{0}", _storeroom); 
            Console.WriteLine("Настроение:{0}", _spirits);
        }

        public override void KnowHealth()
        {
            if (_timok.atHome >= 15)
                Console.WriteLine("Лучше некуда!");
            else Console.WriteLine("Нога после кульбита болит");            
        }

        public void Riddle()
        {
            Console.WriteLine("Сколько будет 10 раз по 100 грамм?");
            Console.WriteLine("1.Килограмм");
            Console.WriteLine("2.Литр");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (choice == 1) Console.WriteLine("Правильно.Держи кофетку!");
            else Console.WriteLine(")))))))");
        }

        public bool  Fix (string thing, int key)
        {
            if (key != 12 && key != 13)
            {
                Console.WriteLine("Ключ не подошёл!На этом мои полномочия всё");
                return false;
            }
            else
            {
                Console.WriteLine("3 секунды и {0} работает как часы", thing);
                return true;
            }
        }
    }
}
