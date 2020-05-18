using System;

namespace _6
{
    public class Employee : Human, IComparable
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

        new public void doWork()
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

        public int CompareTo(object o)
        {
            Employee e = o as Employee;
            if (e != null)
            {
                if (this.firstName.CompareTo(e.firstName) == 0 && this.lastName.CompareTo(e.lastName) == 0)
                {
                    Console.WriteLine("Equal");
                    return 0;
                }
                if (this.firstName.CompareTo(e.firstName) == 0)
                {
                    Console.WriteLine("Names are equal");
                    return 1;
                }
                if (this.lastName.CompareTo(e.lastName) == 0)
                {
                    Console.WriteLine("Names are equal");
                    return 2;
                }
                else
                {
                    Console.WriteLine("Not equal");
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("Can't compare two objects");
                return -2;
            }
        }

        public void employeePrintInfo()
        {
            Console.WriteLine("= = = = = = = = = =\nPerson\n= = = = = = = = = =");
            Console.WriteLine($"first name     || {this.firstName}");
            Console.WriteLine($"last name      || {this.lastName}");
            Console.WriteLine($"salary         || {this.salary}");
            Console.WriteLine($"work plase     || {this.workPlace}");
            Console.WriteLine($"position       || {this.position}");
            Console.WriteLine($"speciality     || {this.speciality}");
            Console.WriteLine("= = = = = = = = = = = = = = = = = = = = = = = = =");
        }
    }
}
