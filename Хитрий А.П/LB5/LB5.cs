using System;
using static System.Console;
using System.Windows.Forms;

class LB5
{
   static void Main()
    {
        ConsoleKeyInfo key;
        Programmer a = new Programmer();
        while(true)
        {
            Clear();
            a.Menu();
            switch ((key = ReadKey(true)).Key)
            {
                case ConsoleKey.D0: return;
                case ConsoleKey.D1: a.Creat(a);WriteLine("Нажмите любую клавишу, чтобы продолжить...");  ReadKey(true); break;
                case ConsoleKey.D2: a.Cout(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D3: a.WriteString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D4: a.ChangeString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D5: a.ImportantDates(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D6: a.AddComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D7: a.DeletComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D8: a.ExtraInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D9: a.ClarifyInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
            }
        }
    }
}
