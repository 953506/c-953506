using System;

namespace Lab7
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1- Choose operator '+'" +
            "\n2- Choose operator '-'" +
            "\n3- Choose operator '*'" +
            "\n4- Choose operator '/'" +
            "\n5- Choose operator '<'" +
            "\n6- Choose operator '>'" +
            "\n7- Show Sort" +
            "\n8- Using Equals" +
            "\n9- exit");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program called Converter!" +
            "\nEnter two number as a fraction" +
            "\n* Use opertor '/' to separate two numbers ");
            string number = Console.ReadLine();
            Console.WriteLine("Now enter another number with the same syntax");
            string number2 = Console.ReadLine();
            string[] converter = number.Split('/');
            int[] numbers = new int[2];
            for (int i = 0; i < 2; i++)
                numbers[i] = Convert.ToInt32(converter[i]);
            Converter firstnum = new Converter(numbers[0], numbers[1]);
            converter = number2.Split('/');
            for (int i = 0; i < 2; i++)
                numbers[i] = Convert.ToInt32(converter[i]);
            Converter secondnum = new Converter(numbers[0],numbers[1]);
            Converter forcase1 = new Converter(2,3);
            Converter forcase2 = new Converter(3, 4);
            Converter[] mass = new Converter[] { firstnum, secondnum, forcase1, forcase2 };
            Menu();
            int choose = Convert.ToInt32(Console.ReadLine());
            switch(choose)
            {
                case 1: Console.WriteLine($"Their sum = {firstnum + secondnum}"); break;
                case 2: Console.WriteLine($"Their difference = {firstnum - secondnum}"); break;
                case 3: Console.WriteLine($"Their composition = {firstnum * secondnum}"); break;
                case 4: Console.WriteLine($"Their deviding = {firstnum / secondnum}"); break;
                case 5: Console.WriteLine($"{firstnum} < {secondnum} = {firstnum < secondnum}"); break;
                case 6: Console.WriteLine($"{firstnum} < {secondnum} = {firstnum > secondnum}"); break;
                case 7: Array.Sort(mass);
                foreach (var i in mass)
                    Console.WriteLine($"{i}");
                break;
                case 8: Console.WriteLine($"Equals: {firstnum.Equals(secondnum)}"); break;
                case 9: return;
            }

        }
    }
}
