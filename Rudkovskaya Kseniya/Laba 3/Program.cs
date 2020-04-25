using System;

namespace Laba3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int kolv, uchenik;
            char numer;
            string name = "Ксения";
            Console.WriteLine("Сколько студентов в группе? ");
            int.TryParse(Console.ReadLine(), out kolv);
            Gruppa chel = new Gruppa(kolv + 1);
            for (int i = 0; i < kolv; i++)
            {
                
                Console.WriteLine($"\nНомер студента: {i+1}");
                chel[i] = new Human { };
                Console.WriteLine("Имя: ");
                name = Console.ReadLine();
                chel[i].Name = name;
                Console.WriteLine("Фамилия: ");
                string surname = Console.ReadLine();
                chel[i].Surname = surname;
                Console.WriteLine("Возраст: ");
                string age1 = Console.ReadLine();
                int age = int.Parse(age1);               
                chel[i].Age = age;
                chel[i].Math = 1;
                chel[i].Rus = 1;
                chel[i].Phys = 1;
                chel[i].SetScore();
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
                            chel[i].ShowInfo();
                            Console.WriteLine("\n");
                        }
                        break;
                    case '2':
                        Console.Clear();
                        Console.WriteLine($"Выберите номер ученика ");
                        int.TryParse(Console.ReadLine(), out uchenik);
                        chel[uchenik - 1].AcscessСhange();
                        if (chel[uchenik - 1].Math <= 0 || chel[uchenik - 1].Rus <= 0 || chel[uchenik - 1].Phys <= 0)
                        {
                            chel[uchenik - 1].Expulsion();
                        }
                        chel[uchenik - 1].SetScore();
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
                        chel[uchenik - 1].Expulsion();
                        break;
                    case '0':
                        return;
                }
            } while (true) ;
        }

        public static void Panel()
        {
            Console.WriteLine("1-вывод всех студентов");
            Console.WriteLine("2-повысить/понизить балл студента по предметам");
            Console.WriteLine("3-распределение студентов по убыванию среднего балла");
            Console.WriteLine("4-отчислить студента");
            Console.WriteLine("0-Exit");

        }
    }
}
