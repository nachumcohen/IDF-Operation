using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    interface Soldier
    {
        string Name { get; set; }
        int Rank {  get; set; }

        Weapon Weapon { get; set; }
         
    }
}
