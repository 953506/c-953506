using System;

namespace Laba5
{
    abstract class Car_Park_Person
    {
        protected struct Variable
        {
            public string _name;
            public string _surname;
        }

        protected Variable _variable;
        protected string _car_park;
        protected int _age;

        public Car_Park_Person(string name, string surname, string park, int age)
        {
            _variable._name = name;
            _variable._surname = surname;
            _car_park = park;
            _age = age;
        }

        public abstract void WriteCommonInformatoin();        
        public abstract void WriteCarParkInformation();
        public abstract void EnterImportantInformation();
        public abstract void WriteImportantInformation();
    }

    class Employee : Car_Park_Person
    {
        private string _Information;

        public Employee(string name, string surname, string park, int age)
               : base(name, surname, park, age) { }

        public override void WriteCommonInformatoin()
        {
            Console.WriteLine($"Name:{_variable._name}");
            Console.WriteLine($"Surname:{_variable._surname}");
            Console.WriteLine($"Age:{_age}");
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car park:{_car_park}");
        }
        public override void EnterImportantInformation()
        {
            _Information = Console.ReadLine();
        }

        public override void WriteImportantInformation()
        {
            
        }
    }  

    class Experienced_worker : Employee
    {
        private int _year_of_work;
        private string _merits = "none";

        public Experienced_worker (string name, string surname, string park, int age, int year_of_work) 
            : base(name, surname, park, age) 
        {
            _year_of_work = year_of_work;
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car Park:{_car_park}");
            Console.WriteLine($"Amount of work year:{_year_of_work}");
            Console.WriteLine($"Merits:{_merits}");
        }

        public override void EnterImportantInformation()
        {
            Console.WriteLine("Write merits about worker");
            _merits = Console.ReadLine();           
        }

    }

    class Director : Experienced_worker
    {
        private string _status;

        public Director(string name, string surname, string park, int age, int year_of_work, string status)
            : base(name, surname, park, age, year_of_work)
        {
            _status = status;
        }

        public override void WriteCarParkInformation()
        {
            Console.WriteLine($"Car Park:{_car_park}");
            Console.WriteLine($"Status:{_status}");        
        }

    }

    class Program
    {
        enum Interface
        {
            output_employee = 1,
            output_expirence_worker,
            input_expirence_worker,
            output_director,
            input_director,
            close_program,
        };

        static void Main(string[] args)
        {          
            int menu;
            Car_Park_Person employee = new Employee("Viktor","Buyukov","Break",18);
            Car_Park_Person experienced_worker = new Experienced_worker("Michail","Lukashevich","Break",27, 5);
            Car_Park_Person director = new Director("Big","Boss","Break",40,20,"director");

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
                    case (int)Interface.output_employee:
                        {
                            Console.Clear();
                            employee.WriteCommonInformatoin();
                            employee.WriteCarParkInformation();
                            employee.WriteImportantInformation();
                            break;
                        }

                    case (int)Interface.output_expirence_worker:
                        {
                            Console.Clear();
                            experienced_worker.WriteCommonInformatoin();
                            experienced_worker.WriteCarParkInformation();
                            experienced_worker.WriteImportantInformation();
                            break;
                        }

                    case (int)Interface.input_expirence_worker:
                        {
                            Console.Clear();
                            experienced_worker.EnterImportantInformation();
                            break;
                        }

                    case (int)Interface.output_director:
                        {
                            Console.Clear();
                            director.WriteCommonInformatoin();
                            director.WriteCarParkInformation();
                            director.WriteImportantInformation();
                            break;

                        }

                    case (int)Interface.input_director:
                        {

                            Console.Clear();
                            director.EnterImportantInformation();
                            break;
                        }

                    case (int)Interface.close_program: return;
                    default: return;
                }

            }
        }
    }
}
