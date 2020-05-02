using System;

namespace Laba_3
{
    class Car 
    {
        private int Cost;
        private string Name;
        private string Number;

        static public int Check(string stroka)
        {
            bool isNumber = false;
            int chislo = 0;
            while (!isNumber)
            {
                foreach (char element in stroka)
                {
                    if (!char.IsDigit(element))
                    {
                       break;
                    }
                    else isNumber = true;
                }

                    if (isNumber)
                    {
                        chislo = Convert.ToInt32(stroka);
                        return chislo;
                    }
                    else 
                    {
                        Console.Write("\nEnter information again = ");
                        stroka = Console.ReadLine();
                    }
                
            }
            return chislo;
        }

        public void Input(int Elements_Objects)
        {
            AutoPark inter = new AutoPark(Elements_Objects);

            for (int n = 0; n < Elements_Objects; n++) 
            {
                string Uses_string;

                inter[n] = new Car { };

                Console.Write("\nWrite car number = ");
                inter[n].Number = Console.ReadLine();

                Console.Write("Write car name = ");
                inter[n].Name = Console.ReadLine();

                Console.Write("Write cost of your car = ");
                Uses_string = Console.ReadLine();

                inter[n].Cost = Check(Uses_string);

            }

            Console.Clear();
            for (int n = 0; n < Elements_Objects; n++)
            {
                Output(inter[n].Name, inter[n].Number);
                Output(inter[n].Cost);
            }
            
        }

        private void Output(string Name, string Number)
        {
            Console.Write($"\nWrite car name = {Name}");
            Console.Write($"\nWrite car number = {Number}");
        }

        private void Output(int Cost)
        {
            Console.Write($"\nWrite car cost = {Cost}\n\n");
        }

    }

    class AutoPark
    {       
        Car[] Park;
        public AutoPark(int Elements_Object)
        {
            Park = new Car[Elements_Object];           

        }
        
        public Car this[int index]
        {
            get
            {
                return Park[index];
            }
            set
            {
                Park[index] = value;
            }
        }

        public AutoPark()
        {
            Car work = new Car();

            string work_string;
            int elements_of_massive;

            Console.Write("Write number elements of massiv = ");
            work_string = Console.ReadLine();
            elements_of_massive = Car.Check(work_string);


            work.Input(elements_of_massive);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AutoPark start = new AutoPark();            
        }
    }
}
