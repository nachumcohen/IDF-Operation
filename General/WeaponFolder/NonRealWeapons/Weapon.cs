using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.NonRealWeapons
{
    public class Weapon : AbstractWeapon
    {
        protected virtual string name { get; set; }
        protected virtual int uniqueId { get; set; }
        protected virtual Soldier uniqueSoldier { get; set; }
        protected static int StaticId;
        public Weapon() : base()
        {
            StaticId++;
            uniqueId = StaticId;
        }
        public override string Name { get { return name; } protected set { if (name != null) { name = value; } } }
        public override int UniqueId { get { return uniqueId; } }
        public override Soldier UniqueSoldier { get { return uniqueSoldier; } }
        public override string ToString()
        {
            return $"Name: {name}\nMaxEnergy: Uniqe Id: {UniqueId}";
        }


        public override void LinkSoldierToWeapon(Soldier soldier)
        {
            if (uniqueSoldier == null)
            {
                uniqueSoldier = soldier;
            }
        }
    }
}
