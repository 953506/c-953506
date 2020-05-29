using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    struct Work
    {
        string _placeOfWork;
        string _position;
        int _salary;

        public string PlaceOfWork { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public void Money()
        {
            Console.WriteLine("Enter your monthly salary(in $):\n");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
    }
}