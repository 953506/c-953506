using System;

namespace pudge
{
    class BSUIR_Student : Human
    {
        //---------------Перечисление
        enum Faculties
        {
            FCP = 1,
            FITU = 3,
            KSIS = 5
        }

        enum Specalties
        {
            IITP = 350,
            POIT = 100,
            IPOIT = 190,
            ASOI = 228
        }

        //----------------Поля
        protected string _curator, _faculty, _specialty, _group, _university, _course;

        //----------------Конструкторы
        public BSUIR_Student() : base() { }

        public BSUIR_Student(string name, string surname, string gender) : base(name, surname, gender) 
        {
            _curator = _faculty = _specialty = null;
            _university = "BSUIR";

            if (_age > 21)
            {
                _course = "graduated";
            }
            else
            {
                _course = (_age - 17).ToString();
                _group = (10 - Convert.ToInt32(_course)).ToString();
            }
        }

        //----------------Свойства
        public string Course
        {
            get
            {
                if (!_isDead)
                {
                    return _course;
                }
                return null;
            }
        }

        public string Curator
        {
            get
            {
                return _curator;
            }
            set
            {
                _curator = value;
            }
        }

        public override string Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                if (_group.Length > 1)
                {
                    _group = (17 - _age % 10).ToString();
                }

                if (value == Faculties.FCP.ToString())
                {
                    _curator = "Best FCP curator";
                    _faculty = Faculties.FCP.ToString();
                    _group += Convert.ToInt32(Faculties.FCP);
                }

                if (value == Faculties.FITU.ToString())
                {
                    _curator = "Best FITU curator";
                    _faculty = Faculties.FITU.ToString();
                    _group += Convert.ToInt32(Faculties.FITU);
                }

                if (value == Faculties.KSIS.ToString())
                {
                    _curator = "Ani$$imov Uladzimir Jakovlevich";
                    _faculty = Faculties.KSIS.ToString();
                    _group += Convert.ToInt32(Faculties.KSIS);
                }
                _faculty = value;
            }
        }

        public override string Specialty
        {
            get
            {
                return _specialty;
            }
            set
            {
                if (_group.Length > 2)
                {
                    _group = _group.Substring(0, 2);
                }

                if (_group.Length == 2)
                {
                    if (_faculty == Faculties.KSIS.ToString())
                    {
                        if (value == Specalties.IITP.ToString())
                        {
                            _specialty = Specalties.IITP.ToString();
                            _group += Convert.ToInt32(Specalties.IITP);
                        }

                        if (value == Specalties.POIT.ToString())
                        {
                            _specialty = Specalties.POIT.ToString();
                            _group += Convert.ToInt32(Specalties.POIT);
                        }
                    }

                    if (_faculty == Faculties.FCP.ToString())
                    {
                        if (value == Specalties.IPOIT.ToString())
                        {
                            _specialty = Specalties.IPOIT.ToString();
                            _group += Convert.ToInt32(Specalties.IPOIT);
                        }
                    }

                    if (_faculty == Faculties.FITU.ToString())
                    {
                        if (value == Specalties.ASOI.ToString())
                        {
                            _specialty = Specalties.ASOI.ToString();
                            _group += Convert.ToInt32(Specalties.ASOI);
                        }
                    }
                    _specialty = value;
                }
            }
        }

        public override string Group
        {
            get
            {
                if (_group.Length == 6)
                {
                    return _group;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (_group.Length > 5)
                {
                    _group = _group.Substring(0, 5);
                }

                if (_group.Length == 5 && Convert.ToInt32(value) > 0 && Convert.ToInt32(value) < 10)
                    _group += value;
            }
        }

        //----------------Методы 
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"university - {_university}");
            Console.WriteLine($"faculty - {_faculty}");
            Console.WriteLine($"specialty - {_specialty}");
            Console.WriteLine($"current course - {_course}");
            Console.WriteLine($"group - {_group}");
            Console.WriteLine($"curator - {_curator}");
        }

        public override void Die()
        {
            base.Die();
            _course = null;
            _university = "underground SUIR";
        }

        public override void Resurrect()
        {
            base.Resurrect();
            if (_age > 21)
            {
                _course = "graduated";
            }
            else
            {
                _course = (_age - 17).ToString();
            }
            _university = "BSUIR";
        }

        public new void Shout()
        {
            if (_isDead || _isIll)
                Console.WriteLine($"{_fio.name} is not currently able for shouting. Create another object.");
            else
                Console.WriteLine($"{_fio.name} shouts : Lunch boxes are on sale within 15 minutes");
            Console.ReadKey();
        }

        //----------------Деструктор
        ~BSUIR_Student() { }
    }
}