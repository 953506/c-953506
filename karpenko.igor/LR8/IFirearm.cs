using System;
using System.Collections.Generic;
using System.Text;

namespace z1
{
    interface IFirearm
    {
        static int _score;
        static int Score
        {
            get => _score;
            set => _score = value;
        }
        int Magazin { get; }
        string BName { get; }
        void Shot();
        void Charac();
        void Menu();
        void Razbor();
        void Zaryad();
        void Zatvor() 
        {
            Console.WriteLine("Затвор не работает");
        }
        void Pricel();
        void Fuse();
        void Remont();
        void Result(int m)
        {
            if (m == 10) Console.WriteLine("Отличный выстрел, в самое яблочко(10)!");
            else if (m > 6 && m < 10) Console.WriteLine($"Хороший выстел, попали в {m}");
            else if (m > 3 && m < 7) Console.WriteLine($"Неплохо, попали в {m}");
            else if (m > 0 && m < 4) Console.WriteLine($"Можно было и лучше, попали в {m}");
            else if (m == 0) Console.WriteLine($"В молоко!");
        }
        void Default() 
        {
            Console.WriteLine("По умолчанию");
        }
    }
}
