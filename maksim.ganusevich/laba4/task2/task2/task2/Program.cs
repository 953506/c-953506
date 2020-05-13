using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CppString;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding ascii = Encoding.ASCII;

            int lenght = 10;
            string unicStr1 ="qwertuiop";
            string unicStr2 = "asdfghjkl";

            Byte [] encodedBytes1 = ascii.GetBytes(unicStr1);
            Byte[] encodedBytes2 = ascii.GetBytes(unicStr2);
            ushort[] ustr1 = new ushort[lenght];
            ushort[] ustr2 = new ushort[lenght];

            foreach (int i in encodedBytes1)
                ustr1[i] = encodedBytes1[i];
            foreach (int i in encodedBytes1)
                ustr2[i] = encodedBytes2[i];

            foreach (int i in encodedBytes1)
                Console.WriteLine(encodedBytes1[i]);

            unsafe
            {
                fixed (ushort* str1 = &ustr1[0]) 
                {
                    MyCppString sppStr = new MyCppString(str1, lenght);
                    fixed(ushort* str2 = &ustr2[0])
                    {
                        Console.WriteLine(sppStr.Comparison(str2, lenght)?"Стороки совпадают":"Строки не совпадают");
                        sppStr.Add(str2, lenght);
                        Console.WriteLine(sppStr.Comparison(str2, lenght) ? "Стороки совпадают" : "Строки не совпадают");
                    }
                } 
            }
            Console.ReadLine();
        }
    }
}
