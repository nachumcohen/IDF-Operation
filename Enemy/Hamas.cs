using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.TerroristWeapon;
using IDF_Operation.Genertor;
using IDF_Operation.Genertor.GenerateSoldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Enemy
{
    public class Hamas : Organizition
    {
        public Hamas()
        {
            Soldiers =  GenerateSoldier.GenerateListOfTerrorist(20);
        }

        public string DateOfEstablishment { get { return "1987"; } }
        public Soldier ChairmanOfTheOrganization { get; } = new Terrorist("ChairMan", 10, new Gun(), GenerateLocation.Generate());
        public List<Terrorist> Soldiers { get; }
    }
}
