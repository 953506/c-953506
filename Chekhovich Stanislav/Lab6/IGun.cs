﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IGun : IFirearm
    {
        void UltimateAbility();
        void GetInfoAboutType();
    }
}
