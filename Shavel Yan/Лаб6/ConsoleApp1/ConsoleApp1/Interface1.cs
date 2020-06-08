using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    interface IComplainable
    {
        string PaysOrNot { get; set; }
        void Complain();

    }
}