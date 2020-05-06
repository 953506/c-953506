using System;

namespace laba_2_task3
{

    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1.ToString());
            Console.Write(date1.ToLongDateString());
            Console.WriteLine(date1.ToLongTimeString());
            string date2 = DateTime.Now.ToString();
            int number = 0;
            for (char num = '0'; num <= '9'; num++)
            {
                for (int chislo = 0; chislo < date2.Length; chislo++)
                {
                    if (date2[chislo] == num) number++;
                }
                Console.WriteLine("{0}:{1}", num, number);
                number = 0;
            }
        }
    }
}