using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{

    delegate bool HandlerKey(int key);

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
              
        public event HandlerKey ToAsk; //событие

        //------------ Методы
        public override void GetInfo()
        {
            Console.WriteLine($"{Name} {Surname}"); ;
            Console.WriteLine("Возраст:{0}", Age);
            Console.WriteLine("Навыки:{0}", _skill);
            Console.WriteLine("Собственная подсобка:{0}", _storeroom); 
            Console.WriteLine("Настроение:{0}", _spirits);
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
            if (thing.Length == 0)
                throw new ArgumentOutOfRangeException() ;                                   //генерируем исключительную ситуацию
            if (ToAsk == null)
                throw new ArgumentNullException();
            if (!ToAsk(key))
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
