using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            var pig1 = new Pig<string>("120");  //свинья весом <string> "120" кг
            var pig2 = new Pig<int>(145);       //свинья весом <int> 145 кг
            var sheep = new Sheep<int>(800);    //овечка с <int> 800 грамм шерсти
            var cow = new Cow<string>("4");     //корова с <string> "4" литрами млолка
            IFarmer cow_farmer = new Cow<int>(10); //объект интерфейса можно создать присвоив ему объект класса, в котором он реализован
            IAnimal sheep_animal = sheep;
            IAnimal pig1_animal = pig1;
            IFarmer pig2_farmer = pig2;
            cow.Voice(); //мы можем вызвать метод Voice т.к. он был неявно реализован как член интерфейса
            sheep_animal.Voice(); //а можем вызвать и через интерфейс
            cow_farmer.Info();  //вызываем явно реализованный метод интерфейса
            Console.WriteLine(cow_farmer.Use());
            cow_farmer = pig2_farmer; //можно присвоить друг другу элементы одинаковых интерфейсов (IFarmer)
            Console.WriteLine(cow_farmer.Use()); //вызовется метод из Pig
            var x = new Cow<int>(7);
            var y = new Cow<int>(9);
            if (x.Milk.CompareTo(y.Milk) > 0) //Сравнение при помощи IComperable
                Console.WriteLine("x > y");
            else
                if (x.Milk.CompareTo(y.Milk) < 0)
                    Console.WriteLine("x < y");
                else
                    Console.WriteLine("x = y");
        }
    }
}
