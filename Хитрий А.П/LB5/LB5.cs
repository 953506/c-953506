using System;
using static System.Console;
using System.Windows.Forms;

class LB5
{
   static void Main()
    {
        ConsoleKeyInfo key;
        Programmer Class = new Programmer();
        while(true)
        {
            Clear();
            Programmer.Menu();
            switch ((key = ReadKey(true)).Key)
            {
                case ConsoleKey.D0: return;
                case ConsoleKey.D1: Class.WriteLine("Нажмите любую клавишу, чтобы продолжить...");  ReadKey(true); break;
                case ConsoleKey.D2: Class.Cout(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D3: Class.WriteString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D4: Class.ChangeString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D5: Class.ImportantDates(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D6: Class.AddComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D7: Class.DeletComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D8: Class.ExtraInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D9: Class.ClarifyInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
            }
        }
    }
}
