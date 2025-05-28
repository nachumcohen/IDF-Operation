using IDF_Operation.General.WeaponFolder.NonRealWeapons.AbstractsInterfaces;
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
        public override double maxEnergy => 100;
        protected override string typeOfBomb => "Building";
        public override double EnergyPerKM => 2;



    }
}
