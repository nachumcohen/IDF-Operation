using IDF_Operation.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public class IsraeliSoldier : Soldier
    {

        public IsraeliSoldier(int _rank, Weapon _weapon) : base (_rank, _weapon)
        {
        }
        public IsraeliSoldier(int _rank, List<Weapon> _weapons) : base(_rank, _weapons)
        {
            
        }

        public override string Name => base.Name;
        public override int Rank => base.Rank;
        public override List<Weapon> Weapons => base.Weapons;
    }
}
