using IDF_Operation.Enemy;
using IDF_Operation.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public class Aman
    {

        //if Hamas add terrorists, we need to crea an update function, for create more reports. 
        //also, if the terrorist not died, we need to create another report.


        private List<IntelligenceReport> IntelligenceReport;

        private Hamas Bad;

        public Aman()
        {
            IntelligenceReport = new List<IntelligenceReport>();
            Bad = new Hamas();
            UpdateIntelligenceReports();
        }

        public List<IntelligenceReport> GetIntelligenceReports()
        {
            return IntelligenceReport;
        }
        
        public List<IntelligenceReport> UpdateIntelligenceReports()
        {
            if (IntelligenceReport.Count > 0) IntelligenceReport.Clear();
            foreach (Terrorist trst in Bad.Soldiers)
            {
                IntelligenceReport report = new IntelligenceReport(trst, trst.CurrentLocation);
                IntelligenceReport.Add(report);
            }
            Console.WriteLine(IntelligenceReport[0] + "\n\n\n");

            return IntelligenceReport;
        }



    }
}
