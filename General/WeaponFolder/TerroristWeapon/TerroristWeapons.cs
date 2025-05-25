using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General.WeaponFolder.TerroristWeapon
{

    public class TerroristWeapons : Weapon
    {
        protected override string name => "Terrorist Weapon: ";
        public virtual int WepRank{ get; protected set; }
    }
    public class AK47 : TerroristWeapons
    {
        public AK47()
        {
            WepRank = 3;
        }
            protected override string name => base.name + "AK47";
    }
    public class Knife : TerroristWeapons
    {
        public Knife()
        {
            WepRank = 1;
        }
        protected override string name => base.name + "Knife";

    }
    public class M16 : TerroristWeapons
    {
        public M16()
        {
            WepRank = 3;
        }
        protected override string name => base.name + "M16";
    }
    public class Gun : TerroristWeapons
    {
        public Gun()
        {
            WepRank = 2;
        }
        protected override string name => base.name + "Gun";
    }

}
