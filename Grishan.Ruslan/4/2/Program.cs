using System;
using System.Runtime.InteropServices;

namespace DllUse
{
    class Program
    {
        [DllImport("C:\\Users\\User\\Documents\\RAD Studio\\Projects\\Debug\\Win32\\lib.dll")] 
        public static extern int Squaring(int n);

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Squaring(n));
        }
    }
}
