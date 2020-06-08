using System;
using System.Collections.Generic;
using System.Text;

namespace LABA8
{
    class Shop
    {
        protected bool work;
        public string Name { get; set; }
        public int Viruchka { get; set; }
        public int Rasxod { get; set; }
        public void Working()
        {
            if (work == true)

            {
                Open();
            }
            else Closed();
        }
        public void Open()
        {
            Console.WriteLine("OPEN");
        }
        public void Closed()
        {
            Console.WriteLine("CLOSED");
        }
    }
}
