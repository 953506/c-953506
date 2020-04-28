using System;
using System.Threading;

namespace Lab5
{
    class MachineGun : Firearm
    {
        public MachineGun(string model, string caliber, uint maxAmmo, uint ammoInClip) : base(model, caliber, maxAmmo, ammoInClip)
        {
            TypeOfWeapon = TypesOfWeapon.MachineGun;
            ModeAuto = true;
            ModeSingle = ModeBirst = false;
        }

        public override void MachineGunFire()
        {
            if (AmmoInClip > 0)
            {
                Console.Write("TRA");
                Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.pulemeta.wav");
                for (; AmmoInClip > 0; AmmoInClip--)
                {
                    Console.Write("TA");
                    Thread.Sleep(100);
                }
                Console.Write("!");
                Thread.Sleep(3000);
            }
            Console.WriteLine("\nOops! Not enough ammo! You should reload your weapon");
        }

        public override void GetInfoAboutType()
        {
            Console.WriteLine($"Your weapon is {TypeOfWeapon}" +
                $"\nA machine gun is a fully automatic mounted or portable firearm" +
                $"\n designed to fire rifle cartridges in rapid succession from an" +
                $"\n ammunition belt or magazine.");
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
                Console.WriteLine("Machine Gun have only AUTO mode.");
            }
        }
    }
}
