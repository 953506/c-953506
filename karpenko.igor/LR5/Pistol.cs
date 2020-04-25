using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Pistol : Firearm
    {
        protected bool _zaryad;

        public Pistol() : base()
        {
            _zaryad = false;
        }
        protected enum Magazin
        {
            COLT = 6,
            M1911 = 8,
            MARK23 = 15,
            GLOCK17 = 17
        }
        public override void Zaryad()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            _pricel = false;
            if (_magazinNow == 0)
            {
                Console.WriteLine("В магазине нет патронов");
            }
            else if (_zaryad) Console.WriteLine($"Вы уже зарядили {_name.lname}");
            else
            {
                _zaryad = true;
                Console.WriteLine($"{_name.bname} заряжен!");
            }
        }
        public override void Shot()
        {
            if(!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            Random rnd = new Random();

            if (_zaryad == false)
            {
                Console.WriteLine($"Для начала {_name.lname} нужно зарядить!");
                return;
            }
            if (_fuse == true)
            {
                Console.WriteLine("Снимите с предохранителя!");
                return;
            }
            if (_iznos > 95)
            {
                Console.WriteLine($"{_name.bname} поломан и не может стрелять");
                return;
            }
            Console.Write("БАНГ! ");
            int mishen = 0;

            if (_pricel == true)
            {
                if (_iznos < 15)
                {
                    mishen = rnd.Next(8, 11);
                }
                else if (_iznos < 30)
                {
                    mishen = rnd.Next(7, 9);
                }
                else if (_iznos < 50)
                {
                    mishen = rnd.Next(5, 8);
                }
                else if (_iznos < 70)
                {
                    mishen = rnd.Next(4, 7);
                }
                else if (_iznos < 85)
                {
                    mishen = rnd.Next(3, 5);
                }
                else
                {
                    mishen = rnd.Next(0, 3);
                }
            }
            else
            {
                if (_iznos < 15)
                {
                    mishen = rnd.Next(7, 9);
                }
                else if (_iznos < 30)
                {
                    mishen = rnd.Next(5, 8);
                }
                else if (_iznos < 50)
                {
                    mishen = rnd.Next(3, 6);
                }
                else if (_iznos < 70)
                {
                    mishen = rnd.Next(1, 5);
                }
                else if (_iznos < 85)
                {
                    mishen = rnd.Next(0, 2);
                }
                else
                {
                    mishen = 0;
                }
            }
            Result(mishen);
            _score += mishen;
            _zaryad = false;
            _pricel = false;
            _iznos += rnd.Next(3, 6);
            _magazinNow--;       
        }
        public override void Charac()
        {
            _pricel = false;
            Console.WriteLine($"Перед каждым выстрелом {_name.lname} нужно заряжать");
            Console.WriteLine("При большом износе точность снижается");
            Console.WriteLine($"На предохранителе {_name.lname} не стреляет");
            Console.WriteLine("Прицеливание увеличивает точность");
            Console.WriteLine("Прицеливание каждый раз сбивается, когда вы выбираете другое действие");
        }
        public override void Menu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("f - Зарядить");
            Console.WriteLine("r - Ремонт");
            Console.WriteLine("t - Предохранитель");
            Console.WriteLine("g - Пополнить магазин");
            Console.WriteLine("h - Прицелиться");
            Console.WriteLine("y - Выстрел");
            if (_sobran) Console.WriteLine("k - Разборка оружия");
            else Console.WriteLine("k - Сборка оружия");
            Console.WriteLine("j - Информация об оружии");
        }
        ~Pistol() { }
    }
}
