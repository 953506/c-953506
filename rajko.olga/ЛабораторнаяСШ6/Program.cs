using System;
using System.Collections.Generic;
using System.Collections;

namespace ЛабораторнаяСШ6
{
    //интерфейсы
    interface IFoo
    {
        static void Welcome() //определение реализации по умолчанию
        {
            Console.WriteLine("Hello!");
        }

        void GetInfo();
    }

    interface IComparison<T>
    {
        void AgeComparison(T o1, T o2);

        void CourseComparison(T o1, T o2);

        void GpaComparison(T o1, T o2);
    }

    public struct Proverka
    {
        private int age;
        private int course;
        private int gpa;
        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0 || value > 120)
                {
                    Console.WriteLine("It's false, try again");
                }
                else
                {
                    age = value;
                }
            }
        }
        public int Course
        {
            get { return course; }
            set
            {
                if (value == 0 || value > 5)
                {
                    Console.WriteLine("It's false, try again");
                }
                else
                {
                    course = value;
                }
            }
        }
        public int Gpa
        {
            get { return gpa; }
            set
            {
                if (value == 0 || value > 100)
                {
                    Console.WriteLine("It's false, try again");
                }
                else
                {
                    gpa = value;
                }
            }
        }
    }

    class HumanComparison : IComparison<Human>
    {
        public void AgeComparison(Human o1, Human o2)//неявная реализация метода
        {
            if (o1.proverka.Age > o2.proverka.Age)
            {
                Console.WriteLine($"{o1.name} older, than {o2.name}");
            }
            else
            {
                if (o2.proverka.Age > o1.proverka.Age)
                {
                    Console.WriteLine($"{o2.name} older, than {o1.name}");
                }
                else
                {
                    Console.WriteLine($"{o1.name} same age {o2.name}");
                }
            }
        }

        public void CourseComparison(Human o1, Human o2)//неявная реализация метода
        {
            if (o1.proverka.Course > o2.proverka.Course)
            {
                Console.WriteLine($"{o1.name} higher course, than  {o2.name}");
            }
            else
            {
                if (o2.proverka.Course > o1.proverka.Course)
                {
                    Console.WriteLine($"{o2.name} higher course, than  {o1.name}");
                }
                else
                {
                    Console.WriteLine($"{o1.name} same course {o2.name}");
                }
            }
        }

        public void GpaComparison(Human o1, Human o2)//неявная реализация метода
        {
            if (o1.proverka.Gpa > o2.proverka.Gpa)
            {
                Console.WriteLine($" {o1.name} GPA biger, than  {o2.name}");
            }
            else
            {
                if (o2.proverka.Gpa > o1.proverka.Gpa)
                {
                    Console.WriteLine($" {o2.name} GPA biger than {o1.name}");
                }
                else
                {
                    Console.WriteLine($" {o1.name} same GPA {o2.name}");
                }
            }
        }
    }

    class Human : IFoo, IComparable
    {
        public string name;
        public Proverka proverka;

        void IFoo.GetInfo()//явная реализация
        {
            Console.WriteLine($"Name: {name} \nAge: {proverka.Age} \nCourse: {proverka.Course} \nGPA:{proverka.Gpa}");
        }

        public Human(string name, int age, int course, int gpa)
        {
            this.name = name;
            proverka.Age = age;
            proverka.Course = course;
            proverka.Gpa = gpa;
        }
        //реализация интерфейса IComparable
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Human otherStudent = obj as Human;
            if (otherStudent != null)
                return this.proverka.Age.CompareTo(otherStudent.proverka.Age);
            else
                throw new ArgumentException("Error incomparable");
        }
    }
    class HumanComparer : IComparer<Human>
    {
        public int Compare(Human p1, Human p2)
        {
            if (p1.name.Length > p2.name.Length)
                return 1;
            else if (p1.name.Length < p2.name.Length)
                return -1;
            else
                return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFoo.Welcome();
            Human student1 = new Human("Arthur", 18, 1, 98);
            Human student2 = new Human("Gregori", 20, 3, 38);
            Human student3 = new Human("Lili", 20, 4, 67);
            Human student4 = new Human("Selena", 21, 2, 85);
            Console.WriteLine("Enter 1, if you want to see info about the students\n" +
                "enter 2, if you want to compare the men's parameters\n" +
                "enter 3, if you want to compare the women's parameters\n" +
                "enter 4, if you want to sort these people by age\n" +
                "enter 5, if you want to sort these people by name length");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (n)
            {
                case 1:
                    {
                        IFoo foo = student1;// переменная интерфейса
                        foo.GetInfo();//получили доступ к элементам интерфейса
                        IFoo foo2 = student2;
                        foo2.GetInfo();
                        IFoo foo3 = student3;
                        foo3.GetInfo();
                        IFoo foo4 = student4;
                        foo4.GetInfo();
                        break;
                    }
                case 2:
                    {
                        HumanComparison personComparison = new HumanComparison();
                        Console.WriteLine("Men's compare: ");
                        personComparison.AgeComparison(student1, student2);
                        personComparison.CourseComparison(student1, student2);
                        personComparison.GpaComparison(student1, student2);
                        break;
                    }
                case 3:
                    {
                        HumanComparison personComparison = new HumanComparison();
                        Console.WriteLine("Women's compare: ");
                        personComparison.AgeComparison(student3, student4);
                        personComparison.CourseComparison(student3, student4);
                        personComparison.GpaComparison(student3, student4);
                        break;
                    }
                case 4:
                    {
                        Human[] people = new Human[] { student1, student2, student3, student4 };
                        Array.Sort(people);
                        foreach (Human p in people)
                        {
                            Console.WriteLine(p.name + "(" + p.proverka.Age + ")");
                        }
                        break;
                    }
                case 5:
                    {
                        Human[] people = new Human[] { student1, student2, student3, student4 };
                        Array.Sort(people, new HumanComparer());
                        foreach (Human p in people)
                        {
                            Console.WriteLine(p.name + "(" + p.proverka.Age + ")");
                        }
                        break;
                    }
            }
        }
    }
}