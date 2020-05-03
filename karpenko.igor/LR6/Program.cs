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
            IFirearm def = new Colt();            
            Firearm.Score = 0;
            do
            {
                Console.Clear();
                def.Default();
                Console.WriteLine("Выберите оружие:\n");
                for (int j = 0; j < 3; j++)
                Console.WriteLine($"{j + 1}){fa[j].BName}\n");
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
                    Console.WriteLine("q - Сравнить вместимоть магазина c другим оружием");
                    ch = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (ch)
                    {
                        case 'f':
                            if (fa[i].BName == "АК-74") fa[i].Zatvor();
                            else fa[i].Zaryad();
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
                        case 'q':
                            Array.Sort(fa);
                            for (int j = 0; j < 3; j++)
                            {
                                Console.WriteLine($"{fa[j].BName} - {fa[j].Magazin}");
                            }
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
