using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.IsraeliWeapons;
using IDF_Operation.Genertor;
using IDF_Operation.Genertor.GenerateSoldier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public class IDF : Organizition
    {
        public string DateOfEstablishment => "26.5.1948";

        public Soldier ChairmanOfTheOrganization => new IsraeliSoldier("ChairMan", 10, new F16(), GenerateLocation.Generate());

        public List<Soldier> Soldiers => GenerateSoldier.GenerateListOfIsraeliSoldier(20);

        private Aman aman;
        public List<IntelligenceReport> intelligenceReport;

        public void UpdateIntelligenceReport()
        {
            intelligenceReport = aman.GetIntelligenceReports();
        }

        public IDF()
        {
            aman = new Aman();
        }

    }
}
