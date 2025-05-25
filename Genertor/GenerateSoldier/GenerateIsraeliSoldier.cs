using IDF_Operation.General.WeaponFolder;
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

            return new IsraeliSoldier("moshe", new Random().Next(1,5), wep, location);
        }

    }
}
