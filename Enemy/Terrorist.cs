using IDF_Operation.General;

namespace IDF_Operation.Enemy
{
    public class Terrorist : Soldier
    {
        public string Name
        {
            get; set
            {
                if (Name == null) { Name = value; }
            }
        }

        public int Rank { get; set { if (value <= 5 && value >= 1) { Rank = value; } } }

        public bool IsAlive { get; set; }
        
        public Location currentLocation;
        public List<Weapon> Weapons { get; private set; }

        public Terrorist(int _rank, Weapon _weapon)
        {
            Weapons = new List<Weapon>();
            IsAlive = true;
            Rank = _rank;
            Weapons.Add(_weapon);
        }
        public Terrorist(int _rank, List<Weapon> _weapons)
        {
            Weapons = new List<Weapon>();
            IsAlive = true;
            Rank = _rank;
            Weapons.AddRange(_weapons);
        }
        public void AddWeapon(Weapon _weapon)
        {
            Weapons.Add(_weapon);
        }

        public void AddLocation(Location _location)
        {
            currentLocation = _location;
        }



    }
}
