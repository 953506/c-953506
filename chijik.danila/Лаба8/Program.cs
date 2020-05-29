using System;

    class Program
    {
        public delegate Car Choose(Car first, Car second);

        delegate void MessageHandler(string message);

        static void Main(string[] args)
        {
            Car1 myCar = new Car1("Auto", "Black", "high", 2019, 4, 80, Car1.Model.M3, Car.CarType.Sedan);
            myCar.Calculate();

            Car2 friendsCar = new Car2("Auto", "Silver", "medium", 2012, 4, 400, Car2.Model.W140, Car.CarType.Sedan);
            friendsCar.Calculate();

            Choose choice = WhoIsBetter;
            MessageHandler handler = delegate (string message) { Console.WriteLine("{0}",message); };

            handler("Enter the sum you would like to add:");
            int money;
            try
            {
                Int32.TryParse(Console.ReadLine(), out money);
                if (money <= 0)
                    throw new Exception("You've entered invalid data!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            myCar.Purchase(money);
            friendsCar.Purchase(money);

            var result = choice(myCar, friendsCar);
            handler("Nice choice!");
        }

        public static Car WhoIsBetter(Car first, Car second)
        {
            int firstCar = 0;
            int secondCar = 0;

            if (first.ComfortLevel == "high" && (second.ComfortLevel == "medium" || second.ComfortLevel == "low") ||
                first.ComfortLevel == "medium" && second.ComfortLevel == "low")
                firstCar++;
            else if (first.ComfortLevel == second.ComfortLevel)
            {
                firstCar++;
                secondCar++;
            }
            else
                secondCar++;


            if (first.YearMade > second.YearMade)
                firstCar++;
            else if (first.YearMade == second.YearMade)
            {
                firstCar++;
                secondCar++;
            }
            else
                secondCar++;

            if (firstCar > secondCar)
                return first;
            else if (firstCar == secondCar)
            {
                Console.WriteLine("The cars are equal. Which one would like to choose?");
                int choice;
                Int32.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            return first;
                        }

                    case 2:
                        {
                            return second;
                        }

                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
            }
            else
                return second;

            return null;
        }
    }