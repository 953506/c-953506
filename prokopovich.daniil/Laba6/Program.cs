using System;
using System.Collections.Immutable;

namespace Lab6
{
    class Program
    {
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
            Console.WriteLine("What quiz do you want to play: enter 1 for football and 2 for basketball and 3 for esportsman.");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
                Beckham.Play();
            else if(choice == 2)
                Jordan.Play();
            else if(choice == 3)
                Ishutin.Play();
            
            //Создаем второго футболиста и применяем IComparable.
            Footballer Pogba = new Footballer("Paul", "Pogba", "male");
            Pogba.Salary = 100000;
            
            if(Beckham.CompareTo(Pogba) > 0)
                Console.WriteLine("Beckham's salary is higher!");
            else if(Beckham.CompareTo(Pogba) < 0)
                Console.WriteLine("Beckham's salary is higher!");
            else
                Console.WriteLine("Both salaries are equal!");
            
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

        }
    }
}