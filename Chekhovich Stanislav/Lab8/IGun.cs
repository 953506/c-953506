using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    interface IGun : IFirearm, IComparable
    {
        public event ArgumentExceptionHandler Notify;
        void UltimateAbility();
        void GetInfoAboutType();
    }
}
