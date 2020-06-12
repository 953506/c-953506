using System;
using System.Collections.Generic;
using System.Text;

namespace intrfc6
{
    abstract class Magazine
    {
        protected bool work;
        public string Name { get; set; }
        public int viruchka { get; set; }
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

    class Products : Magazine, IMagazine
    {
        public Products()
        {
            Name = "Evroopt";
            work = true;
            Money();
        }

        private void Money()
        {
            if (work == true)
            {
                viruchka = 150000;
                Rasxod = 30000;
            }
            else
            {
                viruchka = 0;
                Rasxod = 0;
            }
        }
    }

    class Shawerma : Magazine, IMagazine
    {
        public Shawerma()
        {
            Name = "Doner House";
            work = true;
            Money();
        }

        private void Money()
        {
            if (work == true)
            {
                viruchka = 50000;
                Rasxod = 5000;
            }
            else
            {
                viruchka = 0;
                Rasxod = 0;
            }
        }
    }
}
