using System;
using System.Collections.Generic;
using System.Text;

namespace intrfc6
{
    abstract class Stuff
    {
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

    class Security : Stuff, IStuff
    {
        public Security()
        {
            Zarplata = 400;
            Personal = 30;
            Name = "Security";
            work = false;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = Personal * Zarplata;
            }
            else
            {
                Rasxod = 0;
            }
        }
    }

    class Electro : Stuff, IStuff
    {
        public Electro()
        {
            Name = "Electro";
            Zarplata = 200;
            Personal = 2;
            work = true;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = Personal * Zarplata;
            }
            else
            {
                Rasxod = 0;
            }
        }
    }

    class Toilet : Stuff, IStuff
    {
        public Toilet()
        {
            Name = "Toilet";
            Zarplata = 10;
            Personal = 7;
            work = true;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = Personal * Zarplata;
            }
            else
            {
                Rasxod = 0;
            }
        }
    }
}
