using System;
using System.ComponentModel.Design;

namespace Lab8
{
    class Program
    {
        //Создаем два делегата с разной сигнатурой, используем их в конце программы.
        public delegate void ProficiencyChecker(Sportsman first, Sportsman second);
        public delegate void LetsDoeIt(Sportsman game);

        public static event ProficiencyChecker Check;
        public static event LetsDoeIt LetsPlay;
        
        static void Main(string[] args)
        {
            //Инициализация трёх объектов: футболиста, баскетболиста и киберспортсмена.
            Footballer Beckham = new Footballer("David", "Beckham", "male");
            Beckham.Salary = 250000;
            
            Basketballer Jordan = new Basketballer("Michael", "Jordan", "male");
            Jordan.Salary = 300000;
            
            eSportsman Ishutin = new eSportsman("Danil", "Ishutin", "male");
            Ishutin.Salary = 100000;
            
            //Применение метода Play интерфейса IPlayable, реализованного по своему в каждом классе.
            Console.WriteLine("What quiz do you want to play: enter 1 for football and 2 for basketball and 3 for esport.");
            int choice = 0;
            try
            {
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 3)
                    throw new Exception("What did you just enter?!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            if(choice == 1)
                Beckham.Play();
            else if(choice == 2)
                Jordan.Play();
            else if(choice == 3)
                Ishutin.Play();
            
            //Создаем второго футболиста и применяем IComparable.
            Footballer Pogba = new Footballer("Paul", "Pogba", "male");
            Pogba.Salary = 100000;

            try
            {
                if(Beckham.CompareTo(Pogba) > 0)
                    Console.WriteLine("Beckham's salary is higher!");
                else if(Beckham.CompareTo(Pogba) < 0)
                    Console.WriteLine("Beckham's salary is higher!");
                else
                    Console.WriteLine("Both salaries are equal!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            //Создаем футболиста-клона с помощью реализации ICloneable и проверяем его и первого футболиста на идентичность.
            Footballer AnotherBeckham = Beckham.Clone() as Footballer;
            if(AnotherBeckham == null)
                Console.WriteLine("Oops, I did it again!");
            else
            {
                if (Equals(Beckham, AnotherBeckham))
                    Console.WriteLine("These two are similar!");
                else
                    Console.WriteLine("Well, no one is perfect!");
            }
            
            //Использование созданных делегатов. Одним пользуемся напрямую, вторым через анонимный метод.
            Console.WriteLine("Time to play some games!");
            ProficiencyChecker checker = Proficiency;
            checker(Beckham, Pogba);
            
            
            LetsDoeIt gamer = delegate(Sportsman game) { Game(game); };
            gamer(Ishutin);

        }

        public static void Proficiency(Sportsman first, Sportsman second)
        {
            if (first is Footballer && second is Footballer)
                Console.WriteLine("Both are footballers");
            else if(first is Basketballer && second is Basketballer)
                Console.WriteLine("Both are basketballers");
            else if(first is eSportsman && second is eSportsman)
                Console.WriteLine("Both are eSportsmen");
            else 
                throw new Exception("Cannot compare these two sportsmen!");
            
            if(Equals(first, second))
                Console.WriteLine("Why did you put two similar people over hear???");
            else
                Console.WriteLine("Let's check, what are the names of these amazing people!");

            if (first.Name == second.Name)
                Console.WriteLine("They have similar names! Grats!\n");
                
            Console.WriteLine($"{first.Name} - {second.Name}");
            Console.WriteLine($"{first.Surname} - {second.Surname}");
            Console.WriteLine($"{first.Salary} - {second.Salary}");
            if(Check != null)
                Check(first, second);
        }

        public static void Game(Sportsman gameType)
        {
            int result = gameType.Play();
            if(result > 0 && result < 20)
                Console.WriteLine("You're definitely not interested in sports!");
            else if(result > 20 && result < 50)
                Console.WriteLine("Could be better!");
            else if(result >= 50)
                Console.WriteLine("Noice!");
            else
                throw new Exception("KEKW!");
            if(LetsPlay!= null)
                LetsPlay(gameType);
        }
    }
}