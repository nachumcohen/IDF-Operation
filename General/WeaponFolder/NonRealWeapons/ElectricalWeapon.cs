using IDF_Operation.Enemy;
using IDF_Operation.General.WeaponFolder.NonRealWeapons.AbstractsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.NonRealWeapons
{
   public class ElectricalWeapon : Weapon, IEnergyWeapon
    {
        protected virtual int ammunitionCapacity { get; set; }
        protected virtual int energy { get; set; }
        protected virtual string typeOfBomb { get; set; }




        public ElectricalWeapon() : base()
        {            
            AmmunitionCapacity = maxAmmmuniyion;
            Energy = maxEnergy;
        }

        public virtual int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value <= maxAmmmuniyion) { ammunitionCapacity = value; } } }
        public virtual int Energy { get { return energy; } set { if (value <= maxEnergy) { energy = value; } } }

        public virtual string TypeOfBomb { get { return typeOfBomb; } protected set { } }

        public virtual int maxAmmmuniyion => 0;
        public virtual int maxEnergy => 0;

        public virtual int EnergyPerKM => 0;

        public override string ToString()
        {
            return base.ToString() + $"\nMaxEnergy: {maxEnergy}\n";
        }


    }
}
