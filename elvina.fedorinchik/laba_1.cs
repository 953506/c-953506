using System;

namespace laba_1
{
    class Program
    {
        public static int CardCost(string card)  
        {
            int counterPlayer = 0;
            switch (card[0])
            {
                case '6':
                case '7':
                case '8':
                case '9':
                    counterPlayer = card[0] - '0'; break;
                case '1':
                    counterPlayer = 10; break;
                case 'J': counterPlayer = 2; break;
                case 'Q': counterPlayer = 3; break;
                case 'K': counterPlayer = 4; break;
                case 'A': counterPlayer = 1; break;
            }
            return counterPlayer;
        }


        static void Main(string[] args)
        {
            bool play = true;  

            string name = "";
            Console.WriteLine(" — Welcome to game '21'! What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("\n — Nice to see you, " + name + "!");
            do
            {
                var masts = new string[] { "DIAMONDS", "HEARTS", "SPADES", "CLUBS" };
                var numbers = new string[] { "6", "7", "8", "9", "10", "JACK", "QUEEN", "KING", "ACE" };
                var card = new string[37];
                int index = 0;
                int counterPlayer = 0, couterRival = 0, counterCard = 0;
                Random rand = new Random();

                foreach (string number in numbers)
                {
                    foreach (string mast in masts)
                        card[index++] = number + " " + mast;
                }
                
                for (int f = 0; f < card.Length - 1; f++)
                {
                    int j = rand.Next(f, card.Length - 1);
                    string temp = card[f];
                    card[f] = card[j];
                    card[j] = temp;
                }
               
                string answer = "";
                Console.WriteLine(" — So now we can start!");
                Console.WriteLine("Cartier mixed a deck of cards and gave you the first two: "+ card[counterCard] + "\n" + card[1]);
                counterPlayer += Program.CardCost(card[0]);
                couterRival += Program.CardCost(card[3]);
                
                do
                {
                    counterPlayer += Program.CardCost(card[++counterCard]);
                    if (couterRival < 18) couterRival += Program.CardCost(card[++counterCard]);
                    if (counterCard == 2) counterCard = 3;
                    if (couterRival < 18) { if (counterCard != 3) Console.WriteLine("Your new card:\n{0}\n", card[counterCard - 1]); }
                    else { if (counterCard != 3) Console.WriteLine("Your new card:\n{0}\n", card[counterCard]); }
                    if (counterPlayer == 21) { Console.WriteLine("Congratulation! You have 21 points. This is victory!\a"); break; }
                    if (couterRival == 21) { Console.WriteLine("Sorry, but your opponent has 21 points. You lost this game!\a"); break; }
                    if (counterPlayer > 21 && couterRival > 21) { Console.WriteLine("You have too much, your opponent has too. This is a draw.\a"); break; }
                    if (counterPlayer > 21)
                    {
                        Console.WriteLine("You have too much. You lost this game!");
                        break;
                    }
                    if (couterRival > 21)
                    {
                        Console.WriteLine("Your opponent has too much. Congratulations on victory!");
                        break;
                    }
                    Console.WriteLine("Sum of your cards now: {0}\n1. I want to take another card;\n2. Thanks, no more.", counterPlayer, couterRival);
                    answer = Console.ReadLine();
                    if (answer == "1") continue;
                    else
                    {
                        Console.WriteLine("Sum of your cards: {0}\nSum of opponent's cards:{1} \n", counterPlayer, couterRival);
                        if (couterRival == counterPlayer) { Console.WriteLine("You have the same sums. It's a draw!"); break; }
                        if (couterRival > counterPlayer) Console.WriteLine("You lost this game!\a");
                        else Console.WriteLine("Congratulations on victory!\a");
                        break;
                    }
                } while (true);

                Console.WriteLine("Want to play again?");
                answer = Console.ReadLine();
                if (answer == "Yes") play = true;
                else play = false;
            } while (play);
        }
    }
}
