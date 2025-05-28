using IDF_Operation.Enemy;
using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.IsraeliWeapons;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using IDF_Operation.General.WeaponFolder.TerroristWeapon;
using IDF_Operation.IDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Genertor.GenerateSoldier
{
    public static class GenerateSoldier
    {
        
        public static IsraeliSoldier GenerateIsraeliSoldier()
        {
            Location location = GenerateLocation.Generate();

            Weapon wep;
                int wepChoice = new Random().Next(0, 3);

            switch (wepChoice)
            {
                case 0:
                    wep = new Zik();
                    break;
                case 1:
                    wep = new M109();
                    break;
                case 2:
                    wep = new F16();
                    break;
                default:
                    wep = new Zik();
                    break;
            }
            
            IsraeliSoldier il = new IsraeliSoldier("moshe", new Random().Next(1, 6), wep, location);
            wep.LinkSoldierToWeapon(il);
            return il;
        }

        public static Terrorist GenerateTerrorist()
        {
            Location location = GenerateLocation.Generate();

            Weapon wep;
            int wepChoice = new Random().Next(0, 4);

            switch (wepChoice)
            {
                case 0:
                    wep = new AK47();
                    break;
                case 1:
                    wep = new M16();
                    break;
                case 2:
                    wep = new Knife();
                    break;
                case 3:
                    wep = new Gun();
                    break;
                default:
                    wep = new Knife();
                    break;
            }

            Terrorist pl = new Terrorist("Ahmed", new Random().Next(1, 6), wep, location);
            wep.LinkSoldierToWeapon(pl);
            return pl;
        }

        public static List<IsraeliSoldier> GenerateListOfIsraeliSoldier(int num)
        {
            List<IsraeliSoldier> israeliList = new List<IsraeliSoldier>();
            for(int i =0; i<num; i++)
            {
                israeliList.Add(GenerateIsraeliSoldier());
            }
            return israeliList;
        }
        public static List<Terrorist> GenerateListOfTerrorist(int num)
        {
            List<Terrorist> terroristList = new List<Terrorist>();
            for (int i = 0; i < num; i++)
            {
                terroristList.Add(GenerateTerrorist());
            }
            return terroristList;
        }

    }
}
