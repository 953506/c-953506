using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Glock17 : Pistol
    {
        public Glock17() : base()
        {
            _name.bname = "Пистолет Glock 17";
            _name.lname = "пистолет Glock 17";
            _magazin = Convert.ToInt32(Magazin.GLOCK17);
        }
        public override void Razbor()
        {
            _pricel = false;
            if (_sobran)
            {
                if (_zaryad)
                {
                    Console.WriteLine($"{_name.bname} заряжен, разбирать запрещено!");
                    return;
                }
                Console.WriteLine("1)Нажимаем кнопку защёлки магазина и извлекаем его из рукоятки");
                Console.WriteLine("2)Опустив флажок выключаем предохранитель");
                _fuse = false;
                Console.WriteLine("3)Оттягиваем спусковую скобу вниз и, перекосив её в сторону, упераем в рамку");
                Console.WriteLine("4)Отводим затвор в крайнее заднее положение и, приподняв его заднюю часть, движением вперёд отделяем от рамки");
                Console.WriteLine("5)Возвращаем на место спусковую скобу");
                Console.WriteLine("6)Снимаем со ствола возвратную пружину");
                Console.WriteLine($"{_name.bname} разобран!");
                _sobran = false;
            }
            else
            {
                Console.WriteLine("1)Надеваем на ствол возвратную пружину");
                Console.WriteLine("2)Снимаем спусковую скобу");
                Console.WriteLine("3)Присоединяем затвор к рамке");
                Console.WriteLine("4)Оттягиваем спусковую скобу вниз и, перекосив её в сторону, упераем в рамку");
                Console.WriteLine("5)Включаем предохранитель");
                _fuse = true;
                Console.WriteLine("6)Нажимаем кнопку защёлки магазина и вставляем его в рукоятку");
                Console.WriteLine($"{_name.bname} собран!");
                _sobran = true;
            }
        }
        ~Glock17() { }
    }
}
