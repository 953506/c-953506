using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int Score = 0;
        int checkCellValues = 0;
        int Zero = 0;
        static void Main(string[] args)
        {
            int[,] PlayWindow = new int[4, 4];
            Nulling(PlayWindow);

            PlayWindow[0, 0] = 2;
            PlayWindow[1, 0] = 2;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{PlayWindow[i, j]} \t");
                Console.WriteLine();
            }
            bool ExitCondition = true;
            ConsoleKey Button;
            while (ExitCondition)
            {

                Button = Console.ReadKey().Key;
                switch (Button)
                {
                    case ConsoleKey.UpArrow:
                        {
                            Upping(PlayWindow);
                            NewElement(PlayWindow);
                            break;
                        }
                    case ConsoleKey.LeftArrow:
                        {
                            Lefting(PlayWindow);
                            NewElement(PlayWindow);
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            Downing(PlayWindow);
                            NewElement(PlayWindow);
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            Righting(PlayWindow);
                            NewElement(PlayWindow);
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            ExitCondition = false;
                            break;
                        }

                }
                if (checkCellValues == 1 || Zero != 0)
                {
                    getMass(PlayWindow);
                    checkCellValues = 0;
                }
                else
                {
                    getLoos(PlayWindow);
                    return;
                }

            }
        }

        static void getMass(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{arr[i, j]} \t");
                Console.WriteLine();
            }
            Console.WriteLine($"\n\t Score = {Score}");
            Console.Write("\t Us arrow to move\n\tPress Esc to exit");
        }

        static void getLoos(int[,] arr)
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{arr[i, j]} \t");
                Console.WriteLine();
            }
            Console.WriteLine($"\n\t Score = {Score}");
            Console.Write("\t GAME OVER!!! GG");
        }

        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Upping(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
                for (int j = 0; j < 4; j++)
                    for (int i = 3; i > 0; i--)
                        if (arr[i - 1, j] == 0)
                            Swap(ref arr[i, j], ref arr[i - 1, j]);
            for (int j = 0; j < 4; j++)
                for (int i = 0; i < 3; i++)
                    if (arr[i, j] == arr[i + 1, j])
                    {
                        Score += arr[i, j];
                        arr[i, j] *= 2;
                        arr[i + 1, j] = 0;
                        i++;
                    }
            for (int k = 0; k < 2; k++)
                for (int i = 3; i > 0; i--)
                    for (int j = 0; j < 4; j++)
                        if (arr[i - 1, j] == 0)
                            Swap(ref arr[i, j], ref arr[i - 1, j]);
        }

        static void Lefting(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
                for (int i = 0; i < 4; i++)
                    for (int j = 3; j > 0; j--)
                        if (arr[i, j - 1] == 0)
                            Swap(ref arr[i, j], ref arr[i, j - 1]);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 3; j++)
                    if (arr[i, j] == arr[i, j + 1])
                    {
                        Score += arr[i, j];
                        arr[i, j] *= 2;
                        arr[i, j + 1] = 0;
                        j++;
                    }
            for (int k = 0; k < 2; k++)
                for (int j = 3; j > 0; j--)
                    for (int i = 0; i < 4; i++)
                        if (arr[i, j - 1] == 0)
                            Swap(ref arr[i, j], ref arr[i, j - 1]);
        }

        static void Righting(int[,] arr)
        {
            for (int k = 0; k < 3; k++)
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 3; j++)
                        if (arr[i, j + 1] == 0)
                            Swap(ref arr[i, j], ref arr[i, j + 1]);
            for (int i = 0; i < 4; i++)
                for (int j = 3; j > 0; j--)
                    if (arr[i, j] == arr[i, j - 1])
                    {
                        Score += arr[i, j];
                        arr[i, j] *= 2;
                        arr[i, j - 1] = 0;
                        j--;
                    }
            for (int k = 0; k < 2; k++)
                for (int j = 0; j < 3; j++)
                    for (int i = 0; i < 4; i++)
                        if (arr[i, j + 1] == 0)
                            Swap(ref arr[i, j], ref arr[i, j + 1]);
        }

        static void Downing(int[,] arr)
        {

            for (int k = 0; k < 3; k++)
                for (int j = 0; j < 4; j++)
                    for (int i = 0; i < 3; i++)
                        if (arr[i + 1, j] == 0)
                            Swap(ref arr[i, j], ref arr[i + 1, j]);
            for (int j = 0; j < 4; j++)
                for (int i = 3; i > 0; i--)
                    if (arr[i, j] == arr[i - 1, j])
                    {
                        Score += arr[i, j];
                        arr[i, j] *= 2;
                        arr[i - 1, j] = 0;
                        i--;
                    }

            for (int k = 0; k < 2; k++)
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                        if (arr[i + 1, j] == 0)
                            Swap(ref arr[i, j], ref arr[i + 1, j]);
        }

        static void Nulling(int[,] arr)
        {

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    arr[i, j] = 0;
        }

        static void NewElement(int[,] arr)
        {
            Zero = 0;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (arr[i, j] == 0)
                        Zero++;
            if (Zero > 0)
            {
                Random rand = new Random();
                while (true)
                {
                    int k = rand.Next(0, 16);
                    int i = k % 4;
                    int j = k / 4;
                    if (arr[i, j] == 0)
                    {
                        int b = rand.Next(0, 9);
                        if (b == 0)
                            arr[i, j] = 4;
                        else
                            arr[i, j] = 2;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 4; j++)
                        if (arr[i, j] == arr[i + 1, j])
                        {
                            checkCellValues++;
                            return;
                        }
                for (int i = 0; i < 4; i++)
                    for (int j = 0; j < 3; j++)
                        if (arr[i, j] == arr[i, j + 1])
                        {
                            checkCellValues++;
                            return;
                        }
            }
        }
    }
}