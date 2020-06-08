using System;
using System.Collections.Generic;
using System.Text;

namespace LABA8
{
    class Products : Shop, IShop
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
                Viruchka = 150000;
                Rasxod = 30000;
            }
            else
            {
                Viruchka = 0;
                Rasxod = 0;
            }
        }
    }
    class Shawerma : Shop, IShop
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
                Viruchka = 50000;
                Rasxod = 5000;
            }
            else
            {
                Viruchka = 0;
                Rasxod = 0;
            }
        }
    }
}
