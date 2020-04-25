using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int i;
            bool pist = true;
            Firearm[] fa = new Firearm[3];
            fa[0] = new Glock17();
            fa[1] = new Colt();
            fa[2] = new AK74();
            Firearm.Score = 0;
            do
            {            
                Console.Clear();
                Console.WriteLine("Выберите оружие:\n");
                Console.WriteLine("1)Glock 17\n2)Colt\n3)AK-74");               
                i = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.Clear();
                if (i < 0 || i > 2)
               {
                   Console.WriteLine("Что-то не так, попробуйте ввести еще раз!");
                    continue;
               }
                pist = true;
                do
                {
                    fa[i].Info();
                    Console.WriteLine($"Набранные вами очки: {Firearm.Score}");
                    fa[i].Menu();
                    Console.WriteLine();
                    Console.WriteLine("e - Сменить оружие");
                    Console.WriteLine("p - Выход со стрельбища");
                    ch = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (ch)
                    {
                        case 'f':
                            if(i == 2) fa[i].Zatvor();
                            else  fa[i].Zaryad();
                            break;
                        case 'r':
                            fa[i].Remont();
                            break;
                        case 't':
                            fa[i].Fuse();
                            break;
                        case 'g':
                            fa[i].Perezaryad();
                            break;
                        case 'h':
                            fa[i].Pricel();
                            break;
                        case 'y':
                            fa[i].Shot();
                            break;
                        case 'j':
                            fa[i].Charac();
                            break;
                        case 'k':
                            fa[i].Razbor();
                            break;
                        case 'p':
                            return;                           
                        case 'e':
                            pist = false;
                            break;
                        default:
                            Console.WriteLine("Такого действия нет(Нажмите любую клавишу для продолжения)");
                            Console.ReadKey();
                            break;
                    }
                } while (pist); 
            } while (true);
        }
    }
}
