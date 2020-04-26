using System;
using System.Runtime.InteropServices;

namespace laba_4_task1
{
    class Program
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();
        static void Main(string[] args)
        {
            ItsCoronaTime();
        }

        public static void ItsCoronaTime()
        {
            Console.Clear();
            Console.WriteLine("This menu contains up-to-date information on COVID-19 (April 2020). What do you want to know?");
            Console.WriteLine("1. History of coronavirus.");
            Console.WriteLine("2. The number of infected.");
            Console.WriteLine("3. The number of recovered.");
            Console.WriteLine("4. The number of dead.");
            Console.WriteLine("5. Safety precautions.");
            Console.WriteLine("6. What are the symptoms of COVID-19?");
            Console.WriteLine("7. What should you do if you think you have the coronavirus disease?");
            Console.WriteLine("8. When will coronavirus end?");
            Console.WriteLine("9. Exit.");

            Console.WriteLine("\nEnter a number from 1 to 9.");
            string menu = Console.ReadLine();
            switch (menu)
            {
                case "1":
                    MessageBox(0, "The novel coronavirus pandemic, known as Covid-19, could not have been more predictable. \n Over the past 15 years, there has been no shortage of articles and white papers issuing dire warnings that a global pandemic involving a new respiratory disease was only a matter of time. On BBC Future in 2018, they reported that experts believed a flu pandemic was only a matter of time and that there could be millions of undiscovered viruses in the world. In 2019, US President Donald Trump’s Department of Health and Human Services carried out a pandemic exercise named “Crimson Contagion”, which imagined a flu pandemic starting in China and spreading around the world. The simulation predicted that 586,000 people would die in the US alone. If the most pessimistic estimates about Covid-19 come true, the far better named “Crimson Contagion” will seem like a day in the park. \n As of 26 March, there were more than 470,000 confirmed cases of Covid-19 around the world and more than 20,000 deaths, touching every continent save Antarctica. This was a pandemic, in reality, well before the World Health Organization finally declared it one on 11 March. And we should have seen it coming.", "History of coronavirus", 0);
                    break;
                case "2":
                    MessageBox(0, "~3 million. \n\n April, 2020", "The number of infected", 1);
                    break;
                case "3":
                    MessageBox(0, "~820 thousand \n\n April, 2020", "The number of reovered", 2);
                    break;
                case "4":
                    MessageBox(0, "~200 thousand \n\n April, 2020", "The number of dead", 3);
                    break;
                case "5":
                    MessageBox(0, "1. Wash your hands often with soap and water for at least 20 seconds; \n2. Use a hand sanitizer that contains at least 60% alcohol; \n3. Avoid touching your eyes, nose, and mouth with unwashed hands; \n4. Stay home as much as possible; \n5. Clean AND disinfect frequently touched surfaces daily.", "Safety precautions", 4);
                    break;
                case "6":
                    MessageBox(0, "The most common symptoms of COVID-19 are fever, tiredness, and dry cough. Some patients may have aches and pains, nasal congestion, runny nose, sore throat or diarrhea. These symptoms are usually mild and begin gradually. Some people become infected but don’t develop any symptoms and don't feel unwell. Most people (about 80%) recover from the disease without needing special treatment. Around 1 out of every 6 people who gets COVID-19 becomes seriously ill and develops difficulty breathing. Older people, and those with underlying medical problems like high blood pressure, heart problems or diabetes, are more likely to develop serious illness. People with fever, cough and difficulty breathing should seek medical attention.", "The symptoms of COVID-19", 5);
                    break;
                case "7":
                    MessageBox(0, "If you have a fever, cough and difficulty breathing, seek medical attention and call in advance. Follow the directions of your local health authority.", "I have symptoms of coronavirus! What to do? ", 6);
                    break;
                case "8":
                    MessageBox(0, "Honestly, it’s impossible to say if and when the coronavirus will die down because it’s a totally new virus, and therefore unpredictable. But researchers do look at past pandemics to make very baseline predictions about when it might end. And in the past, pandemics have typically lasted between 12 and 36 months.", "Baseline predictions", 7);
                    break;
                case "9":
                    Console.WriteLine("I hope the information was helpful. Goodbye!", 8);
                    Environment.Exit(-1);
                    break;
                default:
                    LockWorkStation(); Environment.Exit(0);
                    break;
            }
            Next();
            static void Next()
            {
                Console.Clear();
                Console.WriteLine("1. Continue;");
                Console.WriteLine("2. Exit.");
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter a number from 1 to 9.");
                }
                if (choice == 1) ItsCoronaTime();
                else { LockWorkStation(); Environment.Exit(0); }
            }
        }
    }
}