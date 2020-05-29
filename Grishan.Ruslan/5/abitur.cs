using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5
{
    class Abiturient : Human
    {
        protected double _attestat, _balli;
        protected new bool _army = false;
        public bool iitp, poit, vmsis;
        protected string _current_status;
        public Abiturient():base("Ruslan", "Luksha","Sapsanovich")
        {
            Attestat = 8.7;
            Lng = 75;
            Math = 73;
            Physics = 70;
            _balli = _attestat + ct.math + ct.physics + ct.lng;
        }
        public struct Predmets
        {
            public int physics, math, lng;
        };
        Predmets ct = new Predmets();
        enum Budjet
        {
            max = 400,
            poit = 360,
            iitp = 356,
            vmsis = 341
        };
        enum Platnoe                        
        {
            poit = 309,
            iitp = 290,
            vmsis = 265,
            min = 0
        };
        public double Balli
        { 
            get
            {
                return _balli;
            }
            set 
            {
                _balli = value;
            }
        
        }
        public virtual string Status 
        {
            get 
            {
                return _current_status; 
            } 
            set 
            { 
                _current_status = "School boy"; 
            } 
        }
        public int Physics
        {
            set 
            {
                if (value > 0 && value < 101)
                { 
                    ct.physics = value; 
                }
                
            } 
        }
        public double Attestat
        {
            set
            {
                if (value > 0 && value <= 10.0)
                { 
                    _attestat = value*10; 
                }

            }
        }
        public int Math
        {
            set
            {
                if (value > 0 && value < 101)
                { 
                    ct.math = value; 
                }

            }
        }
        public int Lng
        {
            set
            {
                if (value > 0 && value < 101)
                { 
                    ct.lng = value; 
                }

            }
        }
        public override int Age 
        {
            set 
            {
                if (value > 16)
                {
                    _age = value; 
                }
            } 
        }          
        public virtual int Kurs { get; set; }
        //методы
        public void WriteBalli()
        {
            Console.WriteLine("Write Attestat");
            Attestat=double.Parse(Console.ReadLine());
            Console.WriteLine("Write Math");
            Math=int.Parse(Console.ReadLine());
            Console.WriteLine("Write Languge");
            Lng=int.Parse(Console.ReadLine());
            Console.WriteLine("Write Physics");
            Physics=int.Parse(Console.ReadLine());
            Balli = ct.physics + ct.math + ct.lng + _attestat;
        }
        public void Proxod()
        {
            if (_balli <= 400 && _balli >= (double)Budjet.poit)
            { 
                poit = true; 
            }
            if (_balli >= (double)Platnoe.poit && _balli <(double)Budjet.vmsis) 
            { 
                poit = true; 
            }
            if (poit == false)
            {
                if (_balli < (double)Budjet.poit && _balli >= (double)Budjet.iitp)
                {
                    iitp = true; 
                }
                if (_balli >= (double)Platnoe.iitp && _balli < (double)Platnoe.poit)
                {
                    iitp = true; 
                }
            }
            if (poit == false && iitp == false)
            {
                if (_balli < (double)Budjet.iitp && _balli >= (double)Budjet.vmsis)
                { 
                    vmsis = true; 
                }
                if (_balli >= (double)Platnoe.vmsis && _balli < (double)Platnoe.iitp)
                { 
                    vmsis = true; 
                }
            }
            if (poit == false && iitp == false && vmsis == false)
            { 
                Console.WriteLine("Welcome to the army!"); 
                _army = true; 
            }
        }
        public virtual void SemPredm() { }
        public virtual void Vivod() { }
        public virtual void Vivod(string status) { }
    }
}
