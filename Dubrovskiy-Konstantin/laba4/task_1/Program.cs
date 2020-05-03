using System;
using System.Runtime.InteropServices;


namespace ConsoleApp6
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);

        static void Main()
        {
            int attempts = 3; //три попытки
            string pass = ""; //строка пароля

            MessageBox(0, "Введите цифровой четырехзначный пароль", "Ввод пароля", 0);
            while (attempts != 0) //Пока не кончатся попытки
            {                
                for(int i = 0; i < 4; i++) //Вводим 4 символа
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); //Считываем символ                    
                    if (key.KeyChar == '\n') break; //Стоп после клавиши Enter
                    pass += key.KeyChar; //Записываем в pass
                    Console.Write("*"); //На экране * вместо символа
                }
                Console.ReadKey();
                Console.Clear(); //Очищаем консоль
                if (pass == "1234") //Если пароль "1234"
                {
                    MessageBox(0, "Пароль верный! :) Вход разрешен!", "Ввод пароля", 0);
                    return; //Выход
                }
                else
                {
                    attempts--; //Минус попытка
                    MessageBox(0, "Неверный пароль!\n" + $"Попыток осталось: {attempts}", "Ввод пароля", 0);
                    pass = ""; //Обнуляем строку пароля
                }
            }            
            MessageBox(0, "Вы израсходовали все попытки! Вход запрещен!", "Ввод пароля", 0);
            Console.WriteLine();
        }
    }
}
