using System;
using System.Collections.Generic;
using System.Text;

namespace labr8
{
    class MarkCar : Car
    {
        enum Manufactured_countres
        {
            Germany,
            Japan,
            Russia,
            China,
            USA,
            UK,
            France,
            Italy,
            Belarus
        }

        private struct BasicData
        {
            public int weight, tank_volume, acceleration_time;
            public string engine_type, drive_unit;
        }

        private BasicData basicData;
        Manufactured_countres Country;
        private string _chassisType;
        public MarkCar(string mark, string model, string color, string chassisType, int country_choice) : base(mark, model, color)
        {
            if (chassisType == "wheeled" || chassisType == "tracked" || chassisType == "mixed" || chassisType == "magnetic cushion")
                _chassisType = chassisType;
            else _chassisType = "unknown";
            if (country_choice > 8) country_choice = 8;
            Country = (Manufactured_countres)country_choice;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"mark - {Mark}");
            Console.WriteLine($"model - {Model}");
            Console.WriteLine($"color - {Color}");
            Console.WriteLine($"manufacturer country - {Country}");
            Console.WriteLine($"chassis type - {_chassisType}");
            Console.WriteLine($"age - {Age}");
        }

        public override void AddBasicData()
        {
            Console.WriteLine("drive unit:");
            basicData.drive_unit = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("engine type:");
            basicData.engine_type = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("weight:");
            int.TryParse(Console.ReadLine(), out basicData.weight);
            Console.Clear();
            Console.WriteLine("tank volume:");
            int.TryParse(Console.ReadLine(), out basicData.tank_volume);
            Console.Clear();
            Console.WriteLine("acceleration time:");
            int.TryParse(Console.ReadLine(), out basicData.acceleration_time);
            Console.Clear();
        }

        public override void ShowBasicData()
        {
            Console.WriteLine($"drive unit: {basicData.drive_unit}");
            Console.WriteLine($"engine_type: {basicData.engine_type}");
            Console.WriteLine($"weight: {basicData.weight}");
            Console.WriteLine($"tank volume: {basicData.tank_volume}");
            Console.WriteLine($"acceleration time: {basicData.acceleration_time}");
        }
    }
}
