using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    public abstract class Soldier
    {
        string Name { get; set; }
        int Rank { get; set; }

        public List<Weapon> Weapons { get; private set { } }
         
    }
}
