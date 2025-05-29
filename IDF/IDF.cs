using IDF_Operation.Enemy;
using IDF_Operation.Exceptions;
using IDF_Operation.General;
using IDF_Operation.General.WeaponFolder.IsraeliWeapons;
using IDF_Operation.Genertor;
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
            intelligenceReport = aman.GetIntelligenceReports();
            taskReport = new List<TaskReport>();
            CreateTaskReports();
            SortByDangerous();

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
                foreach (var task in taskReport)
                {
                    if (!task.Success)
                    {
                        return task;
                    }
                }
                throw new NoTasks();
        }
        public void Fire(TaskReport task)
        {
            task.Success = true;
            Console.WriteLine("Success!!!");
            task.IntelligenceReportSpecific.TerroristPersonality.IsAlive = false;
            task.Success= true;   
        }

        public void CreateTaskReports() 
        {
            foreach (IntelligenceReport intel in intelligenceReport)
            {
                try
                {
                    taskReport.Add(Strike.AnalyzeAttack(intel, Soldiers));
                }
                catch (NotHaveAvalbleSoldiers)
                {
                    //throw new NotHaveAvalbleSoldiers();
                    continue;   
                }
            }
            SortByDangerous();
        }
        public void SortByDangerous()
        {
            taskReport.Sort((t1, t2) => t2.IntelligenceReportSpecific.TerroristPersonality.Dangerous.CompareTo(t1.IntelligenceReportSpecific.TerroristPersonality.Dangerous));
            //taskReport = taskReport.OrderByDescending(t => t.IntelligenceReportSpecific.TerroristPersonality.Dangerous).ToList();
            
        }

        public void PrintAliveTerrorist()
        {
            aman.PrintAliveTerrorist();
        }
        public void PrintSoldiers()
        {
            foreach(var s in Soldiers)
            {
                Console.WriteLine(s);
            }
        }



    }
}
