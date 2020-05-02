using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    class Class1
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(int i);
        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        public void Funk()
        {
            Console.WriteLine("DA");
        }
        public void Ifer(int i)
        {
            int count = 0;
            switch (i)
            {
                //стрелочки
                case 37: Console.Write("Left "); break;
                case 38: Console.Write("Up "); break;
                case 39: Console.Write("Right "); break;
                case 40: Console.Write("Down "); break;
                //над стрелками
                case 8: Console.Write("Backspace "); break;
                case 10: Console.Write("Enter "); break;
                case 36: Console.Write("Home "); break;
                case 35: Console.Write("End "); break;
                case 33: Console.Write("PageUp "); break;
                case 34: Console.Write("PageDown "); break;
                case 44: Console.Write("SysRQ "); break;
                case 45: Console.Write("Insert "); break;
                case 46: Console.Write("Delete "); break;
                //F
                case 27: Console.Write("Esc "); break;
                case 112: Console.Write("F1 "); break;
                case 113: Console.Write("F2 "); break;
                case 114: Console.Write("F3 "); break;
                case 115: Console.Write("F4 "); break;
                case 116: Console.Write("F5 "); break;
                case 117: Console.Write("F6 "); break;
                case 118: Console.Write("F7 "); break;
                case 119: Console.Write("F8 "); break;
                case 120: Console.Write("F9 "); break;
                case 121: Console.Write("F10 "); break;
                case 122: Console.Write("F11 "); break;
                case 123: Console.Write("F12 "); break;
                case 145: Console.Write("ScrollLock "); break; //не работает
                case 19: Console.Write("PauseBreak "); break; //не работает
                case 192: Console.Write("` "); break;
                //нижняя часть
                case 162: Console.Write("LeftCtrl "); break; //не работает
                case 163: Console.Write("RightCtrl "); break; //не работает
                case 164: Console.Write("LeftAlt "); break; //не работает
                case 165: Console.Write("RightAlt "); break; //не работает
                case 91: Console.Write("Win "); break;
                case 32: Console.Write("Space "); break;
                case 18: Console.Write("Alt "); break;
                //Num
                case 106: Console.Write("* "); break;
                case 107: Console.Write("+ "); break;
                case 109: Console.Write("- "); break;
                case 111: Console.Write("/ "); break;
                case 110: Console.Write(". "); break;
                //остальные
                case 9: Console.Write("Tab "); break;
                case 16: Console.Write("Shift "); break;
                case 219: Console.Write("[ "); break;
                case 221: Console.Write("] "); break;
                case 190: Console.Write(". "); break;
                case 188: Console.Write(", "); break;
                case 220: Console.Write(@"\ "); break;
                case 222: Console.Write("' "); break;
                case 186: Console.Write("; "); break;
                case 191: Console.Write("/ "); break;

                default:
                    {
                        if ((i >= 48 && i <= 57) || (i >= 96 && i <= 105) || (i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
                        {
                            if (GetKeyState(20) == 1)
                            {
                                if (count == 0)
                                {
                                    Console.Write("CapsLock(on) ");  
                                    count = 1;
                                }
                                else
                                {
                                    count = 0;
                                }
                            }

                                if ((i >= 48 && i <= 57))
                            {
                                Console.Write(i - 48 + " ");
                            }
                            else
                            {
                                if (i >= 96 && i <= 105)
                                {
                                    Console.Write(i - 96 + " ");
                                }
                                else
                                {
                                    if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z') && count == 1)
                                    {
                                        Console.Write((char)i + " ");
                                    }
                                    else
                                    {
                                        Console.Write((char)(i + 32) + " ");
                                    }

                                }
                            }
                        }
                        else
                        {
                            Console.Write("Unknown Key");
                        }
                    }

                    break;
            }
        }

        public void Shift(int i)
        {
            Console.Write("Shift ");
            if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
            {
                Console.Write((char)i + " ");
            }
            else
            {
                if (i >= 48 && i <= 57)
                {
                    switch (i)
                    {
                        case 48: Console.Write(") "); break;
                        case 49: Console.Write("! "); break;
                        case 50: Console.Write("@ "); break;
                        case 51: Console.Write("# "); break;
                        case 52: Console.Write("$ "); break;
                        case 53: Console.Write("% "); break;
                        case 54: Console.Write("^ "); break;
                        case 55: Console.Write("& "); break;
                        case 56: Console.Write("* "); break;
                        case 57: Console.Write("( "); break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 219: Console.Write("{ "); break;
                        case 221: Console.Write("} "); break;
                        case 190: Console.Write("> "); break;
                        case 188: Console.Write("< "); break;
                        case 191: Console.Write("? "); break;//не работает
                        case 222: Console.Write(" \" "); break;
                        case 186: Console.Write(": "); break;
                        case 220: Console.Write("/ "); break;
                    }
                    Ifer(i);
                }
            }
        }

    }
}

       
