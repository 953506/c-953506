using System;

namespace Laba5
{
     public struct Data
     {
        private int _age;
        private int _levelMath;
        private int _levelRus;
        private int _levelPhys;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 16 || value > 50)
                {
                    Console.WriteLine("Введите правильный возраст");
                    Environment.Exit(0);
                }
                else 
                {
                    _age = value;
                }
            }
        }

        public int LevelMath
        {
            get { return _levelMath; }
            set 
            {
                if (value == 0 || value > 10)
                {
                    Console.WriteLine("Проверьте введенные данные");
                    Environment.Exit(0);
                }
                else 
                {
                    _levelMath = value;
                }
            }      
        }

        public int LevelRus
        {
            get { return _levelRus; }
            set
            {
                if (value == 0 || value > 10)
                {
                    Console.WriteLine("Проверьте введенные данные");
                    Environment.Exit(0);
                }
                else
                {
                    _levelRus = value;
                }
            }
        }

        public int LevelPhys
        {
            get { return _levelPhys; }
            set
            {
                if (value == 0 || value > 10)
                {
                    Console.WriteLine("Проверьте введенные данные");
                    Environment.Exit(0);
                }
                else
                {
                    _levelPhys = value;
                }
            }
        }
    }


    class Entrance
    {
        public enum Choise
        {
            Paid = 0,
            Free = 1,
        }

        public Data data;
        public string _name; 

        public virtual void Faculty(int ball, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (ball >= 345)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
            else if (educ == Choise.Paid)
            {
                if (ball >= 279)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
        }

        public static int CT(int levelMath, int levelRus, int levelPhys)
        {

            Random x = new Random();
            int resultCT = 0;
            int[] result = new int[4];
            result[0] = x.Next(50, 101);
            Console.WriteLine($"Ваш средний балл = {result[0]}") ;
            Console.WriteLine("Вы сдаёте ЦТ по математике...");
            result[1] = x.Next(levelMath * 10 - 20, levelMath * 10 + 1);
            Console.WriteLine($"Ваш балл {result[1]}");
            Console.WriteLine("Вы сдаёте ЦТ по русскому...");
            result[2] = x.Next(levelRus * 10 - 20, levelRus * 10 + 1);
            Console.WriteLine($"Ваш балл {result[2]}");
            Console.WriteLine("Вы сдаёте ЦТ по физике...");
            result[3] = x.Next(levelPhys * 10 - 20, levelPhys * 10 + 1);
            Console.WriteLine($"Ваш балл {result[3]}");
            foreach (int one in result)
                resultCT += one;
            Console.WriteLine($"\nВаш суммарный балл {resultCT}");
            return resultCT;
        }      
    }


    class BSU : Entrance
    {
        public BSU(string name, int age, int levelMath, int levelRus, int levelPhys)
        {
            _name = name;
            data.Age = age;
            data.LevelMath = levelMath;
            data.LevelRus = levelRus;
            data.LevelPhys = levelPhys;
        }

        public override void Faculty(int ball, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (ball >= 320)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
            else if (educ == Choise.Paid)
            {
                if (ball >= 260)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
        }
    }


    class BSUIR : Entrance
    {
        public BSUIR(string name, int age, int levelMath, int levelRus, int levelPhys)
        {
            _name = name;
            data.Age = age;
            data.LevelMath = levelMath;
            data.LevelRus = levelRus;
            data.LevelPhys = levelPhys;
        }

        public override void Faculty(int ball, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (ball >= 345)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
            else if (educ == Choise.Paid)
            {
                if (ball >= 279)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
        }
    }


    class BNTU : Entrance
    {
        public BNTU(string name, int age, int levelMath, int levelRus, int levelPhys)
        {
            _name = name;
            data.Age = age;
            data.LevelMath = levelMath;
            data.LevelRus = levelRus;
            data.LevelPhys = levelPhys;
        }

        public override void Faculty(int ball, Choise educ)
        {
            if (educ == Choise.Free)
            {
                if (ball >= 255)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
            else if (educ == Choise.Paid)
            {
                if (ball >= 220)
                    Console.WriteLine("Поздравляем,Вы поступили");
                else Console.WriteLine("Вы не оправдали своих надежд");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Random x = new Random();
            Entrance entrance = new Entrance();
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Уровень подготовки к математике (от 1 до 10): ");
            int levelMath = Convert.ToInt32(Console.ReadLine());
            Console.Write("Уровень подготовки к русскому: ");
            int levelRus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Уровень подготовки к физике: ");
            int levelPhys = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите университет\nБГУ - 1\nБГУИР - 2\nБНТУ - 3");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Собираетесь поступать на платное(0)/бюджет(1)?");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Entrance.Choise educ;
            educ = (Entrance.Choise)choise;
            switch(num)
            {
                case 1:
                    {
                        entrance = new BSU(name, age, levelMath, levelRus, levelPhys);
                        int ball1 = Entrance.CT(levelMath, levelRus, levelPhys);
                        entrance.Faculty(ball1, educ);
                        break;
                    }
                case 2:
                    {
                        entrance = new BSUIR(name, age, levelMath, levelRus, levelPhys);
                        int ball1 = Entrance.CT(levelMath, levelRus, levelPhys);
                        entrance.Faculty(ball1, educ);
                        break;
                    }
                case 3:
                    {
                        entrance = new BNTU(name, age, levelMath, levelRus, levelPhys);
                        int ball1 = Entrance.CT(levelMath, levelRus, levelPhys);
                        entrance.Faculty(ball1, educ);
                        break;
                    }           
            }
        }
    }
}
