using System;
using System.Collections.Generic;
using System.Text;

namespace LABA8
{
    class Security : Stuff, IStuff
    {
        public Security()
        {
            Zarplata = 40;
            Name = "Security";
            Personal = 30;
            work = false;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = rasxodnik(Personal, Zarplata, 500);
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
            Zarplata = 20;
            Name = "Electro";
            Personal = 2;
            work = true;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = rasxodnik(Personal, Zarplata, 500);
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
            Zarplata = 10;
            Name = "Toilet";
            Personal = 7;
            work = true;
            Money();
        }
        private void Money()
        {
            if (work == true)
            {
                Rasxod = rasxodnik(Personal, Zarplata, 300);
            }
            else
            {
                Rasxod = 0;
            }
        }
    }
}
