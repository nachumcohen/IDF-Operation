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
        protected  string name;
        protected  int ammunitionCapacity;
        protected int energy;
        protected int uniqueId = 0;
        protected string typeOfBomb;
        protected Soldier uniqueSoldier;



        protected static int StaticId;

        public Weapon()
        {
            StaticId ++;
            this.uniqueId = StaticId;
        }

        public override string Name { get { return name; } protected set { if (name != null) { name = value; } } }
        public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value <= maxAmmmuniyion) { ammunitionCapacity = value; } } }
        public override int Energy { get { return energy; } set { if (value <= maxEnergy) { energy = value; } } }
        public override string TypeOfBomb { get { return typeOfBomb; } protected set { } }
        public override int UniqueId { get { return uniqueId; } }
        public override Soldier UniqueSoldier { get { return uniqueSoldier; }}

        public override int maxAmmmuniyion => throw new NotImplementedException();

        public override int maxEnergy => throw new NotImplementedException();

        public override bool CheckAvailebleEnergy()
        {
            throw new NotImplementedException();
        }

        public override void Fire()
        {
            throw new NotImplementedException();
        }

        public override void MoveToTarget()
        {
            throw new NotImplementedException();
        }

        public override void ComeHome()
        {
            throw new NotImplementedException();
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
