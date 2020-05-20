using System;

namespace _6
{
    public class Human
    {
        // Это поля
        public string firstName;
        public string lastName;
        private int age;
        public int weight;
        public int height;

        // Это свойства
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 150)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }

        }

        // Это индексатор
        public string this[string keyword]
        {
            get
            {
                switch (keyword)
                {
                    case "first name":
                        return firstName;
                    case "last name":
                        return lastName;
                    default: return " - ";
                }
            }
            set
            {
                switch (keyword)
                {
                    case "first name":
                        firstName = value;
                        break;
                    case "last name":
                        lastName = value;
                        break;
                }
            }

        }

        // Это конструктор
        public Human(string humanFirstName, string humanLastName) : this(humanFirstName, humanLastName, 0, 0, 0)
        {
        }
        // Это перегрузка конструктора
        public Human(string humanFirstName, string humanLastName, int age, int weight, int height)
        {
            this.firstName = humanFirstName;
            this.lastName = humanLastName;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }

        // Это метод
        public float bodyMassIndex()
        {
            return bodyMassIndex(this.height, this.weight);
        }

        public float bodyMassIndex(int weight, int height)
        {
            try
            {
                float bodyMassInd = weight / (height / 100) * (height / 100);
                return bodyMassInd;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public static string getID()
        {
            return Guid.NewGuid().ToString();
        }

        public void doWork()
        {

        }

        // Форматированный вывод
        public void humanPrintInfo()
        {
            Console.WriteLine("= = = = = = = = = =\nPerson\n= = = = = = = = = =");
            Console.WriteLine($"First name || {this.firstName}");
            Console.WriteLine($"Last name  || {this.lastName}");
            Console.WriteLine($"Age        || {this.age}");
            Console.WriteLine($"Height     || {this.height}");
            Console.WriteLine($"Weight     || {this.weight}");
            Console.WriteLine("= = = = = = = = = =");
        }
    }
}
