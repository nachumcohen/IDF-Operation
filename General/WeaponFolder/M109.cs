using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
     public class M109 : Artillery
    {
        public M109() : base()
        {
        }
        protected override string name => base.name + "M109";
        public override int maxAmmmuniyion => 8;
        public override int maxEnergy => 100;
    }
}
