using System;
using static System.Console;
class Program
{
    static void Menu()
    {
        WriteLine(" 0 - выход\n 1 - пересоздать класс\n 2 - вывод общий\n 3 - вывести построчно\n 4 - ввести построчно\n 5 - Важные данные\n" +
            " 6 - Добавить уточняющую информацию\n 7 - Удалить уточняющую информацию\n 8 - дополнительная информация\n 9 - уточняющая информация\n" +
            " Q - сравнить класс и шаблонный класс на похожесть данных Только о человеке(не о работе) \n W - обнулить рабочие строки \n" +
            " E - обнулить строки о программировании");
    }
    static void Main()
    {
        Programmer a = new Programmer();
        while (true)
        {
            Clear();
            Menu();
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D0: return;
                case ConsoleKey.D1: a.Creat(a); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D2: ((IProgrammer)a).Cout(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D3: ((IProgrammer)a).WriteString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D4: ((IProgrammer)a).ChangeString(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D5: ((IProgrammer)a).ImportantDates(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D6: ((IProgrammer)a).AddComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D7: ((IProgrammer)a).DeletComment(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D8: ((IProgrammer)a).ExtraInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.D9: ((IProgrammer)a).ClarifyInfo(); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.Q:  ITransform<Programmer>.Comparison(a, new Programmer()); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.W:  ITransform<Programmer>.ChangeWork(a); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
                case ConsoleKey.E:  ITransform<Programmer>.ChangeProg(a); WriteLine("Нажмите любую клавишу, чтобы продолжить..."); ReadKey(true); break;
            }
        }
    }
}