using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Genertor.GenerateReport
{
    public class GenerateTaskReport
    {
        public static TaskReport Generate(IntelligenceReport _intelligenceReport, Weapon _weapon, double _distance)
        {
            return new TaskReport(_intelligenceReport, _weapon, _distance);
        }
    }
}
