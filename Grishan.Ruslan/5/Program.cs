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
            if (changes==true)
            { 
                school.WriteBalli();
            }
            school.Proxod();
            bool cicle = true;
            if (school.poit)
            {
                Poit studentpoit = new Poit();
                while (cicle)
                {
                    Console.Clear();
                    studentpoit.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    {
                        case '1':
                            studentpoit.Vivod();
                            Console.ReadKey();
                            break;
                        case '2':
                            Console.WriteLine("Write new status:");
                            studentpoit.Vivod(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        case '3':
                            studentpoit.SemPredm();
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            studentpoit.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(studentpoit["name"] + " " + studentpoit["surname"] + " " + studentpoit["patronymic"]);
                            Console.WriteLine("\nHeight:" + studentpoit.Height);
                            Console.WriteLine("Weight:" + studentpoit.Weight);
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
                Iitp studentiitp = new Iitp();
                studentiitp.Vivod();
                while (cicle)
                {
                    Console.Clear();
                    studentiitp.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    {
                        case '1':
                            studentiitp.Vivod();
                            Console.ReadKey();
                            break;
                        case '2':
                            Console.WriteLine("Write new status:");
                            studentiitp.Vivod(Console.ReadLine()); //polimorf realize
                            Console.ReadKey();
                            break;
                        case '3':
                            studentiitp.SemPredm();
                            Console.ReadKey();
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            studentiitp.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(studentiitp["name"] + " " + studentiitp["surname"] + " " + studentiitp["patronymic"]);
                            Console.WriteLine("\nHeight:" + studentiitp.Height);
                            Console.WriteLine("Weight:" + studentiitp.Weight);
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
                Vmsis studentvmsis = new Vmsis();
                studentvmsis.Vivod();
                while (cicle)
                {
                    Console.Clear();
                    studentvmsis.Menu();
                    key = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch (key)
                    { 
                        case '1': 
                            studentvmsis.Vivod(); 
                            Console.ReadKey(); 
                            break;
                        case '2': 
                            Console.WriteLine("Write new status:"); 
                            studentvmsis.Vivod(Console.ReadLine());
                            Console.ReadKey();
                            break;
                        case '3': 
                            studentvmsis.SemPredm(); 
                            Console.ReadKey(); 
                            break;
                        case '4':
                            Console.WriteLine("Write new course:");
                            studentvmsis.Kurs = int.Parse(Console.ReadLine());
                            break;
                        case '5':
                            Console.Write(studentvmsis["name"] + " " + studentvmsis["surname"] + " " + studentvmsis["patronymic"]);
                            Console.WriteLine("\nHeight:" + studentvmsis.Height);
                            Console.WriteLine("\nWeight:" + studentvmsis.Weight);
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
