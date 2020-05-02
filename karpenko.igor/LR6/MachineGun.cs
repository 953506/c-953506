using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class MachineGun : Firearm
    {
        protected int _turn, _localScore;
        protected enum Magazin
        {
            TAК21 = 30,
            M4A1 = 40,
            AK74 = 45,
            AUG = 50
        }
        public MachineGun() : base()
        {
            _turn = 0;
            _localScore = 0;
        }
        public override void Shot()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            Random rnd = new Random();
            if (_magazinNow == 0)
            {
                Console.WriteLine($"Кончились патроны!");
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
            if (_turn > 10)
            {
                Console.WriteLine("Время передернуть затвор");
                return;
            }
            for (int i = 0; i < _turn; i++)
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
            _turn++;
            _score += mishen;
            _localScore += mishen;
            if (_turn > 10) _pricel = false;
            _iznos += rnd.Next(1, 4);
            _magazinNow--;
        }
        public override void Zatvor()
        {
            if (_turn == 0) return;
            Result(_localScore / _turn);
            _localScore = 0;
            _turn = 0;
        }
        public override void Charac()
        {
            _pricel = false;
            Console.WriteLine($"{_name.bname} может стрелять до тех пор, пока не кончаться патроны");
            Console.WriteLine($"{_name.bname} стреляет очередью(макс 10 выстрелов). Чтобы закончить очередь, передерните затвор");
            Console.WriteLine("При большом износе точность снижается");
            Console.WriteLine($"На предохранителе {_name.lname} не стреляет");
            Console.WriteLine("Прицеливание увеличивает точность");
            Console.WriteLine("Прицеливание соханяется первые 3 выстрела очередью, потом точность снижается");
            Console.WriteLine("Прицеливание каждый раз сбивается, когда вы выбираете другое действие");
        }
        public override void Menu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("r - Ремонт");
            Console.WriteLine("t - Предохранитель");
            Console.WriteLine("f - Затвор");
            Console.WriteLine("g - Пополнить магазин");
            Console.WriteLine("h - Прицелиться");
            Console.WriteLine("y - Выстрел");
            if (_sobran) Console.WriteLine("k - Разборка оружия");
            else Console.WriteLine("k - Сборка оружия");
            Console.WriteLine("j - Информация об оружии");
        }
        ~MachineGun() { }
    }
}
