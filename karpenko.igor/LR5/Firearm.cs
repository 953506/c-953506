using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    abstract class Firearm
    {
        protected struct Name
        {
            public string lname;
            public string bname;
        }
        protected int _magazin;
        protected int _magazinNow;
        protected int _iznos;
        protected static int _score;
        protected Name _name;
        protected bool _pricel;
        protected bool _fuse;
        protected bool _sobran;

        public static int Score
        {
            get => _score;
            set => _score = value;
        }
        public Firearm()
        {
            _iznos = 0;
            _magazinNow = 0;
            _pricel = false;
            _sobran = true;
            _fuse = true;

        }
        public abstract void Shot();
        public abstract void Charac();
        public abstract void Menu();
        public virtual void Razbor() { }
        public virtual void Zaryad() { }
        public virtual void Zatvor() { }

        public void Perezaryad()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            _pricel = false;
            if (_magazinNow == _magazin) Console.WriteLine("Магазин и так уже полон");
            else
            {
                _magazinNow = _magazin;
                Console.WriteLine("Обойма вновь полна патронами!");
            }
        }
        protected void Result(int m)
        {
            if (m == 10) Console.WriteLine("Отличный выстрел, в самое яблочко(10)!");
            else if (m > 6 && m < 10) Console.WriteLine($"Хороший выстел, попали в {m}");
            else if (m > 3 && m < 7) Console.WriteLine($"Неплохо, попали в {m}");
            else if (m > 0 && m < 4) Console.WriteLine($"Можно было и лучше, попали в {m}");
            else if (m == 0) Console.WriteLine($"В молоко!");

        }
        public void Pricel()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            _pricel = true;
            Console.WriteLine($"Вы навели {_name.lname} на мишень...");
        }
        public void Fuse()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            _pricel = false;
            if (_fuse)
            {
                _fuse = false;
                Console.WriteLine($"{_name.bname} снят с предоханителя!");
            }
            else
            {
                _fuse = true;
                Console.WriteLine($"{_name.bname} поставлен на предохранитель!");
            }
        }
        public void Remont()
        {
            if (!_sobran)
            {
                Console.WriteLine($"{_name.bname} разобран!");
                return;
            }
            _pricel = false;
            if (_iznos < 60)
            {
                Console.WriteLine($"Износ еще приемемый, {_name.lname} можно починить только с 60% износа");
            }
            else
            {
                _iznos = 0;
                Console.WriteLine($"Ваш {_name.lname} успешно отремонтирован");
            }

        }
        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"Оружие:{_name.lname}\t\tПатронов в магазине:{_magazinNow}\t\tИзнос:{_iznos}%");
        }

        ~Firearm() { }      
    }
}
