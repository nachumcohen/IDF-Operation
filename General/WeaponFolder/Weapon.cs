using IDF_Operation.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
   public class Weapon : AbstractWeapon
    {
        protected virtual string name { get; set; }
        protected virtual int ammunitionCapacity { get; set; }
        protected virtual int energy { get; set; }
        protected virtual int uniqueId { get; set; }
        protected virtual string typeOfBomb { get; set; }
        protected virtual Soldier uniqueSoldier { get; set; }




        protected static int StaticId;

        public Weapon()
        {
            StaticId ++;
            this.uniqueId = StaticId;

            
            this.AmmunitionCapacity = this.maxAmmmuniyion;
            this.Energy = maxEnergy;
        }

        public override string Name { get { return name; } protected set { if (name != null) { name = value; } } }
        public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value <= maxAmmmuniyion) { ammunitionCapacity = value; } } }
        public override int Energy { get { return energy; } set { if (value <= maxEnergy) { energy = value; } } }
        public override string TypeOfBomb { get { return typeOfBomb; } protected set { } }
        public override int UniqueId { get { return uniqueId; } }
        public override Soldier UniqueSoldier { get { return uniqueSoldier; } }

        public override int maxAmmmuniyion => 0;

        public override int maxEnergy => 0;

        public override int EnergyPerKM => 0;


        public override string ToString()
        {
            return $"Name: {this.name}\nMaxEnergy: {this.maxEnergy}\nUniqe Id: {this.UniqueId}";
        }


        public override void LinkSoldierToWeapon(Soldier soldier)
        {
            if (this.uniqueSoldier == null)
            {
                this.uniqueSoldier = soldier;
            }
        }
    }
}
