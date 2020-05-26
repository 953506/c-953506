using System;
using System.Collections;

namespace laba6
{   

    class Program
    {

        static void Main()
        {
            int choice, item, age;
            bool menu = true;
            string name, surname;
            ArrayList person = new ArrayList();
            ArrayList print = new ArrayList();
            Child kinder = new Child("Артём", "Киричук", 5, Toy.Bear, 4);
            Pedagogue teacher = new Pedagogue("Алла", "Пешко", 43, (Groups)5, 900, "БрГУ им.Пушкина");
            Worker worker = new Worker("Георгий", "Градус", 57, 999, true, 14);
            person.Add(kinder);
            person.Add(teacher);
            person.Add(worker);
            while (menu)
            {
                   Console.Clear();
                   Console.WriteLine("1.Воспитатель" +
                       "\n2.Ребёнок" +
                       "\n3.Рабочий" +
                       "\n4.Информация о саде" +
                       "\n5.Добавить" +
                       "\n6.Вывести список" +
                       "\n7.Составить список на печать" +
                       "\n0.Выйти");
                    while(!Int32.TryParse(Console.ReadLine(),out choice))
                        Console.WriteLine("incorrect input");
                    Console.Clear();
                    switch(choice)
                    {
                        case 1:
                            {
                               
                                Console.WriteLine("1.Самочувствие" +
                                   "\n2.Настроение" +
                                   "\n3.Информаия о воспитателе");
                                while (!int.TryParse(Console.ReadLine(), out item))
                                    Console.WriteLine("Выберите снова");
                                if (item == 1)
                                {
                                    Console.Clear();
                                    teacher.KnowHealth();
                                }
                                if (item == 2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Добавить премию");
                                    int premium = Convert.ToInt32(Console.ReadLine());
                                    teacher.Spirits(premium);
                                }
                                if (item == 3)
                                {
                                    Console.Clear();
                                    teacher.GetInfo();
                                }
                                GoOver(ref menu);
                                break;
                            }
                        case 2:
                            {
                                Console.Clear();
                                Console.WriteLine("1.Самочувствие" +
                                "\n2.Настроение" +
                                "\n3.Сфера деятельности" +
                                "\n4.Информация о ребёнке");
                                while (!Int32.TryParse(Console.ReadLine(), out item))
                                    Console.WriteLine("incorrect intput");
                                int choiceK;
                                Console.Clear();
                                if (item == 1)
                                {
                                    Console.WriteLine("Ребёнок наелся?");
                                    choiceK = Convert.ToInt32(Console.ReadLine());
                                    if (choiceK == 0) kinder.Satiety = false;
                                    else kinder.Satiety = true;
                                    Console.Clear();
                                    kinder.KnowHealth();
                                }
                                if (item == 2)
                                {
                                    Console.WriteLine("Поел?");
                                    choiceK = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    if (choice == 0) kinder.Spirits(false);
                                    else kinder.Spirits(true);
                                }
                                if (item == 3) kinder.Addiction();
                                if (item == 4)
                                    kinder.GetInfo();
                                GoOver(ref menu);
                                break;
                            }
                        case 3:
                            {
                                Console.Clear();                                
                                Console.WriteLine("1.Самочувствие" +
                                "\n2.Загадка" +
                                "\n3.Починить" +
                                "\n4.Информаия о рабочем");
                                while (!int.TryParse(Console.ReadLine(), out item))
                                    Console.WriteLine("Выберите снова");
                                if (item == 1)
                                {
                                    Console.Clear();
                                    if (kinder is Kindergarten)
                                    {
                                        Kindergarten Garten1 = kinder;
                                        Garten1.KnowHealth();
                                    }
                                }
                                if (item == 2)
                                {
                                    Console.Clear();
                                    worker.Riddle();
                                }
                                if (item == 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Что нужно починить?");
                                    string thing = Console.ReadLine();
                                    Console.WriteLine("Подайте, пожалуйста, ключ))))");
                                    int key = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    worker.Fix(thing, key);
                                }
                                if (item == 4)
                                {
                                    Console.Clear();
                                    worker.GetInfo();
                                }
                                GoOver(ref menu);
                                break;
                            }
                        case 4:
                            {
                                teacher.Info();
                                GoOver(ref menu);
                                break;
                            }
                        case 5:
                            {
                            Console.WriteLine("1.Ребёнка" +
                                "\n2.Воспитатель" );                                    
                                while (!Int32.TryParse(Console.ReadLine(), out item))
                                    Console.WriteLine("incorrect intput");
                                switch (item)
                                {
                                    case 1:
                                        {
                                            int toy;
                                            Console.Write("Имя: ");
                                            name = Console.ReadLine();
                                            Console.Write("Фамилия: ");
                                            surname = Console.ReadLine();
                                            Console.Write("Возраст: ");
                                            age = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Любимая игрушка: ");
                                            toy = Convert.ToInt32(Console.ReadLine());
                                            Child kinder2 = new Child(name, surname, age, (Toy)toy, 3);
                                            person.Add(kinder2);
                                            GoOver(ref menu);
                                            break;
                                        }
                                    case 2:
                                        {
                                            int salary, group;
                                            string education;
                                            Console.Write("Имя: ");
                                            name = Console.ReadLine();
                                            Console.Write("Фамилия: ");
                                            surname = Console.ReadLine();
                                            Console.Write("Возраст: ");
                                            age = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Группа: ");
                                            group = Convert.ToInt32(Console.ReadLine());
                                            Console.Write("Зарплата: ");
                                            salary = Convert.ToInt32(Console.ReadLine());
                                            education = Console.ReadLine();
                                            Pedagogue teacher2 = new Pedagogue(name, surname, age, (Groups)group, salary, education);
                                            person.Add(teacher2);
                                            GoOver(ref menu);
                                            break;
                                        }
                                }
                                break; 
                            }                                                    
                        case 6:
                            {
                                Print(person);
                                GoOver(ref menu);
                                break;
                            }
                        case 7:
                        {
                            toPrint(print,person);
                            Print(print);
                            GoOver(ref menu);
                            break;
                        }
                        case 0:
                            {
                                Environment.Exit(1);
                                break;
                            }       
                    }                
            }

        }  
        
        static void Print( ArrayList person)
        {
            int i = 1;        
            person.Sort();
            foreach (Kindergarten p in person)
                Console.WriteLine($"{i++}.{p.Name}#{p.Surname}#{p.Age}");                    
        }

        static void toPrint(ArrayList print, ArrayList person)
        {
            Console.WriteLine("Введите минимальный возраст сотрудника");
            int age = Convert.ToInt32(Console.ReadLine());
            foreach(Kindergarten p in person)
            {
                if (p.Age >= age)
                {
                    Kindergarten employee = (Kindergarten)p.Clone();
                    print.Add(employee);
                }
            }
        }            

        static void GoOver( ref bool choice)
        {

            int item;
            Console.WriteLine("1.Меню детсад");
            Console.WriteLine("2.Выйти");
            while (!Int32.TryParse(Console.ReadLine(), out item)) ;
            switch (item)
            {
                case 1:
                    {
                        choice = true;
                        break;
                    }
                case 2:
                    {
                        choice = false;
                        break;
                    }
            }            
        }
    }
}
