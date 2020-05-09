using System;

namespace laba6
{
    class Program
    {
        static Child kinder = new Child("Артём", "Киричук", 5, Toy.Bear, 4);
        static Pedagogue teacher = new Pedagogue("Алла", "Пешко", 43, (Groups)5, 900, "БрГУ им.Пушкина");
        static  Worker worker = new Worker("Георгий", "Градус", 57, 999, true, 14);

        static void Main()
        {
            Menu();         
        }

        static void Menu ()
        {
            Console.Clear();
            int menu;
            Console.WriteLine("1.Ребёнок" +
            "\n2.Воспитатель" +
            "\n3.Рабочий" +
            "\n4.Информация о саде" +
            "\n0.Выйти");
            while (!int.TryParse(Console.ReadLine(), out menu))
                Console.WriteLine("Выберите снова");
            if (menu == 1)     ChildMenu();
            if (menu == 2) PedagogueMenu();
            if (menu == 3) WorkerMenu();
            if (menu == 4) teacher.Info();
            else Environment.Exit(1);            
        }

        static void ChildMenu()
        {
            Console.Clear();
            Console.WriteLine("1.Самочувствие"+
            "\n2.Настроение"+
            "\n3.Сфера деятельности"+
            "\n4.Информация о ребёнке");
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (menu == 1)
            {
                Console.WriteLine("Ребёнок наелся?");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0) kinder.Satiety = false;
                else kinder.Satiety = true;
                Console.Clear();
                kinder.KnowHealth();
            }
            if (menu == 2)
            {
                Console.WriteLine("Поел?");             
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (choice == 0) kinder.Spirits(false);
                else kinder.Spirits(true);
            }
            if (menu == 3) kinder.Addiction();
            if (menu == 4) kinder.GetInfo();
            GoOver(1);
        }

        static void PedagogueMenu()
        {
            Console.Clear();
            int menu;
            Console.WriteLine("1.Самочувствие"+
            "\n2.Настроение"+
            "\n3.Информаия о воспитателе");
            while (!int.TryParse(Console.ReadLine(), out menu))
                Console.WriteLine("Выберите снова");
            if (menu == 1)
            {
                Console.Clear();
                teacher.KnowHealth();
            }           
            if (menu == 2)
            {
                Console.Clear();
                Console.WriteLine("Добавить премию");
                int premium = Convert.ToInt32(Console.ReadLine());
                teacher.Spirits(premium);
            }
            if (menu == 3)
            {
                Console.Clear();
                teacher.GetInfo();
            }
            GoOver(2);
        }

        static void WorkerMenu()
        {
                  Console.Clear();
            int menu;
            Console.WriteLine("1.Самочувствие"+
            "\n2.Загадка"+
            "\n3.Починить"+
            "\n4.Информаия о рабочем");
            while (!int.TryParse(Console.ReadLine(), out menu))
                Console.WriteLine("Выберите снова");
            if (menu == 1)
            {
               Console.Clear();
                if(kinder is Kindergarten)
                {
                    Kindergarten Garten1 = kinder;
                    Garten1.KnowHealth();
                }   
            }           
            if (menu == 2)
            {
                Console.Clear();
                worker.Riddle();
            }
            if (menu == 3)
            {
                Console.Clear();
                Console.WriteLine("Что нужно починить?");
                string thing = Console.ReadLine();
                Console.WriteLine("Подайте, пожалуйста, ключ))))");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                worker.Fix(thing, key);
            }
            if(menu == 4)
            {
                Console.Clear();
                worker.GetInfo();
            }
            GoOver(3);
        }

        static void GoOver(int person)
        {
            Console.WriteLine("1.Меню детсад");
            Console.WriteLine("2.Продолжить");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1) Menu();
            else
            {
                if (person == 1) ChildMenu();
                if (person == 2) PedagogueMenu();
                if (person == 3) WorkerMenu();
            }
        }
    }
}
