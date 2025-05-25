using IDF_Operation.General.WeaponFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace IDF_Operation.General
{
    public class Drone : Weapon
    {
        protected override string name { get; set; } = "Drone: ";
    }
}
