using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class AK74 : MachineGun
    {
        public AK74() : base()
        {
            _name.bname = "АК-74";
            _name.lname = "АК-74";
            _magazin = Convert.ToInt32(Magazin.AK74);
        }
        public override void Razbor()
        {
            if (_sobran)
            {
                Console.WriteLine("1)Отделить магазин.");
                Console.WriteLine("2)Проверить, нет ли патрона в патроннике.");        
                Console.WriteLine("3)Вынуть пенал с принадлежностями.");
                Console.WriteLine("4)Отделить шомпол.");
                Console.WriteLine("5)Отделить дульный тормоз-компенсатор.");
                Console.WriteLine("6)Отделить крышку ствольной коробки.");
                Console.WriteLine("7)Отделить возвратный механизм.");
                Console.WriteLine("8)Отделить затворную раму с затвором.");
                Console.WriteLine("9)Отделить затвор от затворной рамы.");
                Console.WriteLine("10)Отделить газовую трубку со ствольной накладкой.");
                Console.WriteLine($"{_name.bname} разобран!");
                _sobran = false;
            }
            else
            {
                Console.WriteLine("1)Присоединить газовую трубку со ствольной накладкой.");
                Console.WriteLine("2)Присоединить затвор к затворной раме.");
                Console.WriteLine("3)Присоединить затворную раму с затвором к ствольной коробке.");
                Console.WriteLine("4)Присоединить возвратный механизм. ");
                Console.WriteLine("5)Присоединить крышку ствольной коробки.");
                Console.WriteLine("6)Спустить курок с боевого взвода и поставить на предохранитель.");
                Console.WriteLine("7)Присоединить дульный тормоз-компенсатор. ");
                Console.WriteLine("8)Присоединить шомпол.");
                Console.WriteLine("9)Вложить пенал в гнездо приклада. ");
                Console.WriteLine($"{_name.bname} собран!");
                _sobran = true;
            }
        }
        ~AK74() { }
    }
}
