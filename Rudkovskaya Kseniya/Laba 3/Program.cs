using System;

namespace Laba3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Human primer = new Human();
            int kolv, uchenik;
            char numer;
            string name = "Ксения";
            Console.WriteLine("Сколько студентов в группе? ");
            int.TryParse(Console.ReadLine(), out kolv);
            Gruppa chel = new Gruppa(kolv + 1);
            Console.WriteLine("Пример ввода:\n");
            primer.GetInfo();
            for (int i = 0; i < kolv; i++)
            {
                
                Console.WriteLine($"\nНомер студента: {i+1}");
                chel[i] = new Human { };
                Console.WriteLine("Имя: ");
                name = Console.ReadLine();
                chel[i].GetName(name);
                Console.WriteLine("Фамилия: ");
                string surname = Console.ReadLine();
                chel[i].GetSurname(surname);
                Console.WriteLine("Возраст: ");
                string age1 = Console.ReadLine();
                int age = int.Parse(age1);               
                chel[i].GetAge(age);
                chel[i].GetMath();
                chel[i].GetRus();
                chel[i].GetPhys();
                chel[i].GetScore();
                Console.Clear();
            }
            chel[kolv] = new Human(name);
            do
            {
                Panel();
                numer = Console.ReadKey().KeyChar;

                switch (numer)
                {
                    case '1':
                        Console.Clear();
                        for (int i = 0; i < kolv; i++)
                        {
                            chel[i].GetInfo();
                            Console.WriteLine("\n");
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine($"Выберите номер ученика ");
                        int.TryParse(Console.ReadLine(), out uchenik);
                        chel[uchenik - 1].GetСhange();
                        if (chel[uchenik - 1].math <= 0 || chel[uchenik - 1].rus <= 0 || chel[uchenik - 1].phys <= 0)
                        {
                            chel[uchenik - 1].GetExpulsion();
                        }
                        chel[uchenik - 1].GetScore();
                        break;
                    case '3':
                        Console.Clear();
                        for (int i = 0; i < kolv; i++)
                        {
                            for (int y = 0; y < kolv - 1; y++)
                            {
                                if (chel[y].score < chel[y + 1].score)
                                {
                                    chel[kolv + 1] = chel[y];
                                    chel[y] = chel[y + 1];
                                    chel[y + 1] = chel[kolv + 1];
                                }
                            }
                        }
                        break;
                    case '4':
                        Console.Clear();
                        Console.WriteLine($"Выберите номер ученика ");
                        int.TryParse(Console.ReadLine(), out uchenik);
                        chel[uchenik - 1].GetExpulsion();
                        break;
                    case '0':
                        return;
                }
            } while (true) ;
        }

        static void Panel()
        {
            Console.WriteLine("1-вывод всех студентов");
            Console.WriteLine("2-повысить/понизить балл студента по предметам");
            Console.WriteLine("3-распределение студентов по убыванию среднего балла");
            Console.WriteLine("4-отчислить студента");
            Console.WriteLine("0-Exit");

        }
    }
}
