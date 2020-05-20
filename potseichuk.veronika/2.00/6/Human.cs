using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    abstract class Human: IComplainable
    {
        string _name;
        string _lastname;
        int _age;

        public int Age
        {
            get
            { return _age; }
            set
            {
                if (value > 35) _age = 35;
                else if (value < 17) _age = 17;
                else _age = value;
            }
        }

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "name": return _name;
                    case "lastname": return _lastname;
                    default: return null;
                }
            }
            set
            {
                switch (propname)
                {
                    case "name":
                        _name = value;
                        break;
                    case "lastname":
                        _lastname = value;
                        break;
                }
            }
        }

        public Human(string name, string lastname, int age)
        {
            this.Age = age;
            this["name"] = name;
            this["lastname"] = lastname;
        }

        public virtual void Display()
        {
            Console.WriteLine("{0} {1} (возраст {2} лет)", this["lastname"], this["name"], Age);
        }

        public virtual void Complain()
        {
            Console.WriteLine("Опять дождь!");
        }
    }
}

