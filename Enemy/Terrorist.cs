using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder;

namespace IDF_Operation.Enemy
{
    public class Terrorist : Soldier
    {
        public override string Name => base.Name;

        public override int Rank => base.Rank;

        public bool IsAlive { get; set; }
        
        public List<Weapon> Weapons { get; private set; }

        public Terrorist(int _rank, Weapon _weapon, Location _location) : base(_rank, _weapon, _location)
        {
            IsAlive = true;
        }
        public Terrorist(int _rank, List<Weapon> _weapons, Location _location) : base (_rank, _weapons, _location)
        {
            IsAlive = true;
        }



    }
}
