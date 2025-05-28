using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.IsraeliWeapons
{
     public class M109 : Artillery
    {
        public M109() : base()
        {
            Energy = 100;
        }
        protected override string name => base.name + "M109";
        public override int maxAmmmuniyion => 8;
        public override double maxEnergy => 100;
        protected override string typeOfBomb => "OpenArea";
        public override double EnergyPerKM => 2;

    }
}
