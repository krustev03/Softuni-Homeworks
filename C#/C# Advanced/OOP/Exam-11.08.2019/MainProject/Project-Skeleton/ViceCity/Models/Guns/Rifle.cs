using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun, IGun
    {
        public Rifle(string name)
            : base(name, 50, 500)
        {
        }

        public override int Fire()
        {
            if (CanFire)
            {
                int bulletsPerShoot = 5;

                if (this.BulletsPerBarrel != 0)
                {
                    this.BulletsPerBarrel = this.BulletsPerBarrel - bulletsPerShoot;
                }
                if (this.BulletsPerBarrel == 0)
                {
                    if (this.TotalBullets != 0)
                    {
                        this.TotalBullets -= 50;
                        this.BulletsPerBarrel = 50;
                    }
                }

                return 5;
            }
            else
            {
                return 0;
            }
        }
    }
}
