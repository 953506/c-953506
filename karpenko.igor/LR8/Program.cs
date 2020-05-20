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
            Firearm.InfoHandler handler1 = delegate (string mes) { Console.WriteLine($"{mes}"); };
            Firearm.InfoHandler handler2 = mes => Console.WriteLine($"{mes}");
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
                handler1("Выберите оружие:\n");
                for (int j = 0; j < 3; j++)
                handler2($"{j + 1}){fa[j].BName}\n");
                string vyb = Console.ReadLine();
                try
                {
                    if (!Int32.TryParse(vyb, out i))
                        throw new Exception("Похоже, что это не число");
                    i -= 1;
                    Console.Clear();
                    if (i < 0)
                        throw new Exception("Вы ввели слишком маленкое число");
                    if (i > 2)
                        throw new Exception("Вы ввели слишком большое число");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}, попробуйте ввести еще раз!(для продолжения нажмите любую клавишу)");
                    Console.ReadKey();
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
                    fa[i].Act += PrintMessage;
                    try
                    {
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
                                fa[i].Act -= PrintMessage;
                                fa[i].Act += handler2;       
                                fa[i].Fuse();
                                fa[i].Act -= handler2;
                                break;
                            case 'g':
                                fa[i].Perezaryad();
                                break;
                            case 'h':
                                fa[i].Act -= PrintMessage;
                                fa[i].Act += handler1;
                                fa[i].Pricel();
                                fa[i].Act -= handler1;
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
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{ex.Message}");
                    }
                    finally
                    {
                        fa[i].Act -= PrintMessage;
                    }
                } while (pist);

            } while (true);
        }
        static void PrintMessage(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
