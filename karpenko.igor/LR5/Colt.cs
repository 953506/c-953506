﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Colt : Pistol
    {
        public Colt() : base() 
        {
            _name.bname = "Револьвер Colt";
            _name.lname = "револьвер Colt";
            _magazin = Convert.ToInt32(Magazin.COLT);
        }
        public override void Razbor()
        {
            if (_sobran)
            {
                _pricel = false;
                if (_zaryad)
                {
                    Console.WriteLine($"{_name.bname} заряжен, разбирать запрещено!");
                    return;
                }

                Console.WriteLine("1)Убедившись, что револьвер не заряжен, ставим курок на предохранительный полувзвод,\n при этом барабан немного отойдет от ствола в более свободное положение и разблокируются фиксаторы его вращения.");
                _fuse = true;
                Console.WriteLine("2)Выдавливаем соединительный клин с правой стороны казенной части ствола,\n налево (он останется выдвинутым, удерживаемым стопорным винтом, чтобы не потерялся).");        
                Console.WriteLine("3)Провернем барабан на пол-каморы относительно ствола, затем уперев рычаг зарядного\n пресса в перемычку между двумя каморами, аккуратно нажимаем рычаг – ствол при этом легко отделится от рамки.");
                Console.WriteLine("4)Снимаем барабан.");
                Console.WriteLine("5)С помощью специального ниппельного ключа, выкручиваем все ниппели (брандтрубки) из барабана");
                Console.WriteLine("6)Выкручиваем сначала 2 винта по бокам от курка на задней поверхности рамки,\n а затем 1 винт снизу в металлической окантовке рукоятки – и снимаем рукоятку.");
                Console.WriteLine($"{_name.bname} разобран!");
                _sobran = false;
            }
            else
            {
                Console.WriteLine("1)Ниппеля должны быть на момент сборки полностью сухими,\n в идеале их можно посадить на медную смазку.");
                Console.WriteLine("2)Курок перед сборкой обязательно ставим на полувзвод.");
                Console.WriteLine("3)Установливаем барабан на ось револьвера.");
                Console.WriteLine("4)Установливаем на свое место ствол с зарядным прессом.");
                Console.WriteLine("5)Самый ответственный шаг – фиксация ствола соединительным клином, с его помощью,\n можно регулировать зазор между стволом и барабаном.");
                Console.WriteLine($"Выставляя зазор нужно знать, что у {_name.lname} – еще задолго до нагана,\n появился механизм надвигания барабана на ствол (правда без охвата ствола каморой) – поэтому финальный зазор нужно контролировать не на полувзводе,\n а на полностью взведенном курке.");
                Console.WriteLine("Нажимаем кнопку защёлки магазина и вставляем его в рукоятку");
                Console.WriteLine($"{_name.bname} собран!");
                _sobran = true;
            }
        }
        ~Colt() { }
    }
}
