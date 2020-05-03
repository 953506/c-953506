using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Worker dishwasher = new Dishwasher("Ivan"); 
            Worker cook = new Cook("Vladimir");
            Worker waiter = new Waiter("Mariya");
            Worker manager = new Manager("Elena");

            dishwasher.PrintInfo();   //Вызовется переопределенный метод Work() из класса-наследника Dishwasher
            cook.PrintInfo();         //Вызовется переопределенный метод Work() из класса-наследника Cook
            waiter.PrintInfo();       //Вызовется переопределенный метод Work() из класса-наследника Waiter
            manager.PrintInfo();      //Вызовется переопределенный метод Work() из класса-наследника Manager

            Worker worker = new Worker();
            worker.FillInfo("Dmitriy", "waiter");
            worker.PrintInfo(); //Вызовется обычный метод Work() из класса Worker

            Console.WriteLine();
            Person person = new Dishwasher("Sergei");
            person.Work();  //Вызовется переопределенный метод Work() из класса-наследника Dishwasher 
            
        }
    }
}
