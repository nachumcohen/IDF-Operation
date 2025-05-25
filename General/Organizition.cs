using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
     interface Organizition
    {
        string DateOfEstablishment { get; set; }
        Soldier ChairmanOfTheOrganization { get; set; }

        List<Soldier> Soldiers { get; set; }

    }
}
