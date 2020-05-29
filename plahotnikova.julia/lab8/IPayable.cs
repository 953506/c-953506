using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public interface IPayable
    {
        int Money { get; }
        void Rise(int money);
        void Lose(int money);
    }
}