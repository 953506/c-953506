using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var kid1 = new Schoolkid("James", "Hope", new DateTime(2000, 8, 12), Sex.Male, 167, 45, "6 A", "summer");
            var kid2 = new Schoolkid("Molly", "Blame", new DateTime(2010, 8, 12), Sex.Male, 167, 45, "6 A", "summer");
            Console.WriteLine(kid1.Equals(kid2));
            var kid3 = new Schoolkid("James", "Hope", new DateTime(2000, 8, 12), Sex.Male, 167, 45, "6 A", "summer");
            Console.WriteLine(kid1.Equals(kid3));
            
            Console.WriteLine("Enter firstname:");
            var firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname:");
            var lastname = Console.ReadLine();

            Console.WriteLine("Enter birthdate:");
            var birthdate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter sex:");
            var sex = (Sex)Enum.Parse(typeof(Sex), Console.ReadLine());

            Console.WriteLine("Enter heigth:");
            var heigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter weigth:");
            var weigth = Convert.ToInt32(Console.ReadLine());
   
            var human = new Human(firstname, lastname, birthdate, sex, heigth, weigth, 0);
            IHuman info = human;

            Console.WriteLine("Display an additional information?(Yes/No)");
            string ans = Console.ReadLine();
            if (ans == "Yes") 
            {
                Console.WriteLine(info.GetBodyMassIndex());
                human.CriminalRecord();
                human.FamilyCondition();
            }
            else if (ans == "No") Console.WriteLine("Continue...");

            Console.WriteLine("You are:\n1.Schoolkid\n2.Student\n3.Worker\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            р

            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter grade: ");
                        var grade = Console.ReadLine();
                        Console.WriteLine("Enter upcoming holidays: ");
                        var holidays = Console.ReadLine();
                        var schoolkid = new Schoolkid(firstname, lastname, birthdate, sex, heigth, weigth,
                            info.GetFullYears(), grade, holidays);
                        human = new Schoolkid(firstname, lastname, birthdate, sex, heigth, weigth,
                                              info.GetFullYears(), grade, holidays);
                        human.InstitutionType();
                        schoolkid.YourStatus();
                        Console.WriteLine(schoolkid.ToString());
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Enter your university: ");
                        var university = Console.ReadLine();
                        Console.WriteLine("Enter your speciality: ");
                        var speciality = Console.ReadLine();
                        Console.WriteLine("Enter your number og group: ");
                        var groupnum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter university year: ");
                        var year = Convert.ToInt32(Console.ReadLine());

                        var student = new Student(firstname, lastname, birthdate, sex, heigth, weigth,
                            info.GetFullYears(), speciality, year, groupnum, university);
                        human = new Student(firstname, lastname, birthdate, sex, heigth, weigth,
                            info.GetFullYears(), speciality, year, groupnum, university);
                        human.InstitutionType();
                        student.Dormitory();
                        Console.WriteLine(student.ToString());
                        student.EnterAnotherUniversity();
                        break;
                    }

                case 3:
                    {
                        var worker = new Worker(firstname, lastname, birthdate, sex, heigth, weigth,
                            info.GetFullYears());
                        IPayable rise = worker;
                        human = new Worker(firstname, lastname, birthdate, sex, heigth, weigth,
                            info.GetFullYears());
                        human.InstitutionType();
                        worker.InformationAboutJob();
                        worker.Vacation();
                        Console.WriteLine(worker.ToString());
                        Console.WriteLine("Set an increase or cut salaries?(set/cut/no) ");
                        string answer = Console.ReadLine();
                        if(answer == "set")
                        {
                            Console.WriteLine("How much to increase salary: ");
                            int money = Convert.ToInt32(Console.ReadLine());
                            rise.Rise(money);
                        }
                        else if (answer == "cut")
                        {
                            Console.WriteLine("How much to cut salary: ");
                            int money = Convert.ToInt32(Console.ReadLine());
                            rise.Lose(money);
                        }
                        else if(answer=="no") Console.WriteLine(worker.ToString());

                        Console.WriteLine(worker.ToString());

                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
