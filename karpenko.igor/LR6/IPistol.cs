using System;
using System.Collections.Generic;
using System.Text;

namespace z1
{
    interface IPistol
    {
        void Zaryad();
        void Default()
        {
            Console.WriteLine("По умолчанию");
        }
    }
}
