using System;
namespace laba3think
{
    class Human
    {
        private int _age, _height, _weight;
        private string _name, _surname, _patronymic;
        public static int birthyear = 0;
        private bool _sick_cov = false, _army;
                                                                                                                                                       //конструктор
        public Human()
        {
            _age = 2020 - birthyear;
        }

        public Human(string name, string surname, string patronymic) : this()
        {
            _name = name;
            _surname = surname;
            _patronymic = patronymic;
        }

                                                                                                                                                        //свойства
        public string Surname

        {
            get
            {
                return _name;
            }
            set

            {
                _surname = value;
            }
        }
        public int Weight

        {
            set

            {
                if (value >= 5 && value <= 600)
                _weight = value;
                Console.WriteLine("Write real weight");
            }
        }
        public int Height

        {
            set

            {
                if (value >= 5 && value <= 260)
                    _height = value;
                else
                    Console.WriteLine("Write real height");
            }
        }
        public string Name

        {
            get
            {
                return _name;
            }
            set

            {
                _name = value;
            }
        }
        public string Patronymic

        {
            get
            {
                return _patronymic;
            }
            set

            {
                _patronymic = value;
            }
        }

        public int Age

        {
            set 

            {
                if (value >= 0 && value <= 120)
                    _age = value;
                else 
                    Console.WriteLine("Write normal age");
            }
            
        }
                                                                                                                                                    //индексаторы
        public string this[string index]

        {

            get

            {
                switch (index)

                {
                    case "name": return _name;
                    case "surname": return _surname;
                    case "patronymic": return _patronymic;
                    default: return null;
                }

            }

            set

            {
                switch (index)

                {
                    case "name": _name = value; break;
                    case "surname": _surname = value; break;
                    case "patronymic": _patronymic = value; break;
                }
            }
        }
                                                                                                                                                        //методы
        public void Showinf()
        {
            Console.WriteLine($"name - {_surname}");
            Console.WriteLine($"surname - {_name}");
            Console.WriteLine($"patronymic - {_patronymic}");
            Console.WriteLine($"age - {_age}");
            Console.WriteLine($"height - {_height}");
            Console.WriteLine($"weight - {_weight}");
            Console.WriteLine($"sick Covid-19 - {_sick_cov}");
            if (_army == true)
            {
                Console.WriteLine("You are fit");
            }
        
        }
        public static void Menu()
        {
            Console.WriteLine("1)Show information");
            Console.WriteLine("2)Change age");
            Console.WriteLine("3)Change name");
            Console.WriteLine("4)Change surname");
            Console.WriteLine("5)Change patronymic");
            Console.WriteLine("6)Change sick status");
            Console.WriteLine("7)Write height");
            Console.WriteLine("8)Write weight");
            Console.WriteLine("9)Army status");
            Console.WriteLine("0)Show FIO");
            Console.WriteLine("Press - to end");
        }
        public void Army()
        {
            if (_age > 17 && _age < 28 && _weight > 35 && _weight < 100 && _height > 160 && _height < 190 && _sick_cov == false)
            {
                _army = true;
                Console.WriteLine("You are fit");
                Console.ReadKey();
            }
        
        }
        public void Change_sick()
        {
            _sick_cov = (_sick_cov == false) ? true : false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            char key;
            string surname = "", name = "", patronymic="";
            Console.WriteLine("Write surname");
            surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Write name");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Write Patronymic");
            patronymic = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Write born number");
            Human.birthyear = int.Parse(Console.ReadLine());
            Human human = new Human(name,surname,patronymic);
            do

            {
                Console.Clear();
                Human.Menu();
                key = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (key)

                {
                    case '1':
                        human.Showinf();
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.WriteLine("age - ");
                            human.Age = int.Parse(Console.ReadLine());
                        break;
                    case '3':
                        Console.Write("name - ");
                        human.Name = Console.ReadLine();
                        break;
                    case '4':
                        Console.Write("surname - ");
                        human.Surname = Console.ReadLine();
                        break;
                    case '5':
                        Console.Write("patronymic - ");
                        human.Patronymic = Console.ReadLine();
                        break;
                    case '6':
                        human.Change_sick();
                        break;
                    case '7':
                        Console.WriteLine("Write height - ");
                        human.Height = int.Parse(Console.ReadLine());
                        break;
                    case '8':
                        Console.WriteLine("Write weight - ");
                        human.Weight = int.Parse(Console.ReadLine());
                        break;
                    case '9':
                        human.Army();
                        break;
                    case '0':
                        Console.Write(human["name"] + " " + human["surname"]+" "+human["patronymic"]);
                        Console.ReadKey();
                        break;
                    case '-':
                        return;

                }
                Console.Clear();
            } while (true);

        }
    }
}
