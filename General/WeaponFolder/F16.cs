using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
    public class F16 : FighterJet
    {
        public F16(string name, int ammunitionCapacity, int energy, string typeOfBomb) : base(name, ammunitionCapacity, energy, typeOfBomb)
        {
            Energy = energy;
        }
        private string name = "F16";
        private int ammunitionCapacity = 8;
        private string typeOfBomb = "building";

        public override string Name { get { return name;  } }
        public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value >= 0 && value <= 8) ammunitionCapacity = value;  } }
        public override int Energy { get; set; } 
        public override string TypeOfBomb { get { return typeOfBomb; } }

    }
}
