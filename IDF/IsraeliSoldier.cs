using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public class IsraeliSoldier : Soldier
    {

        public IsraeliSoldier(string name, int _rank, Weapon _weapon, Location _location) : base (_rank, _weapon, _location)
        {
           base.Name = name;
        }
        public IsraeliSoldier(string name, int _rank, List<Weapon> _weapons, Location _location) : base(_rank, _weapons, _location)
        {
            base.Name = name;
        }

    }
}
