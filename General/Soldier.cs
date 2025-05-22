using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    public class Soldier
    {
        public virtual string Name
        {
            get; set
            {
                if (Name == null) { Name = value; }
            }
        }
        public virtual int Rank { get; set { if (value <= 5 && value >= 1) { Rank = value; } } }

        public virtual List<Weapon> Weapons { get; private set { } }

        public virtual Location CurrentLocation { get; private set; }

        public virtual void AddWeapon(Weapon _weapon)
        {
            Weapons.Add(_weapon);
        }

        public virtual void AddLocation(Location _location)
        {
            currentLocation = _location;
        }

        public Soldier(int _rank, Weapon _weapon)
        {
            Weapons = new List<Weapon>();
            Rank = _rank;
            Weapons.Add(_weapon);
        }
        public Soldier(int _rank, List<Weapon> _weapons)
        {
            Weapons = new List<Weapon>();
            Rank = _rank;
            Weapons.AddRange(_weapons);
        }

    }
}
