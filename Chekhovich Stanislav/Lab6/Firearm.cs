using System;

namespace Lab6
{
    class Firearm : IComparable , IFirearm
    {
        //----------------Перечисление
        protected enum TypesOfWeapon
        {
            SniperRifle,
            AssaultRifle,
            MachineGun
        }
        
        //----------------Автосвойства
        protected TypesOfWeapon TypeOfWeapon { get; set; }
        protected bool ModeSingle { get; set; } = true;
        protected bool ModeBirst { get; set; } = false;
        protected bool ModeAuto { get; set; } = false;
        public string Model { get; set; }
        public uint AmmoInClip { get; set; }
        public uint MaxAmmo { get; set; }
        public string Caliber { get; set; }
        public bool IsSafetyOn { get; set; } = true;
        public bool IsReloaded { get; set; }
        
        //----------------Индексатор
        public virtual bool this[string mode]
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
                            ModeAuto = value;
                            break;
                        }
                }
            }
        }
        
        //----------------Конструктор
        public Firearm(string model, string caliber, uint maxAmmo, uint ammoInClip)
        {
            Model = model;
            Caliber = caliber;
            MaxAmmo = maxAmmo;
            AmmoInClip = maxAmmo < ammoInClip ? maxAmmo : ammoInClip;
            IsReloaded = AmmoInClip != 0;
        }
        
        //----------------Методы
        public int CompareTo(object obj)
        {
            Firearm weapon = obj as Firearm;
            if (weapon != null)
            {
                return Model.Length.CompareTo(weapon.Model.Length);
            }
            else
            {
                throw new ArgumentException("Object is not a weapon");
            }
        }

        public void Reload(uint ammo)
        {
            AmmoInClip = ammo > MaxAmmo ? MaxAmmo : ammo;
            IsReloaded = true;
        }

        public void Shoot()
        {
            if (!IsSafetyOn)
            {
                while (IsReloaded)
                {
                    if (AmmoInClip > 0)
                    {
                        if (ModeSingle)
                        {
                            AmmoInClip -= 1;
                            Console.WriteLine($"PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                            Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.odinochnii.wav");
                        }
                        if (ModeBirst)
                        {
                            if (AmmoInClip > 2)
                            {
                                AmmoInClip -= 3;
                                Console.WriteLine($"PAU! PAU! PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                            }
                            else if (AmmoInClip == 2)
                            {
                                AmmoInClip -= 2;
                                Console.WriteLine($"PAU! PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                            }
                            else
                            {
                                AmmoInClip -= 1;
                                Console.WriteLine($"PAU! Ammo in clip: {AmmoInClip}/{MaxAmmo}");
                            }
                            Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.ocheredi.wav");
                        }
                        if (ModeAuto)
                        {
                            AmmoInClip -= 1;
                            Console.Write($"PAU! {AmmoInClip}/{MaxAmmo} ");
                            Sound.PlaySound("C:\\Programming\\2 SEM\\Laba 5 C#\\Sounds\\zvuk.auto.wav");
                        }
                    }
                    else
                    {
                        IsReloaded = false;
                    }
                }
            }
            else
            {
                Console.WriteLine("Turn the safety off before shooting");
            }
        }

        public static void GetGeneralInfo()
        {
            Console.WriteLine("A firearm is a gun designed to be readily carried and used by a single individual." +
                "\nModern firearms can be described by their caliber, model and by the type of action employed.");
        }

        public void GetInfo()
        {
            Console.WriteLine($"Model of your weapon: {Model}" +
                $"\nCaliber of your weapon: {Caliber}" +
                $"\nMax ammo in a clip: {MaxAmmo}" +
                $"\nCurrent ammo in a clip: {AmmoInClip}");
        }
    }   
}
