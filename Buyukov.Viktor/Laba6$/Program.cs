using System;
using System.Collections.Generic;
using System.Text;
namespace Laba6New
{
    interface ICar_Park_Person
    {
        string _name { get; }
        string _surname { get; }
        string _car_park { get; }
        int _age { get; }
        public string ImportantInformation { get; }

        void WriteCommonInformation();
        void EnterImportantInformation();
        void WriteImportantInformation();

    }

    abstract class Car_Park_Person : ICar_Park_Person
    {
        public string _name { get; }
        public string _surname { get; }
        public string _car_park { get; }
        public int _age { get; }
        public string ImportantInformation { get; }

        public Car_Park_Person(string name, string surname, string park, int age)
        {
            _name = name;
            _surname = surname;
            _car_park = park;
            _age = age;
        }

        public abstract void WriteCommonInformation();
        public abstract void WriteCarParkInformation();
        public abstract void EnterImportantInformation();
        public abstract void WriteImportantInformation();
    }

    interface IDirector
    {
      string _status { get; } 
      string _information { get; set; }

      void Put_Hours_of_Work(Worker worker);
    }

    class Director : Car_Park_Person
    {
        public string _status;
        public string _information { get; set; }

        public Director(string name, string surname, string park, int age, string status)
            : base(name, surname, park, age)
        {
            _status = status;
        }

        public override void WriteCommonInformation()
        {
            Console.WriteLine($"Name:{_name}");
            Console.WriteLine($"Surname:{_surname}");
            Console.WriteLine($"Age:{_age}");
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car park:{_car_park}");
        }
        public override void EnterImportantInformation()
        { 

            _information = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {

        }

        public void Put_Hours_of_Work(Worker worker)
        {
            worker._money = Convert.ToInt32(Console.ReadLine());
        }
    }

    interface IWorker
    {
        public string _specialty { get; set; }
        public int _money { get; set; }
        string _information { get; set; }
        void Min();
    }

    class Worker : Car_Park_Person,IWorker,ICloneable 
    {
        public string _specialty { get; set; }
        public string _information { get; set; }
        public int _money { get; set; } 

        public Worker(string name, string surname, string park, int age, string specialty, int _money)
           : base(name, surname, park, age)
        {
            _specialty = specialty;
            this._money = _money;
        }

        public void Min()
        {
            Console.WriteLine($"His amount of money:{_money}");
            if (Can_you_survive())        
                Console.WriteLine("Good, that enough");
            else
                Console.WriteLine("He don't survive");
            
        }

        private bool Can_you_survive()
        {
            if (_money > 240)
                return true;
            else 
                return false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override void WriteCommonInformation()
        {
            Console.WriteLine($"Name:{_name}");
            Console.WriteLine($"Surname:{_surname}");
            Console.WriteLine($"Age:{_age}");
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car park:{_car_park}");
        }
        public override void EnterImportantInformation()
        {
            _information = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {
            Console.WriteLine($"Information about worker : {_information}");
        }
    }

    class Workers : IComparer<IWorker>
    {
        Worker[] work;

        public Workers()
        {
            work = new Worker[10];
        }

        public Worker this[int index]
        {
            get
            {
                return work[index];
            }

            set
            {
                work[index] = value;
            }
        }

        public int Compare(IWorker w1, IWorker w2)
        {
            if (w1._money > w2._money)
                return 1;
            else if (w1._money < w2._money)
                return -1;
            else
                return 0;
        }

        public void Rating()

        {

            for (int i = 1; i < 10; i++)
                for (int j = 0; j < 9; j++)
                    if (Compare(work[j + 1], work[j]) == 1)
                    {
                        Worker st = (Worker)work[j].Clone();
                        work[j] = (Worker)work[j + 1].Clone();
                        work[j + 1] = (Worker)st.Clone();
                    }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{work[i]._name} {work[i]._surname} - ({work[i]._money})");
            }
        }



    }
}
