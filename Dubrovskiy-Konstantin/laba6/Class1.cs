using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    interface IFarmer
    {
        void Info();   //получить инфу 
        string Use();  //использовать(каким-л образом)
    }

    interface IAnimal
    {
        void Voice(); //голос
    }
    
    class Pig<T> : IFarmer, IAnimal  //класс Свинья
    {
        public T Meat { get; set; } //у свиньи мясо
        public Pig(T value) //Конструктор
        {
            Meat = value;
        }        
        void IFarmer.Info()  //явная реализация
        {
            Console.WriteLine("Pig has " + Meat + "kg of meat");
        }
        string IFarmer.Use()  //явная реализация
        {
            Console.WriteLine("You killed the pig and get " + Meat + "kg of meat");
            return ((IConvertible)Meat).ToString(); //Реализация стандартного интерфейса для преобразования объектов (IConvertible)
        }
        public void Voice()  // неявная реализация 
        {
            Console.WriteLine("Pig says \"Yiii!\" ");
        }
    }
    class Cow<T> : IFarmer, IAnimal //класс Корова
    {
        public T Milk { get; set; } //у коровы молоко
        public Cow(T value) //Конструктор
        {
            Milk = value;
        }
        void IFarmer.Info()
        {
            Console.WriteLine("Cow has " + Milk + " liters of milk");
        }
        string IFarmer.Use()
        {
            Console.WriteLine("You milk the cow and get " + Milk + " liters of milk");
            return ((IConvertible)Milk).ToString(); //Реализация стандартного интерфейса для преобразования объектов (IConvertible)
        }
        public void Voice()  // неявная реализация 
        {
            Console.WriteLine("Cow says \"Mooow!\" ");
        }
    }

    class Sheep<T> : IFarmer, IAnimal //класс Овечка
    {
        public T Wool { get; set; } //у овечки шерсть
        public Sheep(T value) //Конструктор
        {
            Wool = value;
        }
        void IFarmer.Info()
        {
            Console.WriteLine("Sheep has " + Wool + "g of wool");
        }
        string IFarmer.Use()
        {
            Console.WriteLine("You cut the sheep and get " + Wool + "g of wool");
            return ((IConvertible)Wool).ToString(); //Реализация стандартного интерфейса для преобразования объектов (IConvertible)
        }
        public void Voice()  // неявная реализация 
        {
            Console.WriteLine("Sheep says \"Beee!\" ");
        }
    }

}
