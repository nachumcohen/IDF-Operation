using IDF_Operation.General.WeaponFolder.NonRealWeapons.ParentsWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.IsraeliWeapons
{
     public class Zik : Drone
    {

        public Zik() : base()
        {
        }
        protected override string name => base.name + "Zik";
        public override int maxAmmmuniyion => 8;
        public override double maxEnergy => 100;
        public override double EnergyPerKM => 2;

        protected override string typeOfBomb => "Car People";
        

    }
}
