using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun, IGun
    {
        public Pistol(string name)
            : base(name, 10, 100)
        {
        }

        public override int Fire()
        {
            if (CanFire)
            {
                int bulletsPerShoot = 1;

                if (this.BulletsPerBarrel != 0)
                {
                    this.BulletsPerBarrel = this.BulletsPerBarrel - bulletsPerShoot;
                }
                if (this.BulletsPerBarrel == 0)
                {
                    if (this.TotalBullets != 0)
                    {
                        this.TotalBullets -= 10;
                        this.BulletsPerBarrel = 10;
                    }
                }

                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
