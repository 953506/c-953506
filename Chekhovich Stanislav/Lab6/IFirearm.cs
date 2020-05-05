using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    interface IFirearm
    {
        public string Model { get; set; }
        public uint AmmoInClip { get; set; }
        public uint MaxAmmo { get; set; }
        public string Caliber { get; set; }
        public bool IsSafetyOn { get; set; }
        public bool IsReloaded { get; set; }

        public bool this[string mode] { get; set; }

        public void Reload(uint ammo);

        public void Shoot();

        public void GetInfo();
    }
}
