using System;

namespace _5
{
    public class Employee : Human
    {
        public int salary;
        public string workPlace;
        public string position;
        public string speciality;

        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            salary = 0;
            workPlace = "";
            position = "";
            speciality = "";
        }

        public override void doWork()
        {
            int tmp = goToWork();
            if (tmp == 0)
            {
                tmp = doJob();
            }
            if (tmp == 0)
            {
                getSalary();
            }
        }

        private int goToWork()
        {
            return 0;
        }

        private int doJob()
        {
            return 0;
        }

        private int getSalary()
        {
            return 0;
        }

        public void employeePrintInfo()
        {
            Console.WriteLine("= = = = = = = = = =\nPerson\n= = = = = = = = = =");
            Console.WriteLine($"first name     || {this.firstName}");
            Console.WriteLine($"last name      || {this.lastName}");
            Console.WriteLine($"height         || {this.height}");
            Console.WriteLine($"weight         || {this.weight}");
            Console.WriteLine($"salary         || {this.salary}");
            Console.WriteLine($"position       || {this.position}");
            Console.WriteLine($"speciality     || {this.speciality}");
            Console.WriteLine("= = = = = = = = = =");
        }
    }
}
