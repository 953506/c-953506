using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var begin = Convert.ToUInt64(Console.ReadLine());
            var end = Convert.ToUInt64(Console.ReadLine());
            begin--;
            ulong counter = 0;
            
            while (end > 1) 
            {
                ulong counter0 = 1;

                while (end - counter0>=counter0) 
                {
                    counter0 *= 2;
                }
                
                end -= counter0;
                counter += (counter0 - 1);
            }

            while (begin > 1)
            {
                ulong counter0 = 1;

                while (begin - counter0>=counter0)
                {
                    counter0 *= 2;
                }
     
                begin -= counter0;
                counter -= (counter0 - 1);
            }
            if (counter >= 0)
                Console.WriteLine(Convert.ToString(counter));
            else Console.WriteLine(0);
        }
    }
}
