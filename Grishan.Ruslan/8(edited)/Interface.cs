using System;
using System.Collections.Generic;
using System.Text;

namespace LABA8
{
    interface IStuff
    {
        string Name { get; }
        int Personal { get; }
        int Zarplata { get; }
        int Rasxod { get; }
        void Working();
    }
    interface IShop
    {
        string Name { get; }
        int Viruchka { get; }
        int Rasxod { get; }
        void Working();
    }
}
