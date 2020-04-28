using System;
using System.Collections;

namespace Pudge
{
    class Program
    {
        static void Main()
        {
            ArrayList students = new ArrayList();
            char choice;
            string name = "";
            int averageMark = 5;
            IStudent st;

            do
            {
                if (students.Count > 0)
                {
                    ShowList(students);
                }
                Console.WriteLine("1 - Create Student" +
                    "\n2 - Create IITP_Student" +
                    "\n3 - Create IE_Student" +
                    "\n4 - Create CS_Student" +
                    "\n5 - Sort" +
                    "\n6 - Change student" +
                    "\n7 - Show student's info" +
                    "\nq - Exit");
                choice = Console.ReadKey().KeyChar;
                Console.Clear();

                if (choice >= '1' && choice <= '4')
                {
                    Console.Write("Name - ");
                    name = Console.ReadLine();
                    Console.Write("Average mark - ");
                    averageMark = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                }

                switch (choice)
                {
                    case '1':
                        st = new Student(name, averageMark);
                        students.Add(st);
                        break;
                    case '2':
                        st = new IITP_Student(name, averageMark);
                        students.Add(st);
                        break;
                    case '3':
                        st = new IE_Student(name, averageMark);
                        students.Add(st);
                        break;
                    case '4':
                        st = new CS_Student(name, averageMark);
                        students.Add(st);
                        break;
                    case '5':
                        students.Sort();
                        break;
                    case '6':
                        ShowList(students);
                        Console.Write("num of the student - ");
                        int i = Convert.ToInt32(Console.ReadLine()) - 1;
                        st = students[i] as Student;
                        students.RemoveAt(i);
                        Console.Clear();
                        st.ShowInfo();
                        Console.WriteLine("\n1 - change name" +
                            "\n2 - Change surname" +
                            "\n3 - Change average mark" +
                            "\n4 - Change university" +
                            "\n5 - Change faculty" +
                            "\n6 - Go to the army" +
                            "\n7 - Expel from the university" +
                            "\n8 - Set disese" +
                            "\n9 - Die (die twice to resurrect)" +
                            "\n0 - Change gender");
                        char changeChoice = Console.ReadKey().KeyChar;
                        Console.Clear();

                        switch (changeChoice)
                        {
                            case '1':
                                Console.Write("Name - ");
                                st.Name = Console.ReadLine();
                                break;
                            case '2':
                                Console.Write("Surname - ");
                                st.SurName = Console.ReadLine();
                                break;
                            case '3':
                                Console.Write("Average mark - ");
                                st.AverageMark = Convert.ToInt32(Console.ReadLine());
                                break;
                            case '4':
                                Console.Write("University - ");
                                st.University = Console.ReadLine();
                                break;
                            case '5':
                                Console.Write("Faculty - ");
                                st.Faculty = Console.ReadLine();
                                break;
                            case '6':
                                st.GoToArmy();
                                break;
                            case '7':
                                st.Expel();
                                break;
                            case '8':
                                Console.Write("Disease - ");
                                string disease = Console.ReadLine();
                                st.BecomeIll(disease);
                                break;
                            case '9':
                                if (st.IsDead)
                                {
                                    st.Resurrect();
                                }
                                else
                                {
                                    st.Die();
                                }
                                break;
                            case '0':
                                st.ChangeGender();
                                break;
                        }
                        students.Insert(i, st);
                        Console.Clear();
                        break;
                    case '7':
                        ShowList(students);
                        Console.Write("num of the student - ");
                        int j = Convert.ToInt32(Console.ReadLine()) - 1;
                        st = students[j] as IStudent;
                        st.ShowInfo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (choice != 'q');
        }

        static void ShowList(ArrayList array)
        {
            Console.WriteLine("blue - IITP, yellow - IE, green - CS, Cyan - not defined\n");
            int n = 1;
            foreach (IStudent student in array)
            {
                if (student is IITP_Student)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (student is IE_Student)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (student is CS_Student)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }

                Console.Write(n + ". " + student.Name);
                if (student.IsInArmy || student.IsKicked)
                {
                    Console.WriteLine(" is not a student");
                }
                else
                {
                    Console.WriteLine(" - " + student.AverageMark);
                }
                Console.ForegroundColor = ConsoleColor.White;
                n++;
            }
            Console.WriteLine("\n");
        }
    }
}