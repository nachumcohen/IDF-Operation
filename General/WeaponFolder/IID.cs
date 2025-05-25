using IDF_Operation.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder
{
    internal interface IID
    {
        public int UniqueId { get; }
        public Soldier UniqueSoldier { get; protected set; }
    }
}
