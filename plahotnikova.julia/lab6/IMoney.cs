using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IMoney
    {
        int Money { get; }
        void Rise(int money);
        void Lose(int money);
    }
}
