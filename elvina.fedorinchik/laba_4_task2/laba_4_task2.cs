using System;
using System.Runtime.InteropServices;

namespace laba_4_task2
{
    class Program
    {
        [DllImport("C:\\Users\\Elvina\\Documents\\VisualStudio\\\\Projects\\MyDLL\\Win32\\Debug\\Project1.dll")]
        public static extern double boddyMassIndex(double weight, double heigth);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height:");
            double heigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your weight:");
            double weigth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(boddyMassIndex(weigth, heigth));
        }
    }
}