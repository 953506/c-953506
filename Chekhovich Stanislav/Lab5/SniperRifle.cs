using System;
using System.Threading;

namespace Lab5
{
    class SniperRifle : Firearm
    {
        public SniperRifle(string model, string caliber, uint maxAmmo, uint ammoInClip) : base(model, caliber, maxAmmo, ammoInClip)
        {
            TypeOfWeapon = TypesOfWeapon.SniperRifle;
        }
        public override void AimedShot()
        {
            if (AmmoInClip > 0)
            {
                AmmoInClip -= 1;
                Console.Write("Searching for target.");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Console.WriteLine("Target acquired!");
                Thread.Sleep(1000);
                Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.spaiperki.wav");
                Console.WriteLine("TTDAU!");
            }
            else
            {
                Console.WriteLine("Oops! Not enough ammo! You should reload a rifle before shooting");
            }
        }
        public override void GetInfoAboutType()
        {
            Console.WriteLine($"Your weapon is {TypeOfWeapon}" +
                $"\nA sniper rifle is a high-precision, long range rifle." +
                $"\nThe modern sniper rifle is a portable shoulder-fired " +
                $"\nweapon system with a choice between bolt-action or semi-automatic action");
        }

        public override bool this[string mode]
        {
            get
            {
                switch (mode)
                {
                    case "Single":
                        {
                            return ModeSingle;
                        }
                    case "Birst":
                        {
                            return ModeBirst;
                        }
                    case "Auto":
                        {
                            return ModeAuto;
                        }
                    default:
                        {
                            return false;
                        }
                }
            }
            set
            {
                ModeSingle = ModeBirst = ModeAuto = false;
                switch (mode)
                {
                    case "Single":
                        {
                            ModeSingle = value;
                            break;
                        }
                    case "Birst":
                        {
                            ModeBirst = value;
                            break;
                        }
                    case "Auto":
                        {
                            Console.WriteLine("There is no AUTO mod in Sniper Rifle");
                            ModeSingle = value;
                            break;
                        }
                }
            }
        }
    }
}
