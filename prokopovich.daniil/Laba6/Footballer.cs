using System;
using System.IO.MemoryMappedFiles;

namespace Lab6
{
    sealed class Footballer : Sportsman, IPlayable
    {
        //Конструктор
        public Footballer(string name, string surname, string gender) : base(name, surname, gender)
        {
            category = "Footballer";
            coach = "Zinedine Zidane";
        }

        //Методы
        public override void Bounce()
        {
            Console.WriteLine($"{fio.name} bouncing the ball.");
            Console.ReadKey();
        }

        //Использование IPlayable
        public void  Play()
        {
            int score = 0;
            bool correct;
            string answer;
            Console.WriteLine("Welcome to the game \"The world's worst football quiz!\"");
            
            //Вопрос 1
            Console.WriteLine("1. Who was the first and only goalkeeper to get Ballon d'Or?");
            answer = Console.ReadLine();
            if (answer == "Lew Yashin")
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
            Console.WriteLine("2. Who scored the famous parachute goal during the 2014 World Cup?");
            answer = Console.ReadLine();
            if (answer == "Robin van Persie")
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
            Console.WriteLine("3. When happened the greatest comeback in UCL final history made by Liverpool?");
            answer = Console.ReadLine();
            if (answer == "2005")
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
                return 20;
            else
                return -20;
        }
    }
}