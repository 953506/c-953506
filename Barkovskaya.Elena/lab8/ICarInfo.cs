using System;
using System.Collections.Generic;
using System.Text;

namespace labr8
{
    public interface ICarInfo
    {
        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int FuelConsumption { get; set; }
    }
}
