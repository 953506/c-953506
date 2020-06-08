using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student:Human
    {
        //поле
        protected string _faculty, _specialty, _number;
        protected int _group, _course;

        //конструктор
        public Student()
        {
            _faculty = "ФКСиС";
            _specialty = "Информатика и технологии программирования";
            _number = "Third";
            _group = 6;
            _course = 1;
        }
        public Student(string faculty) :this()
        {
            _faculty = faculty;
        }
        public Student(string faculty, string specialty) : this(faculty)
        {
            _faculty = faculty;
            _specialty = specialty;
        }
        public Student(string faculty, string specialty , int group) : this(faculty, specialty)
        {
            _faculty = faculty;
            _specialty = specialty;
            _group = group;
        }
        public Student(string faculty, string specialty, int group, int course, string _number) : this(faculty, specialty, group)
        {
            _faculty = faculty;
            _specialty = specialty;
            _group = group;
            _course = course;
        }
        //структура
        protected struct Marks
        {
            //поля
            public int Math;
            public int Phisiks;
            public int Russian;
            //конструктор
            public Marks(int math)
            {
                Math = math;
                Phisiks = 8;
                Russian = 4;
            }
            public Marks(int math, int phisiks)
            {
                Math = math; ;
                Phisiks = phisiks;
                Russian = 4;
            }
            public Marks(int math, int phisiks, int russian)
            {
                Math = math; ;
                Phisiks = phisiks;
                Russian = russian;
            }
            public void CoutMarks()
            {
                Console.WriteLine("Marks:");
                Console.WriteLine($"Math: {Math}, Phisiks: {Phisiks}, Russian: {Russian}");
            }
        }
        //перечисления
        enum Numbers
        {
            First = 1, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth,
            Eleventh, Twelfth, Thirteenth, Fourteenth, Fifteenth, Sixteenth, Seventeenth, Eighteenth, Nineteenth, Twentieth,
            TwentyOne, TwentyTwo, TwentyThree, TwentyFour, TwentyFive, TwentySix, TwentySeven, TwentyEight, TwentyNine, Thirty

        };
        //свойство
        public override int IfAge 
        {           
            get => base.IfAge;

            set
            {
                if (value > 0 && value < 22)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age was entered incorrectly ");
                    Environment.Exit(0);
                }
            }

        }

        public int Group
        {
            get
            {
                return _group;
            }
            set
            {
                if(value <= 6 && value > 0)
                {
                    _group = value;
                }
                else
                {
                    Console.WriteLine("Group Enter is not correct ");
                    Environment.Exit(0);
                }
            }
        }
        public int Сourse
        {
            get
            {
                return _course;
            }
            set
            {
                if (value <= 4 && value > 0)
                {
                    _course = value;
                }
                else
                {
                    Console.WriteLine("Сourse Enter is not correct ");
                    Environment.Exit(0);
                }
            }
        }
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                switch (value)
                {

                    case "One":
                    case "Second":
                    case "Third":
                    case "Fourth":
                    case "Fifth":
                    case "Sixth":
                    case "Seventh":
                    case "Eighth":
                    case "Ninth":
                    case "Tenth":

                    case "Eleventh":
                    case "Twelfth":
                    case "Thirteenth":
                    case "Fourteenth":
                    case "Fifteenth":
                    case "Seventeenth":
                    case "Eighteenth":
                    case "Nineteenth":
                    case "Twentieth":

                    case "TwentyOne":
                    case "TwentyTwo":
                    case "TwentyThree":
                    case "TwentyFour":
                    case "TwentyFive":
                    case "TwentySix":
                    case "TwentySeven":
                    case "TwentyEight":
                    case "TwentyNine":
                    case "Thirty":
                        _number = value;
                        break;
                    default:
                        {
                            Console.WriteLine("Сourse Enter is not correct ");
                            Environment.Exit(0);
                            break;
                        }
                }
                
            }
        }
        public string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                switch (value)
                {
                    case "ФКСиС" : 
                    case "ФКП": 
                    case "ФИТУ": 
                    case "ФРЭ": 
                    case "ФИК": 
                    case "ИЭФ": 
                    case "ФДПиПО":
                        _faculty = value;
                        break;
                    default:
                        {
                            Console.WriteLine("Faculty enter is not correct ");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        public string Specialty
        {
            get
            {
                return _specialty;
            }
            set
            {
                switch (_faculty)
                {
                    case "ФКП":
                        {
                            switch (_specialty)
                            {
                                case "Программно - управляемые электронно - оптические системы":
                                case "Моделирование и компьютерное проектирование РЭС":
                                case "Проектирование и производство программно-управляемых электронных средств":
                                case "Медицинская электроника":
                                case "Программируемые мобильные системы»":
                                case "Электронные системы безопасности»":
                                case "Информационные системы и технологии(в обеспечении промышленной безопасности)":
                                case "Инженерно-психологическое обеспечение информационных технологий":
                                case "Информационные системы и технологии(в бизнес-менеджменте)":
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ФИТУ":
                        {
                            switch (_specialty)
                            {
                                case "Промышленная электроника":
                                case "Автоматизированные системы обработки информации":
                                case "Информационные технологии и управление в технических системах":
                                case "Искусственный интеллект":
                                case "Информационные системы и технологии (по направлениям)»":
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ФРЭ":
                        {
                            switch (_specialty)
                            {
                                case "Радиосистемы и радиотехнологии":
                                case "Радиотехника, в том числе системы и устройства радионавигации, радиолокации и телевидения":
                                case "Информационные радиотехнологии":
                                case " Микро- и наноэлектроника":
                                case "Твердотельная электроника, радиоэлектронные компоненты, микро- и наноэлектроника, приборы на квантовых эффектах»":
                                case "Нанотехнологии и наноматериалы":
                                case "Нанотехнологии и наноматериалы (в электронике)": 
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ФКСиС":
                        {
                            switch (_specialty)
                            {
                                case "Программное обеспечение информационных технологий":
                                case "Вычислительные машины, системы и сети":
                                case "Электронные вычислительные средства":
                                case "Информатика и технологии программирования":
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ФИК":
                        {
                            switch (_specialty)
                            {
                                case "Инфокоммуникационные технологии (по направлениям)":
                                case "Инфокоммуникационные системы (по направлениям)":
                                case "Защита информации в телекоммуникациях":
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ИЭФ":
                        {
                            switch (_specialty)
                            {
                                case "Экономика электронного бизнеса":
                                case "Электронный маркетинг":
                                case "Информационные системы и технологии (по направлениям)": 
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    case "ФДПиПО":
                        {
                            switch (_specialty)
                            {
                                case "Инфокоммуникационные технологии (по направлениям)":
                                case "Радиотехника (по направлениям)":
                                case "Вычислительные машины, системы и сети":
                                case "Инфокоммуникационные системы (по направлениям)":
                                    _specialty = value;
                                    break;
                                default:
                                    {
                                        Console.WriteLine("Specialty enter is not correct");
                                        Environment.Exit(0);
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Faculty enter is not correct ");
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
        //метод
        public virtual void Cout()
        {
            Console.WriteLine("Information about Student");
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.WriteLine($"Faculty:{_faculty}, Specialty:{_specialty}");
            Console.WriteLine($"Group:{_group}, Course:{_course}, serial number: the{_number} ");
        }
        public void Cout(string faculty, string specialty)
        {
            Console.WriteLine("Information about Student");
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.WriteLine($"Faculty:{faculty}, Specialty:{specialty}");
            Console.WriteLine($"Group:{_group}, Course:{_course}, serial number: the{_number} ");
        }
        public void Cout(string faculty, string specialty, int group, int course)
        {
            Console.WriteLine("Information about Student");
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.WriteLine($"Faculty:{faculty}, Specialty:{specialty}");
            Console.WriteLine($"Group:{group}, Course:{course}, serial number: the{_number} ");
        }
        public void Cout( int group, int course)
        {
            Console.WriteLine("Information about Student");
            Console.WriteLine($"Name:{_name}, Surname:{_surname}, Patronymic:{_patronymic}");
            Console.WriteLine($"Age:{_age}, Weidgt:{_weight}, Height:{_height}");
            Console.WriteLine($"Profession:{_profession}");
            Console.WriteLine($"Faculty:{_faculty}, Specialty:{_specialty}");
            Console.WriteLine($"Group:{group}, Course:{course}, serial number: the{_number} ");
        }
        public void Option(string _number)
        {
            int option = 0;
            switch (_number)
            {  
                case "One": option = (int)Numbers.First; break;
                case "Second": option = (int)Numbers.Second; break;
                case "Third": option = (int)Numbers.Third; break;
                case "Fourth": option = (int)Numbers.Fourth; break;
                case "Fifth": option = (int)Numbers.Fifth; break;
                case "Sixth": option = (int)Numbers.Sixth; break;
                case "Seventh": option = (int)Numbers.Seventh; break;
                case "Eighth": option = (int)Numbers.Eighth; break;
                case "Ninth": option = (int)Numbers.Ninth; break;
                case "Tenth": option = (int)Numbers.Tenth; break;

                case "Eleventh": option = (int)Numbers.Eleventh; break;
                case "Twelfth": option = (int)Numbers.Twelfth; break;
                case "Thirteenth": option = (int)Numbers.Thirteenth; break;
                case "Fourteenth": option = (int)Numbers.Fourteenth; break;
                case "Fifteenth": option = (int)Numbers.Fifteenth; break;
                case "Sixteenth": option = (int)Numbers.Sixteenth; break;
                case "Seventeenth": option = (int)Numbers.Seventeenth; break;
                case "Eighteenth": option = (int)Numbers.Eighteenth; break;
                case "Nineteenth": option = (int)Numbers.Nineteenth; break;
                case "Twentieth": option = (int)Numbers.Twentieth; break;

                case "TwentyOne": option = (int)Numbers.TwentyOne; break;
                case "TwentyTwo": option = (int)Numbers.TwentyTwo; break;
                case "TwentyThree": option = (int)Numbers.TwentyThree; break;
                case "TwentyFour": option = (int)Numbers.TwentyFour; break;
                case "TwentyFive": option = (int)Numbers.TwentyFive; break;
                case "TwentySix": option = (int)Numbers.TwentySix; break;
                case "TwentySeven": option = (int)Numbers.TwentySeven; break;
                case "TwentyEight": option = (int)Numbers.TwentyEight; break;
                case "TwentyNine": option = (int)Numbers.TwentyNine; break;
                case "Thirty": option = (int)Numbers.Thirty; break;
                default:
                    {
                        Console.WriteLine("Number enter is not correct");
                        Environment.Exit(0);
                        break;
                    }
            }
            option %= 15;
            Console.WriteLine($"Task option in the lab is {option}");
        }
    }
}
