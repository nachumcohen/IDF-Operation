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

        public IDF()
        {
            aman = new Aman();
            aman.GetIntelligenceReports();
        }

        public string DateOfEstablishment => "26.5.1948";
        public Soldier ChairmanOfTheOrganization => new IsraeliSoldier("ChairMan", 10, new F16(), GenerateLocation.Generate());
        public List<IsraeliSoldier> Soldiers => GenerateSoldier.GenerateListOfIsraeliSoldier(20);

        private Aman aman;


        public List<IntelligenceReport> intelligenceReport { get; private set; }
        public List<TaskReport> taskReport { get; private set; }


        public void UpdateIntelligenceReport()
        {
            intelligenceReport = aman.GetIntelligenceReports();
        }
        public TaskReport ShowAvailbleStrike()
        {
            UpdateIntelligenceReport();
            taskReport.Add(Strike.AnalyzeAttack(intelligenceReport[0], Soldiers));
            return taskReport[0];
        }
        public void Fire()
        {
            taskReport[0].Success = true;
            Console.WriteLine("Success!!!");
            intelligenceReport.RemoveAt(0);
        }







    }
}
