using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a, ammo, K = 1, k;
            bool exit = false, first = true;
            Firearm Gun = new SniperRifle("SVD", "7,62", 10, 8);
            while (true)
            {
                if (!first)
                {
                    Console.WriteLine("1.Create a new firearm" +
                        "\n2.Shoot a firearm" +
                        "\n3.Realod a firearm" +
                        "\n4.Info about firearm" +
                        "\n5.Switch the safety" +
                        "\n6.Switch mode" +
                        "\n7.Change info" +
                        "\n8.Use ultimate ability of the weapon" +
                        "\n9.Exit the program");
                    if (!UInt32.TryParse(Console.ReadLine(), out K))
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    Console.Clear();
                }
                switch (K)
                {
                    case 1:
                        {
                            uint maxAmmo, ammoInClip;
                            Console.Write("Write model of your weapon: ");
                            string model = Console.ReadLine();
                            Console.Write("Write caliber of your weapon: ");
                            string caliber = Console.ReadLine();
                            Console.Write("Write max ammo in a clip: ");
                            if(!UInt32.TryParse(Console.ReadLine(), out maxAmmo))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Console.Write("Write current ammo in a clip: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out ammoInClip))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Console.WriteLine("What weapon do you want to create?" +
                                "\n1.Sniper Rifle" +
                                "\n2.Assault Rifle" +
                                "\n3.Machine Gun");
                            if (!UInt32.TryParse(Console.ReadLine(), out k) || k == 0 || k > 3)
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            switch (k)
                            {
                                case 1:
                                    {
                                        Gun = new SniperRifle(model, caliber, maxAmmo, ammoInClip);
                                        break;
                                    }
                                case 2:
                                    {
                                        Gun = new AssaultRifle(model, caliber, maxAmmo, ammoInClip);
                                        break;
                                    }
                                case 3:
                                    {
                                        Gun = new MachineGun(model, caliber, maxAmmo, ammoInClip);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 2:
                        {
                            Gun.Shoot();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("How many ammo do you want to reload?" +
                                "\n1.Full clip" +
                                "\n2.My number");
                            if (!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            if(a == 1)
                            {
                                Gun.Reload(Gun.MaxAmmo);
                            }
                            else if (a == 2)
                            {
                                Console.WriteLine("What number?");
                                if (!UInt32.TryParse(Console.ReadLine(), out ammo))
                                {
                                    Console.WriteLine("Error");
                                    break;
                                }
                                Gun.Reload(ammo);
                            }
                            break;
                        }
                    case 4:
                        {
                            Firearm.GetGeneralInfo();
                            Gun.GetInfoAboutType();
                            Gun.GetInfo();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("1.Turn the safety off" +
                                "\n2.Turn the safety on");
                            if (!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            switch(a)
                            {
                                case 1:
                                    {
                                        Gun.IsSafetyOn = false;
                                        Console.WriteLine("You've got the safety off");
                                        break;
                                    }
                                case 2:
                                    {
                                        Gun.IsSafetyOn = true;
                                        Console.WriteLine("You've got the safety on");
                                        break;
                                    }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("1.Single" +
                                "\n2.Burst" +
                                "\n3.Auto");
                            if (!UInt32.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            switch (a)
                            {
                                case 1:
                                    {
                                        Gun["Single"] = true;
                                        break;
                                    }
                                case 2:
                                    {
                                        Gun["Birst"] = true;
                                        break;
                                    }
                                case 3:
                                    {
                                        Gun["Auto"] = true;
                                        break;
                                    }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Write new model of your weapon: ");
                            Gun.Model = Console.ReadLine();
                            Console.Write("Write new caliber of your weapon: ");
                            Gun.Caliber = Console.ReadLine();
                            Console.Write("Write new max ammo in a clip: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out ammo))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.MaxAmmo = ammo;
                            Console.Write("Write new current ammo in a clip: ");
                            if (!UInt32.TryParse(Console.ReadLine(), out ammo))
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                            Gun.AmmoInClip = ammo > Gun.MaxAmmo ? Gun.MaxAmmo : ammo;
                            Gun.IsReloaded = Gun.AmmoInClip > 0;
                            break;
                        }
                    case 8:
                        {
                            if (Gun is SniperRifle && !Gun.IsSafetyOn)
                            {
                                Gun.AimedShot();
                            }
                            else if (Gun is AssaultRifle)
                            {
                                Gun.StockHit();
                            }
                            else if (Gun is MachineGun && !Gun.IsSafetyOn)
                            {
                                Gun.MachineGunFire();
                            }
                            else
                            {
                                Console.WriteLine("You should turn the safety off before using ultimate ability");
                            }
                            break;
                        }
                    case 9:
                        {
                            exit = true;
                            break;
                        }
                }
                if (exit == true)
                {
                    break;
                }
                first = false;
                Console.WriteLine("\nPress any button...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
