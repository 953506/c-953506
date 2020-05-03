using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class Person
    {
        public string Name { set; get; }  // Имя

        public abstract void Work();    //абстрактный метод Work
    }

    public class Worker : Person
    {
        protected string speciality;  // Специальность        
        protected int salary;         // Зароботная плата
        
        //Полиморфная функция класса-наследника:
        public override void Work()
        {
            Console.WriteLine($"{Name} works as {speciality}");
        }
                
        public struct SpecAndSalar   //Структура, содержащая соответствие специальность --> зарплата
        {
            public static readonly string[] specialities = new string[] { "dishwasher", "waiter", "cook", "manager" };  //массив специальностей
            public static readonly int[] salaries = new int[] { 80, 100, 150, 200 };     //массив зарплат            
        }
        //Перечисление, содержащее соответствие специальность --> зарплата  
        protected enum Specialities {dishwasher = 80, waiter = 100, cook = 150, manager = 200 }; //перечисление специальностей

        public void FillInfo(string name, string speciality)    // полное заполнение 
        {
            this.Name = name;
            this.speciality = speciality;
            
            for(int i = 0; i < SpecAndSalar.specialities.Length; i++)   //заполнение поля "зарплаты" в соответствии со "специальностью"
            {
                if (speciality == SpecAndSalar.specialities[i]) salary = SpecAndSalar.salaries[i]; //если специальн. = специальн.[i], то з/п = з/п[i]
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Специальность: {speciality};  Зарплата: {salary}");
            Work();
        }
    }

    //------------- Классы-наследники: ----------------
    class Dishwasher : Worker
    {
        Specialities sp = Specialities.dishwasher;
        public override void Work() //переопределенный метод Work()
        {
            Console.WriteLine($"{Name} washes the dishes, because {Name} is a {sp.ToString()}"); // "моет посуду"
            Console.WriteLine($"{Name} get ${(int)sp} per month\n"); 
        }        
        public Dishwasher(string name)// + конструктор (для удобства заполнения, т.к. точно знаем специальность работника)
        {
            FillInfo(name, sp.ToString()); // sp.ToString() = "dishwasher"
        }
    }
    class Cook : Worker
    {
        Specialities sp = Specialities.cook;
        public override void Work()
        {
            Console.WriteLine($"{Name} cooks food, because {Name} is a {sp.ToString()}"); // "готовит еду"
            Console.WriteLine($"{Name} get ${(int)sp} per month\n");
        }        
        public Cook(string name)//конструктор (для удобства)
        {
            FillInfo(name, sp.ToString());
        }
    }

    class Waiter : Worker
    {
        Specialities sp = Specialities.waiter;
        public override void Work()
        {
            Console.WriteLine($"{Name} brings orders, because {Name} is a {sp.ToString()}"); // "приносит заказы"
            Console.WriteLine($"{Name} get ${(int)sp} per month\n");
        }
        public Waiter(string name)
        {
            FillInfo(name, sp.ToString());
        }
    }

    class Manager : Worker
    {
        Specialities sp = Specialities.manager;
        public override void Work()
        {
            Console.WriteLine($"{Name} manages everything, because {Name} is a {sp.ToString()}"); // "управляет всем"
            Console.WriteLine($"{Name} get ${(int)sp} per month\n");
        }
        public Manager(string name)
        {
            FillInfo(name, sp.ToString());
        }
    }
}
