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
            Console.WriteLine(location);
            return new IsraeliSoldier("moshe", 5, new F16(), location);
        }

    }
}
