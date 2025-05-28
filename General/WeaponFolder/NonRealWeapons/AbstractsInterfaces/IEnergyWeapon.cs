using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.NonRealWeapons.AbstractsInterfaces
{
    public interface IEnergyWeapon : IFireArm
    {
        public  double maxEnergy { get; }
        public  double Energy { get; set; }
        public double EnergyPerKM { get;}
    }
}
