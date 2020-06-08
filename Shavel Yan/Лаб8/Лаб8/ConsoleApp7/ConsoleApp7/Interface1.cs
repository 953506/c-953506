using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    interface IComplainable
    {
        string PaysOrNot { get; set; }
        void Complain();

    }
}