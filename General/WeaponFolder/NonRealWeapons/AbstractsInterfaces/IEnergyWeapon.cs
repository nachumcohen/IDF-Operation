using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.NonRealWeapons.AbstractsInterfaces
{
    public interface IEnergyWeapon : IFireArm
    {
        public  int maxEnergy { get; }
        public  int Energy { get; set; }
        public  int EnergyPerKM { get; }
    }
}
