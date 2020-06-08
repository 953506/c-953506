using System;

namespace Lab7
{
    class Program
    {

        public static void Menu()
        {
            Console.WriteLine("1-  '+'" +
            "\n2-  '-'" +
            "\n3-  '*'" +
            "\n4-  '/'" +
            "\n5-  '<'" +
            "\n6-  '>'" +
            "\n7- Show Sort" +
            "\n8- Equals?" +
            "\n9- Convert to double" +
            "\n10- exit");
        }

        static void Main()
        {
            Console.WriteLine("Welcome!" +
            "\nEnter 2 number as a fraction" +
            "\n* Use '/' to separate numbers ");
            string number = Console.ReadLine();
            Console.WriteLine("Enter another number with the same syntax");
            string number2 = Console.ReadLine();
            Converter.ToConverter(number, out Converter firstnum);
            Converter.ToConverter(number2, out Converter secondnum);
            Converter forcase1 = new Converter(2, 3);
            Converter forcase2 = new Converter(3, 4);
            Converter[] mass = new Converter[] { firstnum, secondnum, forcase1, forcase2 };
            Menu();
            int choose;
            do
            {
                 choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1: Console.WriteLine($"Sum = {firstnum + secondnum}"); break;
                    case 2: Console.WriteLine($"Difference = {firstnum - secondnum}"); break;
                    case 3: Console.WriteLine($"Composition = {firstnum * secondnum}"); break;
                    case 4: Console.WriteLine($"Deviding = {firstnum / secondnum}"); break;
                    case 5: Console.WriteLine($"{firstnum} < {secondnum} = {firstnum < secondnum}"); break;
                    case 6: Console.WriteLine($"{firstnum} < {secondnum} = {firstnum > secondnum}"); break;
                    case 7:
                        Array.Sort(mass);
                        foreach (var i in mass)
                            Console.WriteLine($"{i}");
                        break;
                    case 8: Console.WriteLine($"Equals: {firstnum.Equals(secondnum)}"); break;
                    case 9:
                        double one = (double)firstnum; Console.WriteLine($"{one} : {firstnum}");
                        double two = secondnum; Console.WriteLine($"{two} : {secondnum}"); break;
                    case 10: return;
                }
            } while (choose != 10);
            Console.ReadLine();
        }
    }
}