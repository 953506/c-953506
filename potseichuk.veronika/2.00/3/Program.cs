    using System;

    namespace Пробный_3
    {
        class Program
        {
            static int numst = 0;
            struct Exams
            {
                public string subject;
                public int note;
            }

            class Student 
            {
                public float rating;
                protected Exams[] examsNotes;
                protected int numexams;

                public string Name { get; set; }
                public string Lastname { get; set; }
                public int Age { get; set; }
                public int Stage { get; set;}

                public Student()   
                {
                    Console.Write("Имя: ");
                    Name = Console.ReadLine();
                    Console.Write("Фамилия: ");
                    Lastname = Console.ReadLine();
                    Console.Write("Возраст (лет): ");
                    Age = Convert.ToInt32(Console.ReadLine());
                    if (Age > 35) Age = 23;
                    else if (Age < 16) Age = 17;
                    Console.Write("Курс: ");
                    Stage = Convert.ToInt32(Console.ReadLine());
                    if (Stage < 1) Stage = 1;
                    else if (Stage > 5) Stage = 5;
									
					numexams = 4;
					examsNotes = new Exams[numexams];
					examsNotes[0].subject = "Иностранный язык";
					examsNotes[1].subject = "ВышМат";
					examsNotes[2].subject = "Физкультура";
					examsNotes[3].subject = "Математическая логика";

					SetNotes();
                }
                
                public void Display()  
                {
                    Console.WriteLine("{0} {1} (возраст {2} лет), студент {3} курса", Lastname, Name, Age, Stage);
                    ShowNotes();
                    Console.WriteLine("\nСтудент {0}", Lastname);
                    Console.WriteLine("Рейтинг (в %): {0}", rating);
            }
                public float Rating()  
                {
                    float sum = 0;
                    for (int i = 0; i < numexams; i++)
                    {
                    if (examsNotes[i].note < 1) examsNotes[i].note = 1;
                    else if (examsNotes[i].note > 10) examsNotes[i].note = 10;
                    sum += examsNotes[i].note;
                    }
                    return sum / numexams * 10;
                }
                public void SetNotes()
                {
                    for (int i = 0; i < numexams; i++)
                    {
                    if (examsNotes[i].note < 1) examsNotes[i].note = 1;
                    else if (examsNotes[i].note > 10) examsNotes[i].note = 10;
                    Console.Write("{0}: ", examsNotes[i].subject);
                        examsNotes[i].note = Convert.ToInt32(Console.ReadLine());
                    }
                    rating = Rating();
                }
                public void ShowNotes()
                {
                    for (int i = 0; i < numexams; i++)
                    {
                        Console.WriteLine("{0}: {1};", examsNotes[i].subject, examsNotes[i].note);
                    }
                }
            }

            static readonly Student[] BSUIRst = new Student[10]; 

            static void AddSt()   
            {
                Console.Clear();
                BSUIRst[numst] = new Student();
                numst++;
            }

            static void ShowInfSt()  
            {
                bool success = false;
                do
                {
                    Console.Clear();
                    Console.Write("Введите фамилию студента, информацию о котором, хотите получить: ");
                    string choice = Console.ReadLine();
                    for (int i = 0; i < numst && success == false; i++)
                    {
                        if (choice == BSUIRst[i].Lastname) 
                        { 
                            success = true;
                            Console.Clear();
                            BSUIRst[i].Display();
                        }
                    }
                } while (success == false);
                Console.ReadKey();
            }

            static void NumberSt()  
            {
                Console.Clear();
                Console.WriteLine("Количество введенных студентов: {0}", numst);
                for (int j = 0; j < numst; j++)
                { 
                Console.WriteLine("{0}. {1} {2}, {3} курс, рейтинг {4}", j+1, BSUIRst[j].Lastname, BSUIRst[j].Name, BSUIRst[j].Stage, BSUIRst[j].rating); 
                }
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                int choice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Добавить студента");
                    Console.WriteLine("2. Вывести информацию о студенте");
                    Console.WriteLine("3. Список введённых студентов");
                    Console.WriteLine("4. Выход");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            AddSt();
                            break;
                        case 2:
                            ShowInfSt();
                            break;
                        case 3:
                            NumberSt();
                            break;
                    }
                } while (choice != 4);
            }
        }
    }