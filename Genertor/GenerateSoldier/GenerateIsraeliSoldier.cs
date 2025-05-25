using IDF_Operation.General.WeaponFolder;
using IDF_Operation.IDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Genertor.GenerateSoldier
{
    public static class GenerateSoldier
    {
        public static IsraeliSoldier GenerateSoldier()
        {
            return new IsraeliSoldier(5, new F16("j", 40, 100, "building"));
        }

    }
}
