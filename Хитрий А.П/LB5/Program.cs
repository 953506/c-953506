uusing System;
using static System.Console;

class Program
{
    static void Menu()
    {
        WriteLine(" 0 - выход\n 1 - пересоздать класс\n 2 - вывод общий\n 3 - вывести построчно\n 4 - ввести построчно\n 5 - Важные данные\n" +
            " 6 - Добавить уточняющую информацию\n 7 - Удалить уточняющую информацию\n 8 - дополнительная информация\n 9 - уточняющая информация");
    }
   static void Main()
    {
        Programmer a = new Programmer();
        while(true)
        {
            Clear();
            Menu();
            switch (ReadKey(true).Key)
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
