class Program
{
    static public void WorkerMenu(Workers worker, Director director)
    {
        Console.Clear();
        Console.WriteLine("Input your name:");
        int number;
        string name = Console.ReadLine();
        for (int i = 0; i < 10; i++)
        {
            if (worker[i]._name == name)
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("1-see information about you");
                    Console.WriteLine("2-see list of worker ");
                    Console.WriteLine("3-see information about boss");
                    Console.WriteLine("4-Exit program");
                    number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 1:
                            {
                                worker[i].WriteCommonInformation();
                                worker[i].WriteCarParkInformation();
                                worker[i].WriteImportantInformation();
                            }
                            break;

                        case 3:
                            {
                                director.WriteCommonInformation();
                                director.WriteCarParkInformation();
                                director.WriteImportantInformation();
                            }
                            break;

                        case 2:
                            {
                                worker.Rating();
                            }
                            break;

                        case 5: break;

                        default:
                            Console.WriteLine("Введено неверное действие");
                            break;

                    }
                }
        }
    }

    static public void DirectorMenu(Workers worker, Director director)
    {
        Console.Clear();
        int number = 0;
        while (true)
        {
            Console.WriteLine("1-Enter Information about yourself");
            Console.WriteLine("2-Check Information about yourself");
            Console.WriteLine("3-see information about worker");
            Console.WriteLine("4-add information about worker");
            Console.WriteLine("5-check lists of worer");
            Console.WriteLine("6-exit program");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1: director.EnterImportantInformation(); break;
                case 2:
                    {
                        director.WriteCommonInformation();
                        director.WriteCarParkInformation();
                        director.WriteImportantInformation();
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    for (int s = 0; s < 10; s++)
                    {
                        worker[s].WriteCommonInformation();
                        worker[s].WriteCarParkInformation();
                        worker[s].WriteImportantInformation();

                        Console.WriteLine();
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("Введите имя студента:");
                        string sname = Console.ReadLine();
                        for (int s = 0; s < 10; s++)
                        {
                            if (worker[s]._name != sname)

                                continue;
                            else
                            {
                                worker[s].EnterImportantInformation();
                                break;
                            }
                        }
                    }
                    break;

                case 5: worker.Rating(); break;
                case 6: return;
                default: Console.WriteLine("Введено неверное действие"); break;
            }
        }
    }

    static void Main(string[] args)
    {

        Workers worker = new Workers();
        worker[0] = new Worker("A", "A", "Park", 18, "Worker", 241);
        worker[1] = new Worker("B", "B", "Park", 19, "Worker", 242);
        worker[2] = new Worker("C", "C", "Park", 20, "Worker", 243);
        worker[3] = new Worker("D", "D", "Park", 21, "Worker", 244);
        worker[4] = new Worker("F", "F", "Park", 22, "Worker", 245);
        worker[5] = new Worker("E", "E", "Park", 24, "Worker", 246);
        worker[6] = new Worker("G", "G", "Park", 26, "Worker", 247);
        worker[7] = new Worker("K", "K", "Park", 28, "Worker", 246);
        worker[8] = new Worker("N", "N", "Park", 39, "Worker", 248);
        worker[9] = new Worker("M", "M", "Park", 45, "Worker", 246);

        Director director = new Director("Michael", "Lukashevich", "BSUIR", 52, "Boss of the gym");

        int number;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Who are you?");
            Console.WriteLine("1-Boss");
            Console.WriteLine("2-Worker");
            Console.WriteLine("3-Exit program");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 2: WorkerMenu(worker, director); break;
                case 1: DirectorMenu(worker, director); break;
                case 3: return;
                default: Console.WriteLine("Incorect input"); break;
            }
        }

    }
}
