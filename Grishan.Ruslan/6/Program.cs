using System;

namespace intrfc6
{
    class Program
    {
        public static int allMoney = 0;
        interface IStuff
        {   
            string Name { get; }
            int Personal { get; }
            int Zarplata { get; }
            int Rasxod { get; }
            void Working();
        }
        interface IMagazine 
        {
            string Name { get; }
            int viruchka{ get; }
            int Rasxod { get; }
            void Working();
        }
        class Tc:IComparable<IStuff>
        {
            
            public Tc(string name)
            {
                Console.WriteLine(name);
            }
            public int Doxod { get; set; }
            public IMagazine Magazine { get; set; }
            public IStuff Stuff { get; set; }
            public void InfoMagaz() 
            {
                Console.WriteLine("\n"+Magazine.Name);
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
            }
            public void RaschetMagaz() 
            {
                Doxod=Magazine.viruchka - Magazine.Rasxod;
                allMoney += Doxod;
            }        
        }
        class Stuff
        {
            public string Name { get; set; }
            public int Rasxod { get; set; }
            public int Zarplata { get; set; }
            protected bool work;
            public int Personal { get; set; }
            public void Working()
            {
                if (work == true)

                {
                    Open();
                }
                else Closed();
            }
            public void Open()
            {
                Console.WriteLine("OPEN");
            }
            public void Closed()
            {
                Console.WriteLine("CLOSED");
            }
        }
        class Security : Stuff, IStuff
        {
            public Security()
            {
                Zarplata = 40;
                Name = "Security";
                Personal = 30;
                work = false;
                Money();
            }
            private void Money()
            {
                if (work == true)
                {
                    Rasxod = (Zarplata * 40) + 600;
                }
                else
                {
                    Rasxod = 0;
                }
            }

        }
        class Electro : Stuff, IStuff
        {
            public Electro()
            {
                Zarplata = 20;
                Name = "Electro";
                Personal = 2;
                work = true;
                Money();
            }
            private void Money()
            {
                if (work == true)
                {
                    Rasxod =(Personal*Zarplata)+500;
                }
                else
                {
                    Rasxod = 0;
                }
            }

        }
        class Toilet:Stuff,IStuff 
        {
            public Toilet()
            {
                Zarplata = 10;
                Name = "Toilet";
                Personal = 7;
                work = true;
                Money();
            }
            private void Money()
            {
                if (work == true)
                {
                    Rasxod = (Personal*Zarplata)+300;
                }
                else
                {
                    Rasxod = 0;
                }
            }

        }
        class Magazine
        {
            protected bool work;
            public string Name { get; set; }   
            public int viruchka { get; set; }
            public int Rasxod { get; set; }

            public void Working() 
            {
                if (work == true)
            
                { 
                    Open(); 
                }
                else Closed();
            }
            public void Open() 
            { 
                Console.WriteLine("OPEN"); }
            public void Closed() 
            { 
                Console.WriteLine("CLOSED"); 
            }
        }
        class Products : Magazine, IMagazine
        {
            public Products() 
            { 
                Name = "Evroopt";
                work = true;
                Money();
            }
            private void Money() 
            {
                if (work == true)
                { 
                    viruchka = 150000;
                    Rasxod = 30000;
                }
                else 
                { 
                    viruchka = 0;
                    Rasxod = 0;
                }
            }
        }
        class Shawerma:Magazine, IMagazine 
        {
            public Shawerma()
            { 
                Name = "Doner House";
                work = true;
                Money();
            }
            private void Money()
            {
                if (work == true)
                {
                    viruchka = 50000;
                    Rasxod = 5000;
                }
                else
                {
                    viruchka = 0;
                    Rasxod = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            Tc Galery = new Tc("Galery");
            Console.WriteLine("\n\nMAGAZINE:");
            Galery.Magazine = new Shawerma();
            Galery.RaschetMagaz();
            Galery.InfoMagaz();

            Galery.Magazine = new Products();
            Galery.RaschetMagaz();
            Galery.InfoMagaz();

            Console.WriteLine("\n\nSTUFF:");
            Galery.Stuff = new Toilet();
            Galery.RaschetStuff();
            Galery.InfoStuff();

            int compare = Galery.CompareTo(Galery.Stuff);
            switch (compare)
            {
                case 1: 
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} > {Galery.Stuff.Name}"); break;
                case -1: 
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} < {Galery.Stuff.Name}"); break;
                case 0: 
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} = {Galery.Stuff.Name}"); break;
                default: 
                    Console.WriteLine("Technical problems"); break;
            
            }
            Galery.Stuff = new Electro();
            Galery.RaschetStuff();
            Galery.InfoStuff();
            switch (compare)
            {
                case 1:
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} > {Galery.Stuff.Name}"); break;
                case -1:
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} < {Galery.Stuff.Name}"); break;
                case 0:
                    Console.WriteLine($"RASXOD:{Galery.Magazine.Name} = {Galery.Stuff.Name}"); break;
                default:
                    Console.WriteLine("Technical problems"); break;
            }
            Galery.Stuff = new Security();
            Galery.RaschetStuff();
            Galery.InfoStuff();
            Console.WriteLine("\nAll viruchka: " + allMoney);
        }
    }
}