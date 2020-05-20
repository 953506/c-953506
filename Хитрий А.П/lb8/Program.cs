using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
class Program
{
    public delegate void NullTest();
    public static event NullTest NullResult;
    
    static void Menu()
    {
        WriteLine(" 0 - выход\n 1 - создать класс\n 2 - вывод общий\n 3 - вывести построчно\n 4 - ввести построчно\n 5 - Важные данные\n" +
            " 6 - Добавить уточняющую информацию\n 7 - Удалить уточняющую информацию\n 8 - дополнительная информация\n 9 - уточняющая информация\n" +
            " Q - сравнить класс и шаблонный класс на похожесть данных Только о человеке(не о работе) \n W - обнулить рабочие строки \n" +
            " E - обнулить строки о программировании \n R - сделать класс нулевым");
    }
    static void Main()
    {
        Programmer a = null;
        NullTest Farther = delegate { WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); };
        NullResult = delegate { Clear(); WriteLine("Класс не имеет объекта"); Farther(); };
        while (true)
        {
            Clear();
            Menu();
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D0: return;
                case ConsoleKey.D1: Programmer.Creat(a); break;
                case ConsoleKey.D2: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).Cout(); Farther(); break;
                case ConsoleKey.D3: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).WriteString(); Farther(); break;
                case ConsoleKey.D4: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).ChangeString(); Farther(); break;
                case ConsoleKey.D5: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).ImportantDates(); Farther(); break;
                case ConsoleKey.D6: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).AddComment(); Farther(); break;
                case ConsoleKey.D7: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).DeletComment(); Farther(); break;
                case ConsoleKey.D8: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).ExtraInfo(); Farther(); break;
                case ConsoleKey.D9: if (a == null) { NullResult?.Invoke(); break; } ((IProgrammer)a).ClarifyInfo(); Farther(); break;
                case ConsoleKey.Q:  if (a == null) { NullResult?.Invoke(); break; } ITransform<Programmer>.Comparison(a, new Programmer()); Farther(); break;
                case ConsoleKey.W:  if (a == null) { NullResult?.Invoke(); break; } ITransform<Programmer>.ChangeWork(a); Farther(); break;
                case ConsoleKey.E:  if (a == null) { NullResult?.Invoke(); break; } ITransform<Programmer>.ChangeProg(a); Farther(); ReadKey(true); break;
                case ConsoleKey.R:  Programmer.DeletClass(a); Farther(); break;
            }
        }
    }
}
