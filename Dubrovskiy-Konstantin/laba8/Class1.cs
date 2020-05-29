using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Student
    {
        //Делегаты:
        public delegate bool Success(int mark);
        public delegate string GetInfo();
        public delegate void GetMassage(string str);

        public GetMassage massage; //переменная делегата
        //События:
        public event GetMassage examPass; //событие 
        //Поля:
        private string _name;  // имя студента
        private int[] _exams; // массив экзаменов

        public Student (string name) // Конструктор
        {
            _name = name;
            _exams = new int[5]; //5 экзаменов
            for(int i = 0; i < 5; i++)
            {
                _exams[i] = 0;
            }
        }

        public string GetName()
        {
            return _name;
        }
        
        private void Invoke (GetInfo info) //метод принимает в себя делегат
        {
            massage?.Invoke(info?.Invoke());
        }

        public void GetFullInfo()
        {
            GetInfo info;

            info = GetName; // добавим существующий метод (возвр. строку с именем)
            Invoke(info);  

            info = delegate  // добавим анонимный метод (возвр. строку с экз. и отметк.)
            {
                string str = "Оценки по предметам (№экз->отметка): ";
                for (int i = 0; i < 5; i++)
                {
                    if (_exams[i] != 0)
                        str += $"{i}->{_exams[i]} ";
                }
                return str;
            };
            Invoke(info); //                            (передадим лямба-выражение:)
            info = ("Средний балл на данный момент = " + GetAverage(x => x >= 4)).ToString; // добавим стандартный метод возвращающий строку
            Invoke(info);
        }

        public double GetAverage(Success isSuccessfully) // метод принимает в себя делегат (в нашем случае лямба-выражение)
        {
            int sum = 0;
            foreach (int mark in _exams)
            {
                if (isSuccessfully(mark)) //проверка передоваемого условия isSuccessfully
                    sum += mark;
            }
            return ((double)sum / 5);
        }

        public void Examination (int subject, int mark)
        {
            if(mark < 0 || mark > 10)
            {
                Console.WriteLine("Неверный ввод данных");
                return;
            }
            if (mark >= 4)
            {
                try // Исключение
                {
                    _exams[subject] = mark;
                }
                catch
                {
                    examPass?.Invoke($"Произошла ошибка: выход за пределы массива (index = {subject})") ;
                    return;
                }
                examPass?.Invoke($"Предмет {subject} сдан на отметку {mark}"); // вызов события
            }
            else
            {
                examPass?.Invoke($"Пересдача по предмету {subject}"); // вызов события
            }
        }

        public Student(string name, GetMassage methood) // перегруженный конструктор (сразу принимает метод вывода)
        {
            _name = name;
            _exams = new int[5]; //5 экзаменов
            for (int i = 0; i < 5; i++)
            {
                _exams[i] = 0;
            }
            examPass += methood;
            massage = methood;
        }
    }
}
