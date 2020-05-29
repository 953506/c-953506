using System;
using System.Collections.Generic;
using System.Text;

namespace labr8
{
    abstract class Car
    {
        private int _age;
        private string _color, _mark, _model;
        public static int productionYear;

        public Car(string mark, string model, string color)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = model;
            _color = color;
        }

        public Car(string mark)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = "uknown";
            _color = "uknown";
        }

        public Car(string mark, string model)
        {
            _age = 2020 - productionYear;
            _mark = mark;
            _model = model;
            _color = "uknown";
        }

        public string Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                _mark = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Age
        {
            get
            {
                return 2020 - productionYear;
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public string this[string choice]
        {
            get
            {
                switch (choice)
                {
                    case "mark": return _mark;
                    case "model": return _model;
                    case "color": return _color;
                    default: return null;
                }
            }
            set
            {
                switch (choice)
                {
                    case "mark": _mark = value; break;
                    case "model": _model = value; break;
                    case "color": _color = value; break;
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"mark - {_mark}");
            Console.WriteLine($"model - {_model}");
            Console.WriteLine($"color - {_color}");
            Console.WriteLine($"age - {_age}");
        }
        public virtual void AddBasicData() { }
        public virtual void ShowBasicData() { }
        ~Car() { }
    }
}
