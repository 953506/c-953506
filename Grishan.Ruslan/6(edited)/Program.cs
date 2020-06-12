using System;

namespace intrfc6
{
    class Program
    {

        public class Message<T>
        {
            public T Field1;
            public T Field2;
        }
        
        class Tc : IComparable<IStuff>
        {
            public Tc(string name)
            {
                Console.WriteLine(name);
            }            
            
            public int AllMoney { get; set; }            
            public int Doxod { get; set; }
            public IMagazine Magazine { get; set; }
            public IStuff Stuff { get; set; }

            public void Info(IMagazine magazine)
            {
                Console.WriteLine("\n" + magazine.Name);
                Console.Write("Work status:");
                magazine.Working();
                if (Doxod < 0)
                {
                    Console.WriteLine("Rasxod:" + Doxod);
                }
                else
                {
                    Console.WriteLine("Doxod:" + Doxod);
                }
                Console.WriteLine("Rasxod without doxod:-" + magazine.Rasxod);
            }

            public void Comparer(int n)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine($"RASXOD:{Magazine.Name} > {Stuff.Name}"); break;
                    case -1:
                        Console.WriteLine($"RASXOD:{Magazine.Name} < {Stuff.Name}"); break;
                    case 0:
                        Console.WriteLine($"RASXOD:{Magazine.Name} = {Stuff.Name}"); break;
                    default:
                        Console.WriteLine("Technical problems"); break;
                }

            }

            public int CompareTo(IStuff obj)
            {
                if (Magazine.Rasxod > obj.Rasxod)
                {
                    return 1;
                }
                if (Magazine.Rasxod < obj.Rasxod)
                    return -1;
                else
                    return 0;
            }

            public void Info(IStuff stuff)
            {
                Console.WriteLine("\n" + Stuff.Name);
                Console.Write("Work status:");
                stuff.Working();
                if (Doxod < 0)
                {
                    Console.WriteLine("Rasxod:" + Doxod);
                }
                else
                {
                    Console.WriteLine("Doxod:" + Doxod);
                }
            }

            public void Raschet(IStuff stuff)
            {
                Doxod = -stuff.Rasxod;
                AllMoney += Doxod;
            }

            public void Raschet(IMagazine magazine)
            {
                Doxod = magazine.viruchka - magazine.Rasxod;
                AllMoney += Doxod;
            }
        }
        
        static void Main(string[] args)
        {
            Message<string> g = new Message<string>();
            g.Field1 = "Obligation:";
            g.Field2 = "Your money:";
            Tc Galery = new Tc("Galery");
            Console.WriteLine("\n\nMAGAZINE:");
            Galery.Magazine = new Shawerma();
            Galery.Raschet(Galery.Magazine);
            Galery.Info(Galery.Magazine);

            Galery.Magazine = new Products();
            Galery.Raschet(Galery.Magazine);
            Galery.Info(Galery.Magazine);

            Console.WriteLine("\n\nSTUFF:");
            Galery.Stuff = new Toilet();
            Galery.Raschet(Galery.Stuff);
            Galery.Info(Galery.Stuff);

            
            Galery.Comparer(Galery.CompareTo(Galery.Stuff));
            Galery.Stuff = new Electro();
            Galery.Raschet(Galery.Stuff);
            Galery.Info(Galery.Stuff);
            
            Galery.Comparer(Galery.CompareTo(Galery.Stuff));
            Galery.Stuff = new Security();
            Galery.Raschet(Galery.Stuff);
            Galery.Info(Galery.Stuff);

            if (Galery.AllMoney < 0)
            {
                Console.WriteLine(g.Field1 + Galery.AllMoney);
            }
            else
            {
                Console.WriteLine(g.Field2+Galery.AllMoney);
            }
        }
    }
}
