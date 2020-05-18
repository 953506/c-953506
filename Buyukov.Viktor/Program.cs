using System;

namespace Laba5
{
    abstract class CarParkPerson
    {
        protected struct Variable
        {
            public string nname;
            public string ssurname;
        }

        protected Variable variable;
        protected string carPark;
        protected int age;

        public CarParkPerson(string name, string surname, string park, int age)
        {
            variable.nname = name;
            variable.ssurname = surname;
            carPark = park;
            this.age = age;
        }

        public abstract void WriteCommonInformatoin();
        public abstract void WriteCarParkInformation();
        public abstract void EnterImportantInformation();
        public abstract void WriteImportantInformation();
    }

    class Employee : CarParkPerson
    {
        private string _information;

        public Employee(string name, string surname, string park, int age)
               : base(name, surname, park, age) { }

        public override void WriteCommonInformatoin()
        {
            Console.WriteLine($"Name:{variable.nname}");
            Console.WriteLine($"Surname:{variable.ssurname}");
            Console.WriteLine($"Age:{age}");
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car park:{carPark}");
        }
        public override void EnterImportantInformation()
        {
            _information = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {

        }
    }

    class ExperiencedWorker : Employee
    {
        private int _yearOfWork;
        private string _merits = "none";

        public ExperiencedWorker(string name, string surname, string park, int age, int yearOfWork)
            : base(name, surname, park, age)
        {
            _yearOfWork = yearOfWork;
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car Park:{carPark}");
            Console.WriteLine($"Amount of work year:{_yearOfWork}");
            Console.WriteLine($"Merits:{_merits}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Write merits about worker");
            _merits = Console.ReadLine();
        }

    }

    class Director : ExperiencedWorker
    {
        private string _status;

        public Director(string name, string surname, string park, int age, int yearOfWork, string status)
            : base(name, surname, park, age, yearOfWork)
        {
            _status = status;
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car Park:{carPark}");
            Console.WriteLine($"Status:{_status}");
        }

    }

    class Program
    {
        enum Interface
        {
            outputEmployee = 1,
            outputExpirenceWorker,
            inputExpirenceWorker,
            outputDirector,
            inputDirector,
            closeProgram,
        };

        static void Main(string[] args)
        {
            int menu;
            CarParkPerson employee = new Employee("Viktor", "Buyukov", "Break", 18);
            CarParkPerson experiencedWorker = new ExperiencedWorker("Michail", "Lukashevich", "Break", 27, 5);
            CarParkPerson director = new Director("Big", "Boss", "Break", 40, 20, "director");

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1-output information about employee");
                Console.WriteLine("2-output information about expirence worker");
                Console.WriteLine("3-input information about expirence worker");
                Console.WriteLine("4-output information about director");
                Console.WriteLine("5-input information about director");
                Console.WriteLine("6-close program");

                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case (int)Interface.outputEmployee:
                        {
                            Console.Clear();
                            employee.WriteCommonInformatoin();
                            employee.WriteCarParkInformation();
                            employee.WriteImportantInformation();
                            break;
                        }

                    case (int)Interface.outputExpirenceWorker:
                        {
                            Console.Clear();
                            experiencedWorker.WriteCommonInformatoin();
                            experiencedWorker.WriteCarParkInformation();
                            experiencedWorker.WriteImportantInformation();
                            break;
                        }

                    case (int)Interface.inputExpirenceWorker:
                        {
                            Console.Clear();
                            experiencedWorker.EnterImportantInformation();
                            break;
                        }

                    case (int)Interface.outputDirector:
                        {
                            Console.Clear();
                            director.WriteCommonInformatoin();
                            director.WriteCarParkInformation();
                            director.WriteImportantInformation();
                            break;
                        }

                    case (int)Interface.inputDirector:
                        {
                            Console.Clear();
                            director.EnterImportantInformation();
                            break;
                        }
                        
                    case (int)Interface.closeProgram: return;
                    default: return;
                }

            }
        }
    }
}
