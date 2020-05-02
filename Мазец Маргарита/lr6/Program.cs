using System;

namespace lr6
{
    class Program
    {
        static public void StudentsMenu(Students student, Teachers teacher, Rector rector) 
        {
            Console.Clear();
            Console.WriteLine("Введите своё имя:");
            int number;
            string name = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (student[i].Name != name)
                    continue;
                else
                {
                    while (true)
                    {
                        Console.WriteLine();
                        Console.WriteLine("1-посмотреть свою успеваемость");
                        Console.WriteLine("2-посмотреть рейтинг");
                        Console.WriteLine("3-найти информацию о преподавателе");
                        Console.WriteLine("4-найти онформацию о ректоре");
                        Console.WriteLine("5-завешить программу как студент");
                        number = Convert.ToInt32(Console.ReadLine());
                        switch (number)
                        {
                            case 1:
                                student[i].AcademicPerformance();
                                break;
                            case 2:
                                student.Rating();
                                break;
                            case 3:
                                Console.WriteLine("Введите имя преподавателя:");
                                string tname = Console.ReadLine();
                                for (int t = 0; t < 3; t++)
                                {
                                    if (teacher[t].Name != tname)
                                        continue;
                                    else
                                    {
                                        teacher[t].WriteCommonInformation();
                                        teacher[t].WriteUniversityInformation();
                                        teacher[t].WriteImportantInformation();
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                rector.WriteCommonInformation();
                                rector.WriteUniversityInformation();
                                rector.WriteImportantInformation();
                                break;
                            case 5: break;
                            default:
                                Console.WriteLine("Введено неверное действие");
                                break;
                        }
                        if (number == 5) break;
                    }
                }
            }
        }
        static public void TeachersMenu(Students student, Teachers teacher) 
        {
            Console.Clear();
            Console.WriteLine("Введите своё имя:");
            int number;
            string name = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                if (teacher[i].Name != name)
                    continue;
                else
                {
                    while (true)
                    {
                        Console.WriteLine("1-внести важную информацию о себе");
                        Console.WriteLine("2-посмотреть список студентов");
                        Console.WriteLine("3-выставить средний балл по предмету");
                        Console.WriteLine("4-завершить программу как преподаватель");
                        number = Convert.ToInt32(Console.ReadLine());
                        switch (number)
                        { 
                        case 1:
                            teacher[i].EnterImportantInformation();
                            break;
                        case 2:
                            for (int s = 0; s < 10; s++)
                            {
                                student[s].WriteCommonInformation();
                                student[s].WriteUniversityInformation();
                                student[s].WriteImportantInformation();
                                student[s].AcademicPerformance();
                                Console.WriteLine();
                            }
                            break;
                        case 3:
                            Console.WriteLine("Введите имя студента:");
                            string sname = Console.ReadLine();
                            for (int s = 0; s < 10; s++)
                            {
                                if (student[s].Name != sname)
                                   continue;
                                else 
                                {
                                    Console.WriteLine("Введите средний балл:");
                                    student[s].MiddleMark = Convert.ToDouble(Console.ReadLine());
                                    break;
                                }
                            }
                            break;
                        case 4:
                            break;
                         default:
                            Console.WriteLine("Введено неверное действие");
                            break;
                        }
                        if (number == 4)
                            break;
                    }
                }
            }
        }
        static public void RectorsMenu(Students student, Teachers teacher, Rector rector) 
        {
            Console.Clear();
            int number=0;
            while (true)
            {
                Console.WriteLine("1-внести важную информацию о себе");
                Console.WriteLine("2-посмотреть информацию о преподавателях");
                Console.WriteLine("3-посмотреть информацию о студентах");
                Console.WriteLine("4-внести достижения студена");
                Console.WriteLine("5-посмотреть рейтинг");
                Console.WriteLine("6-завершить программу как ректор");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        rector.EnterImportantInformation();
                        break;
                    case 2:
                        for (int t = 0; t < 3; t++)
                        {
                            teacher[t].WriteCommonInformation();
                            teacher[t].WriteUniversityInformation();
                            teacher[t].WriteImportantInformation();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (int s = 0; s < 10; s++)
                        {
                            student[s].WriteCommonInformation();
                            student[s].WriteUniversityInformation();
                            student[s].WriteImportantInformation();
                            student[s].AcademicPerformance();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Введите имя студента:");
                        string sname = Console.ReadLine();
                        for (int s = 0; s < 10; s++)
                        {
                            if (student[s].Name != sname)
                                continue;
                            else
                            {
                                student[s].EnterImportantInformation();
                                break;
                            }
                        }
                        break;
                    case 5:
                        student.Rating();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Введено неверное действие");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            #region data
            Students student = new Students();
            student[0] = new Student("Елена", "Барковская", "БГУИР", 2001, "Информатика и технологии программирования", 2019);
            student[1] = new Student("Виктория", "Стельмашук", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[2] = new Student("Маргарита", "Мазец", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[3] = new Student("Артём", "Киричук", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[4] = new Student("Данила", "Чижик", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[5] = new Student("Руслан", "Гришан", "БГУИР", 2001, "Информатика и технологии программирования", 2019);
            student[6] = new Student("Владимир", "Кошуба", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[7] = new Student("Илья", "Лукша", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[8] = new Student("Андрей", "Белоусов", "БГУИР", 2002, "Информатика и технологии программирования", 2019);
            student[9] = new Student("Ксения", "Рудковская", "БГУИР", 2002, "Информатика и технологии программирования", 2019);

            Teachers teacher = new Teachers();
            teacher[0] = new Teacher("Наталья", "Егорова", "БГУИР", 1980, "преподаватель", "МЛ", "доцент");
            teacher[1] = new Teacher("Владимир", "Анисимов", "БГУИР", 1950, "преподаватель", "ММА", "доцент");
            teacher[2] = new Teacher("Мария", "Дисько-Шуман", "БГУИР", 1980, "преподаватель", "Логика", "доцент");

            Rector rector = new Rector("Вадим", "Богуш", "БГУИР", 1975, "ректор");
            #endregion

            int number;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Кем вы являетесь?");
                Console.WriteLine("1-студент");
                Console.WriteLine("2-преподаватель");
                Console.WriteLine("3-ректор");
                Console.WriteLine("4-завершить программу");
                number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:                    
                        StudentsMenu(student, teacher, rector);
                        break;
                    case 2:
                        TeachersMenu(student, teacher);
                        break;
                    case 3:                        
                        RectorsMenu(student, teacher, rector);
                        break;
                    case 4:  
                    return;
                    default:
                        Console.WriteLine("Введен неверный номер");
                        break;
                }
            }
        }
    }
}
