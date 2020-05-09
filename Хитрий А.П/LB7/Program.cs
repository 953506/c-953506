using System;
using static System.Console;

static class Program
{
    static RatNumber Choose(ref RatNumber num1, ref RatNumber num2)
    {
        WriteLine("Нажмите:\n 1 - работа с первым эл.\n 2 - работа со вторым эл.");
        switch (ReadKey(true).Key)
        {
            case ConsoleKey.D1: return num1;
            case ConsoleKey.D2: return num2;
        }
        return null;
    }
    
    static void Change(ref RatNumber num1, ref RatNumber num2, RatNumber num)
    {
        WriteLine("Нажмите:\n 1 - присв. первому эл.\n 2 - присв. второму эл.\n 3 - вывод значения");
        switch (ReadKey(true).Key)
        {
            case ConsoleKey.D1: num1 = num; break;
            case ConsoleKey.D2: num2 = num; break;
            case ConsoleKey.D3: WriteLine("Значение равно {0}", num.Delenie); break;
        }
    }

    static void Menu()
    {
        WriteLine(" 0 - Выход\n 1 - Ввести числитель и знвменатель\n 2 - Ввести строку\n 3 - Вывод\n 4 - вычисление разности \n 5 - работа с двумя элементами");
    }

    static void Main()
    {
        RatNumber num1 = new RatNumber(1,2);
        RatNumber num2 = new RatNumber(2,4);
        RatNumber nums;
        while (true)
        {
            Clear();
            Menu();
            switch (ReadKey(true).Key)
            {
                case ConsoleKey.D0: Clear(); return;

                case ConsoleKey.D1: Clear(); Choose(ref num1, ref num2)?.WriteNumDen(); WriteLine("Нажмите любую кнопку, чтобы продолжить..."); ReadKey(); break;

                case ConsoleKey.D2: Clear(); 
                    if((nums = Choose(ref num1, ref num2)) == num1 && num1 != null)
                        RatNumber.WriteNum(ref num1); 
                    else if(nums == num2 && num2 != null)
                        RatNumber.WriteNum(ref num2);
                    WriteLine("Нажмите любую кнопку, чтобы продолжить..."); ReadKey(); break;

                case ConsoleKey.D3: Clear(); Choose(ref num1, ref num2)?.NumOut();WriteLine("Нажмите любую кнопку, чтобы продолжить..."); ReadKey(); break;

                case ConsoleKey.D4: Clear(); WriteLine("Разница между классами равна {0:f}",IComparison.Comparison(num1,num2)); 
                                             WriteLine("Нажмите любую кнопку, чтобы продолжить..."); ReadKey(); break;

                case ConsoleKey.D5:
                    Clear(); WriteLine("Классы равны, это {0}", IComparison.Equals(num1, num2));
                    WriteLine("Нажмите любую кнопку, чтобы продолжить..."); ReadKey(); break;

                case ConsoleKey.D6: Clear();
                    WriteLine(" 1 - сумма\n 2 - разность\n 3 - произведение\n 4 - деление\n 5 - сравнить на >\n" +
                        " 6 - сравнить на <\n 7 - сравнить на >=\n 8 - сравнить на <=\n");
                    switch (ReadKey(true).Key)
                    {
                        case ConsoleKey.D1: Change(ref num1, ref num2, num1 + num2); break;
                        case ConsoleKey.D2: Change(ref num1, ref num2, num1 - num2); break;
                        case ConsoleKey.D3: Change(ref num1, ref num2, num1 * num2); break;
                        case ConsoleKey.D4: Change(ref num1, ref num2, num1 / num2); break;
                        case ConsoleKey.D5: WriteLine("!-ый элемент > 2-ой элемент, это {0}", num1 > num2 ); break;
                        case ConsoleKey.D6: WriteLine("!-ый элемент < 2-ой элемент, это {0}", num1 < num2); break;
                        case ConsoleKey.D7: WriteLine("!-ый элемент >= 2-ой элемент, это {0}", num1 >= num2); break;
                        case ConsoleKey.D8: WriteLine("!-ый элемент >= 2-ой элемент, это {0}", num1 <= num2); break;
                    }
                    WriteLine("Нажмите любую кнопку, чтобы продолжить...");
                    ReadKey();
                    break;
            }
        }
    }
}

