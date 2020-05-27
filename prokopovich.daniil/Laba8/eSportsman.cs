using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    sealed class eSportsman : Sportsman, IPlayable
    {
        //Конструктор
        public eSportsman(string name, string surname, string gender) : base(name, surname, gender)
        {
            category = "eSportsman";
            coach = "Mikhaylo 'Kane' Blagin";
        }

        //Методы
        public override void ChopWatermelon()
        {
            Console.WriteLine($"{fio.name} trying to chop a watermelon, but doesn't succeed.");
            Console.ReadKey();
        }

        public void Play()
        {
            int score = 0;
            bool correct;
            string answer;
            Console.WriteLine("Welcome to the game \"Kingdom of cringe!\'");
            
            //Вопрос 1
            Console.WriteLine("1. Can you name the first team to win the International in DOTA2?");
            answer = Console.ReadLine();
            if (answer == "Natus Vincere")
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
            Console.WriteLine("2. The nicknames of famous russian Dota 2 observer and LOL legend are spelled the same way. Guess how?");
            if (answer == "Faker")
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
            Console.WriteLine("3. What's the name of !European! organization, that organizes e-sports contests all over the world?");
            if (answer == "ESL")
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