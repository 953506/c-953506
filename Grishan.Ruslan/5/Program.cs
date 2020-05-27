using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool changes = false, ch=true;
            char key;
            Abiturient school = new Abiturient();
            Console.WriteLine("You want to make changes?\n1)no\t2)yes");
            do
            {
                key = Console.ReadKey().KeyChar;
                if (key == '1')
                { 
                    changes = false;
                    ch = false;
                }
                if (key == '2')
                {
                    changes = true;
                    ch = false;
                }
            }
            while (ch);
            Console.Clear();
            if (changes == true)
            { 
                school.WriteBalli();
            }
            school.Proxod();
            bool cicle = true;
            if (school.poit)
            {
                school = new Poit();
                while (cicle)
                {
                    Console.Clear();
                    school.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    {
                        case '1':
                            school.Vivod();
                            Console.ReadKey();
                            break;
                        case '2':
                            Console.WriteLine("Write new status:");
                            school.Vivod(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        case '3':
                            school.SemPredm();
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            school.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(school["name"] + " " + school["surname"] + " " + school["patronymic"]);
                            Console.WriteLine("\nHeight:" + school.Height);
                            Console.WriteLine("Weight:" + school.Weight);
                            Console.ReadKey();
                            break;
                        case '0':
                            cicle = false;
                            break;
                    }
                }
            }
            if (school.iitp)
            {
               school = new Iitp();
                school.Vivod();
                while (cicle)
                {
                    Console.Clear();
                    school.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    {
                        case '1':
                            school.Vivod();
                            Console.ReadKey();
                            break;
                        case '2':
                            Console.WriteLine("Write new status:");
                            school.Vivod(Console.ReadLine()); //polimorf realize
                            Console.ReadKey();
                            break;
                        case '3':
                            school.SemPredm();
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            school.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(school["name"] + " " + school["surname"] + " " + school["patronymic"]);
                            Console.WriteLine("\nHeight:" + school.Height);
                            Console.WriteLine("Weight:" + school.Weight);
                            Console.ReadKey();
                            break;
                        case '0':
                            cicle = false;
                            break;
                    }
                }
            }    
            if (school.vmsis)
            { 
                school = new Vmsis();
                school.Vivod();
                while (cicle)
                {
                    Console.Clear();
                    school.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    { 
                        case '1': 
                            school.Vivod(); 
                            Console.ReadKey(); 
                            break;
                        case '2': 
                            Console.WriteLine("Write new status:"); 
                            school.Vivod(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        case '3': 
                            school.SemPredm(); 
                            Console.ReadKey(); 
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            school.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(school["name"] + " " + school["surname"] + " " + school["patronymic"]);
                            Console.WriteLine("\nHeight:" + school.Height);
                            Console.WriteLine("\nWeight:" + school.Weight);
                            Console.ReadKey();
                            break;
                        case '0': 
                            cicle = false; 
                            break;
                    }
                }
            }
        }
    }
}
