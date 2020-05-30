using System;
using System.Collections;
using System.Collections.Generic;

namespace labr8
{
    class BusComparer : IComparer<Bus>
    {
        public int Compare(Bus a, Bus b)
        {
            if (a.FuelConsumption > b.FuelConsumption)
                return 1;
            else if (a.FuelConsumption < b.FuelConsumption)
                return -1;
            else return 0;
        }
    }

    delegate void ShowInfo();
    delegate int Calculator(int miles, int fuel);

    class Program
    {
        static void Main()
        {
            uint choice;
            var Bus1 = new Bus("Mercedes", "A100", "Blue", "Wheel", 1, 90, 10, 15);
            ShowInfo show = Bus1.ShowInfo;
            var Bus2 = new Bus("MAZ", "103", "Green", "Wheel", 8, 95, 5, 18);
            show += Bus2.ShowInfo;
            var Bus3 = new Bus("Radzimich", "92", "Yellow", "Wheel", 8, 100, 0, 9);
            show += Bus3.ShowInfo;
            var Bus4 = new Bus("Neman", "88", "White", "Wheel", 8, 95, 0, 7);
            show += Bus4.ShowInfo;
            show();

            Bus1.Notify += DisplayMessage;
            Bus2.Notify += DisplayMessage;
            //Delegate + event JOB
            try
            {
                choice = Convert.ToUInt32(Console.ReadLine());
                if (choice > 4)
                {
                    throw new Exception("Choose int in range of 1-4");
                }
                Bus1.TakeJob(choice);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Bus1.RemoveJob();
            Bus2.GetRandomJob();

            //Calculate fuel compsution
            Calculator calc = (miles, fuel) => miles * fuel;
            Console.WriteLine( calc(Convert.ToInt32(Console.ReadLine()), Bus1.FuelConsumption) );

            //calculate Distance of travel
            Calculator milesCalculator = delegate (int miles, int fuel)
            {
                return Bus1.MaxSpeed * miles * fuel;
            };
            Console.WriteLine(milesCalculator(Convert.ToInt32(Console.ReadLine()), Bus1.FuelConsumption));
        }
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
