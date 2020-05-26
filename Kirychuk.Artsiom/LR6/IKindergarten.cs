using System;
using System.Collections.Generic;
using System.Text;

namespace laba6
{
    interface IKindergarten : ICloneable, IComparable
    {
        //-------Свойства
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        double this[string choice] { get;}

        //--------Методы
        void KnowHealth();       
        void GetInfo();
        void Info();        
    }
}
