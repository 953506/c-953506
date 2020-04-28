using System;

namespace Lab5
{
    class AssaultRifle : Firearm
    {
        //----------------Конструктор
        public AssaultRifle(string model, string caliber, uint maxAmmo, uint ammoInClip) : base(model, caliber, maxAmmo, ammoInClip)
        {
            TypeOfWeapon = TypesOfWeapon.AssaultRifle;
        }

        //----------------Методы
        public override void StockHit()
        {
            Console.WriteLine("PUSH!");
            Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.priklada.wav");
        }

        public override void GetInfoAboutType()
        {
            Console.WriteLine($"Your weapon is {TypeOfWeapon}" +
                "\nAn assault rifle is a selective-fire rifle that uses an " +
                "\nintermediate cartridge and a detachable magazine.");
        }
    }
}
