using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StudentIITP : Student
    {
        protected new int _group;

    public StudentIITP()
    {
            _faculty = "ФКСиС";
            _specialty = "Информатика и технологии программирования";
            _course = 1;
            _group = 953506;
    }

        public delegate void Iferer();
        public Iferer ex2;

        public new int Group
        {
            get
            {
                return _group;
            }
            set
            {
                switch (_course)
                {
                    case 1:
                        {
                            if (value > 953501 && value < 953506)
                            {
                                value = _group;
                            }
                            else
                            {
                                Console.WriteLine("Group Enter is not correct ");
                                Environment.Exit(0);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (value > 853501 && value < 853505)
                            {
                                value = _group;
                            }
                            else
                            {
                                Console.WriteLine("Group Enter is not correct ");
                                Environment.Exit(0);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (value > 753501 && value < 753505)
                            {
                                value = _group;
                            }
                            else
                            {
                                Console.WriteLine("Group Enter is not correct ");
                                Environment.Exit(0);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (value > 653501 && value < 653503)
                            {
                                value = _group;
                            }
                            else
                            {
                                Console.WriteLine("Group Enter is not correct ");
                                Environment.Exit(0);
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Course Enter is not correct ");
                            Environment.Exit(0);
                            break;
                        }
                }
            }

        }
        public void Ifer()
        {
            if (this._faculty == "ФКСиС" && _specialty == "Информатика и технологии программирования" && _course == 1 && _group == 953506)
            {
                ex2 = Yes;
            }
            else
            {
                ex2 = No;
            }
        }
        public void Yes()
        {
            Console.WriteLine("An instance of the class was not created");
        }
        public void No()
        {
            Console.WriteLine("An instance of the class was created");
        }
        public override void Cout()
                {
                    Console.WriteLine("Information about Student");
                    Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
                    Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
                    Console.WriteLine($"Profession:{_profession}");
                    Console.WriteLine($"Faculty:{_faculty}, Specialty:{_specialty}");
                    Console.WriteLine($"Group:{_group}, Course:{_course}, serial number: the{_number} ");
                }
           

    }
}
