using System;

namespace Lab8
{
    class AssaultRifle : Firearm, IGun
    {
        public event ArgumentExceptionHandler Notify;

        public AssaultRifle(string model, string caliber, uint maxAmmo, uint ammoInClip) : base(model, caliber, maxAmmo, ammoInClip)
        {
            TypeOfWeapon = TypesOfWeapon.AssaultRifle;
        }

        public void UltimateAbility()
        {
            Console.WriteLine("PUSH!");
            Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.priklada.wav");
        }

        public void GetInfoAboutType()
        {
            Console.WriteLine($"Your weapon is {TypeOfWeapon}" +
                $"\nAn assault rifle is a selective-fire rifle that uses an " +
                $"\nintermediate cartridge and a detachable magazine.");
        }
    }
}
