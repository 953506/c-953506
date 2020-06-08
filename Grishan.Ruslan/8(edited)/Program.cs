using System;

namespace LABA8

{
    class Program
    {
        public static int allMoney = 0;
        class TcAdmin
        {
            private int _bank;
            public void Money(int money)
            {
                allMoney -= money;
                _bank = money;
            }
            public int Bank { get { return _bank; } }
        }
        class Tc : IComparable<IStuff>
        {
            public delegate void Raschetnik(string message);

            public event Raschetnik Notify;
            public Tc(string name)
            {
                Console.WriteLine(name);
            }
            public int Doxod { get; set; }
            public IShop Magazine { get; set; }
            public IStuff Stuff { get; set; }
            public void InfoMagaz()
            {
                Console.WriteLine("\n" + Magazine.Name);
                Console.Write("Work status:");
                Magazine.Working();
                if (Doxod < 0)
                {
                    Console.WriteLine("Rasxod:" + Doxod);
                }
                else
                {
                    Console.WriteLine("Doxod:" + Doxod);
                }
                Console.WriteLine("Rasxod without doxod:-" + Magazine.Rasxod);
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
            public void InfoStuff()
            {
                Console.WriteLine("\n" + Stuff.Name);
                Console.Write("Work status:");
                Stuff.Working();
                if (Doxod < 0)
                {
                    Console.WriteLine("Rasxod:" + Doxod);
                }
                else
                {
                    Console.WriteLine("Doxod:" + Doxod);
                }
            }
            public void RaschetStuff()
            {
                Doxod = -Stuff.Rasxod;
                allMoney += Doxod;
                Notify?.Invoke($"Added to all money: {Doxod}");
            }
            public void RaschetMagaz()
            {
                Doxod = Magazine.Viruchka - Magazine.Rasxod;
                allMoney += Doxod;
                Notify?.Invoke($"Added to all money: {Doxod}");
            }
        }
        
        
        delegate void Messager(string message);
        
        static void Main(string[] args)
        {
            Messager handler = delegate (string message)
            {
                Console.WriteLine(message);
            };
            Tc Galery = new Tc("Galery");
            handler("\n\nMAGAZINE");
            Galery.Magazine = new Shawerma();
            Galery.RaschetMagaz();
            Galery.InfoMagaz();

            Galery.Magazine = new Products();
            Galery.RaschetMagaz();
            Galery.InfoMagaz();

            handler("\n\nSTUFF:");
            Galery.Stuff = new Toilet();
            Galery.RaschetStuff();
            Galery.InfoStuff();

            int compare = Galery.CompareTo(Galery.Stuff);
            switch (compare)
            {
                case 1:
                    handler($"RASXOD:{Galery.Magazine.Name} > {Galery.Stuff.Name}"); break;
                case -1:
                    handler($"RASXOD:{Galery.Magazine.Name} < {Galery.Stuff.Name}"); break;
                case 0:
                    handler($"RASXOD:{Galery.Magazine.Name} = {Galery.Stuff.Name}"); break;
                default:
                    handler("Technical problems"); break;

            }
            Galery.Stuff = new Electro();
            Galery.RaschetStuff();
            Galery.InfoStuff();
            switch (compare)
            {
                case 1:
                    handler($"RASXOD:{Galery.Magazine.Name} > {Galery.Stuff.Name}"); break;
                case -1:
                    handler($"RASXOD:{Galery.Magazine.Name} < {Galery.Stuff.Name}"); break;
                case 0:
                    handler($"RASXOD:{Galery.Magazine.Name} = {Galery.Stuff.Name}"); break;
                default:
                    handler("Technical problems"); break;

            }
            Galery.Stuff = new Security();
            Galery.RaschetStuff();
            Galery.InfoStuff();
            handler("\nAll viruchka: " + allMoney);
            TcAdmin Admin = new TcAdmin();
            int money;
            handler("Write how much you want money on account:");
            try
            {
                Int32.TryParse(Console.ReadLine(), out money);
                if (money >= allMoney)
                    throw new Exception("You don't have enough money");
                Admin.Money(money);
            }
            catch (Exception excep)
            {
                Console.WriteLine(excep);
                throw;
            }
            handler("All money:" + allMoney);
            handler("Bank Account:" + Admin.Bank);

        }
    }
}