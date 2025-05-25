using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
    internal class M109 : Artillery
    {
        public M109(int ammunitionCapacity, int energy) : base()
        {
            Energy = energy;
        }
        private string name = "M109";
        private string typeOfBomb = "Openspaces";
        private int ammunitionCapacity = 40;

        public override string Name { get { return name; } }
        public override int AmmunitionCapacity { get { return ammunitionCapacity; } set { if (value >= 0 && value <= 40)  ammunitionCapacity = value;  } } 
        public override int Energy { get; set; }
        public override string TypeOfBomb { get { return typeOfBomb; } }
    }
}
