using System;

namespace laba_2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Эта программа создана для рассчета площади, периметра, высоты, углов, радиусов вписанной и описанной окружностей по трем заданным сторонам.");
            string otvet2;
            do
            {
                string a1, b1, c1;
                string otvet;
                Console.WriteLine("Введите длины сторон: ");
                do
                {
                    a1 = Console.ReadLine();
                    b1 = Console.ReadLine();
                    c1 = Console.ReadLine();
                    double a, b, c;
                    if (!Double.TryParse(a1, out a))
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    if (!Double.TryParse(b1, out b))
                    {
                        Console.WriteLine("Ошибка ввода"); 
                    }
                    if (!Double.TryParse(c1, out c))
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    if (a + b > c && a + c > b && b + c > a)
                    {
                        Console.WriteLine("Треугольник существует, поэтому выполняем вычисления: ");
                        double S, P, p;
                        double h;
                        S = a * b * c;
                        P = a + b + c;
                        p = P / 2;
                        double k;
                        k = p * (p - a) * (p - b) * (p - c);
                        double l;
                        l = Math.Sqrt(k);
                        h = 2 * l / a;
                        double cosa, cosb, cosc;
                        cosa = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
                        cosb = (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c);
                        cosc = (Math.Pow(b, 2) + Math.Pow(a, 2) - Math.Pow(c, 2)) / (2 * b * a);
                        cosa = (Math.Acos(cosa) * 180) / Math.PI;
                        cosb = (Math.Acos(cosb) * 180) / Math.PI;
                        cosc = (Math.Acos(cosc) * 180) / Math.PI;
                        double r, R;
                        R = (a * b * c) / (4 * l);
                        r = Math.Sqrt(((p - a) * (p - b) * (p - b)) / p);
                        Console.WriteLine("Площдь: {0}", S);
                        Console.WriteLine("Периметр: {0}", P);
                        Console.WriteLine("Высота: {0}", h);
                        Console.WriteLine("Угол a: {0}", cosa);
                        Console.WriteLine("Угол b: {0}", cosb);
                        Console.WriteLine("Угол c: {0}", cosc);
                        Console.WriteLine("Радиус описанной окружности : {0}", R);
                        Console.WriteLine("Радиус вписанной окружности: {0}", r);
                    }
                    else
                    {
                        Console.WriteLine("Треугольник не существует, хотите ввести другие стороны? ");
                    }
                    otvet = Console.ReadLine();
                } while (otvet == "да");
                Console.WriteLine("Хотите ввести другие стороны треугольника? ");
                otvet2 = Console.ReadLine();
            } while (otvet2 == "да");
        }
    }