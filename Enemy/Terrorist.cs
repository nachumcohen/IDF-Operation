using IDF_Operation.General;

namespace IDF_Operation.Enemy
{
    public class Terrorist : Soldier
    {
        public override string Name => base.Name;

        public override int Rank => base.Rank;

        public bool IsAlive { get; set; }
        
        public List<Weapon> Weapons { get; private set; }

        public Terrorist(int _rank, Weapon _weapon) : base(_rank, _weapon)
        {
            IsAlive = true;
        }
        public Terrorist(int _rank, List<Weapon> _weapons) : base (_rank, _weapons)
        {
            IsAlive = true;
        }



    }
}
