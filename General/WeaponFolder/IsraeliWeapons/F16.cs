using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.IsraeliWeapons
{
    public class F16 : FighterJet
    {

        public F16() : base()
        {
        }
        protected override string name => base.name + "F16";
        public override int maxAmmmuniyion => 8;
        public override int maxEnergy => 100;


        //protected override string typeOfBomb { get; set; } 
        //protected override Soldier uniqueSoldier { get; set; }


        //public F16(string name, int ammunitionCapacity, int energy, string typeOfBomb) : base(name, ammunitionCapacity, energy, typeOfBomb)
        //{
        //    Energy = energy;
        //}
        //private string name = "F16";
        //private int ammunitionCapacity = 8;
        //private string typeOfBomb = "building";

        //public override string Name { get { return name;  } }
        //public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value >= 0 && value <= 8) ammunitionCapacity = value;  } }
        //public override int Energy { get; set; } 
        //public override string TypeOfBomb { get { return typeOfBomb; } }

    }
}
