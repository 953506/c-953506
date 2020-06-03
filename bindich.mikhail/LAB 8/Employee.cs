using System;

namespace _8
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

        public delegate void personDelegate(string message);
        public event personDelegate Notify;

        public int CompareTo(object o)
        {
            Employee e = o as Employee;
            if (e != null)
            {
                if (this.firstName.CompareTo(e.firstName) == 0 && this.lastName.CompareTo(e.lastName) == 0)
                {
                    Notify?.Invoke("Equal");
                    return 0;
                }
                if (this.firstName.CompareTo(e.firstName) == 0)
                {
                    Notify?.Invoke("Names are equal");
                    return 1;
                }
                if (this.lastName.CompareTo(e.lastName) == 0)
                {
                    Notify?.Invoke("Names are equal");
                    return 2;
                }
                else
                {
                    Notify?.Invoke("Not equal");
                    return -1;
                }
            }
            else
            {
                throw new ArgumentNullException("Second object is null");
            }
        }

        

        public void employeePrintInfo()
        {
            Notify?.Invoke("= = = = = = = = = =\nEmployee\n= = = = = = = = = =");
            Notify?.Invoke($"first name     || {this.firstName}");
            Notify?.Invoke($"last name      || {this.lastName}");
            Notify?.Invoke($"salary         || {this.salary}");
            Notify?.Invoke($"work plase     || {this.workPlace}");
            Notify?.Invoke($"position       || {this.position}");
            Notify?.Invoke($"speciality     || {this.speciality}");
            Notify?.Invoke("= = = = = = = = = = = = = = = = = = = = = = = = =\n");
        }


    }
}
