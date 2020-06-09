using System;
using System.Collections.Generic;
using System.Text;

namespace intrfc6
{
    interface IStuff
    {
        string Name { get; }
        int Personal { get; }
        int Zarplata { get; }
        int Rasxod { get; }
        void Working();
    }

    interface IMagazine
    {
        string Name { get; }
        int viruchka { get; }
        int Rasxod { get; }
        void Working();
    }
}
