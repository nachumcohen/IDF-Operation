using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.General
{
    public class Soldier : IStrike
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




        
        int IStrike.EnergyPerKM => throw new NotImplementedException();

        public virtual void AddWeapon(Weapon _weapon)
        {
            Weapons.Add(_weapon);
        }

        public virtual void AddLocation(Location _location)
        {
            CurrentLocation = _location;
        }

        public bool TryingSendStrike(int _distance, int requiersBomb)
        {
            throw new NotImplementedException();
        }

        public bool CheckAvailebleStrike()
        {
            throw new NotImplementedException();
        }

        public void MoveToTarget()
        {
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void ComeHome()
        {
            throw new NotImplementedException();
        }

        bool IStrike.TryingSendStrike(int _distance, int requiersBomb)
        {
            throw new NotImplementedException();
        }

        bool IStrike.CheckAvailebleStrike()
        {
            throw new NotImplementedException();
        }

        void IStrike.MoveToTarget()
        {
            throw new NotImplementedException();
        }

        void IStrike.Fire()
        {
            throw new NotImplementedException();
        }

        void IStrike.ComeHome()
        {
            throw new NotImplementedException();
        }

        protected int EnergyPerKM;
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
            return $"Name is: {Name}, Rank is: {Rank}, Location {CurrentLocation}, Weapon: {WeaponsList(Weapons)}";
        }

    }
}
