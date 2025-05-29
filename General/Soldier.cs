using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    public class Soldier
    {

        private int rank;
        private string name;


        public virtual string Name
        {
            get { return name; }
            set
            {
                if (name == null) { name = value; }
            }
        }

        public virtual int Rank { get { return rank; } set { if (value <= 5 && value >= 1) { rank = value; } } }

        public virtual List<Weapon> Weapons { get; private set; }

        public virtual Location CurrentLocation { get; private set; }




        

        public virtual void AddWeapon(Weapon _weapon)
        {
            Weapons.Add(_weapon);
        }

        public virtual void AddLocation(Location _location)
        {
            CurrentLocation = _location;
        }


        public Soldier(int _rank, Weapon _weapon, Location _location)
        {
            CurrentLocation = _location;
            Weapons = new List<Weapon>();
            Rank = _rank;
            Weapons.Add(_weapon);
        }
        public Soldier(int _rank, List<Weapon> _weapons, Location _location)
        {
            CurrentLocation = _location;
            Weapons = new List<Weapon>();
            Rank = _rank;
            Weapons.AddRange(_weapons);
        }

        private string WeaponsList(List<Weapon> _weapons)
        {
            string convertedWeaponsList = "";
            foreach (Weapon weapon in _weapons)
            {
                convertedWeaponsList += weapon.ToString();
            }
            return convertedWeaponsList;
        }

        public override string ToString()
        {
            return $"" +
                $"\nName is: {Name}\n" +
                $"Rank is: {Rank}\n" +
                $"Location {CurrentLocation}\n" +
                $"Weapon: {WeaponsList(Weapons)}";
        }

    }
}
