using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.NonRealWeapons.AbstractsInterfaces
{
    public interface IFireArm
    {
        public  int maxAmmmuniyion { get; }
        public  int AmmunitionCapacity { get; set; }
        public  string TypeOfBomb { get;  }

    }
}
