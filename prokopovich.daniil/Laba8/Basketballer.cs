using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    sealed class Basketballer : Sportsman, IPlayable
    {
        //Конструктор
        public Basketballer(string name, string surname, string gender) : base(name, surname, gender)
        {
            category = "Basketballer";
            coach = "Michael Jordan";
        }

        //Методы
        public override void Score()
        {
            Console.WriteLine($"{fio.name} scored a three-pointer. Wow!");
            Console.ReadKey();
        }
        
        //Использование IPlayable
        public void Play()
        {
            int score = 0;
            bool correct;
            string answer;
            Console.WriteLine("Welcome to the game \"The worst basketball quest!");
            
            //Вопрос 1
            Console.WriteLine("1. What team is the current NBA champion?");
            answer = Console.ReadLine();
            if (answer == "Toronto Raptors")
            {
                Console.WriteLine("You're right! Get those goddamn points!");
                correct = true;
                score = DefinePrise(correct);
            }
            else
            {
                Console.WriteLine("Sorry, but you're wrong. F");
                correct = false;
                score = DefinePrise(correct);
            }
            
            //Вопрос 2
            Console.WriteLine("2. What player has most points scored in the history of NBA?");
            if (answer == "Kareem Abdul-Jabbar")
            {
                Console.WriteLine("You're right! Get those goddamn points!");
                correct = true;
                score = DefinePrise(correct);
            }
            else
            {
                Console.WriteLine("Sorry, but you're wrong. F");
                correct = false;
                score = DefinePrise(correct);
            }
            
            //Вопрос 3
            Console.WriteLine("3. Can you name the most titled team of NBA?");
            if (answer == "Boston Celtics")
            {
                Console.WriteLine("You're right! Get those goddamn points!");
                correct = true;
                score = DefinePrise(correct);
            }
            else
            {
                Console.WriteLine("Sorry, but you're wrong. F");
                correct = false;
                score = DefinePrise(correct);
            }
            
            //Итоги
            if (score < 0) score = 0;
            Console.WriteLine($"Your score is: {score}");
        }

        public int DefinePrise(bool result)
        {
            if (result)
                return 25;
            else
                return -30;
        }
    }
}