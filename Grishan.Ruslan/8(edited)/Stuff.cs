using System;
using System.Collections.Generic;
using System.Text;

namespace LABA8
{
    class Stuff
    {
        protected delegate int VichetRasxod(int x, int y, int z);
        protected VichetRasxod rasxodnik = (x, y, z) => (x * y) + z;
        protected bool work;
        public string Name { get; set; }
        public int Rasxod { get; set; }
        public int Zarplata { get; set; }
        public int Personal { get; set; }
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
