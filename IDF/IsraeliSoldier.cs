using IDF_Operation.Exceptions;
using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.IsraeliWeapons;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public class IsraeliSoldier : Soldier, IStrike
    {

        public IsraeliSoldier(string name, int _rank, Weapon _weapon, Location _location) : base (_rank, _weapon, _location)
        {
           base.Name = name;
        }
        public IsraeliSoldier(string name, int _rank, List<Weapon> _weapons, Location _location) : base(_rank, _weapons, _location)
        {
            base.Name = name;
        }


        public bool IsAbillityToStrike(double distance ,string attackArea)
        {
            ElectricalWeapon wep = (ElectricalWeapon)Weapons[0];

            string[] areas = wep.TypeOfBomb.Split(" ");

            bool energy = wep.Energy < (wep.EnergyPerKM * distance) * 2
                , bullets = wep.AmmunitionCapacity > 1,
                  area = false;
            
            foreach (string s in areas)
            {
                if(s == attackArea)
                {
                    area = true;
                }
            }
            
            return energy && bullets && area;
        }

        public void Strike(double distance, string area)
        {

            if (!IsAbillityToStrike(distance, area)) { throw new ICantAttack(); }
            ElectricalWeapon wep = (ElectricalWeapon) Weapons[0];

            MoveToTarget(wep, distance);
            Fire(wep);
            ComeHome(wep, distance);
        }

        void MoveToTarget(ElectricalWeapon wep, double distance)
        {
            wep.Energy -= wep.EnergyPerKM * distance;
            Console.WriteLine("MovingToTarget");
        }
        void Fire(ElectricalWeapon wep)
        {
            wep.AmmunitionCapacity--;
            Console.WriteLine("Shooting!");
        }
        void ComeHome(ElectricalWeapon wep, double distance)
        {
            wep.Energy -= wep.EnergyPerKM * distance;
            Console.WriteLine("Coming back.");
        }

    }
}
