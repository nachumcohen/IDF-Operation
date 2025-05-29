using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using IDF_Operation.General.WeaponFolder.TerroristWeapon;

namespace IDF_Operation.Enemy
{
    public class Terrorist : Soldier
    {
        public bool IsAlive { get; set; }
        public int Dangerous { get; }

        public Terrorist(string _name, int _rank, Weapon _weapon, Location _location) : base(_rank, _weapon, _location)
        {
            IsAlive = true;
            Name = _name;
            TerroristWeapons trp = (TerroristWeapons)_weapon;
            Dangerous = _rank * trp.WepRank;
        }
        public Terrorist(string _name, int _rank, List<Weapon> _weapons, Location _location) : base (_rank, _weapons, _location)
        {
            IsAlive = true;
            Name = _name;

        }
        public override string ToString()
        {
            return $"\n-------Dangerous Rank is: {Dangerous}-------" + base.ToString();
        }


    }
}
