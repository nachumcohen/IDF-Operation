using IDF_Operation.General;
using IDF_Operation.Genertor.GenerateReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    public static class Strike
    {
        
        public static TaskReport AnalyzeAttack(IntelligenceReport _intelligenceReport, List<IsraeliSoldier> _soldiers)
        {
            var distances = SoldiersDistances(_intelligenceReport, _soldiers);
            var Availble = GetAvailbleCloseSoldierToAttack(_intelligenceReport, distances);

            return GenerateTaskReport.Generate(_intelligenceReport, Availble.Weapons[0], distances[Availble]);
        }
        private static Dictionary<IsraeliSoldier, double> SoldiersDistances(IntelligenceReport _intelligenceReport, List<IsraeliSoldier> _soldiers)
        {
            Dictionary<IsraeliSoldier, double> Availbles = new Dictionary<IsraeliSoldier, double>();
            Location terroristLocation = _intelligenceReport.TerroristPersonality.CurrentLocation;

            foreach (IsraeliSoldier israeli in _soldiers)
            {
                double distanceBetween = Location.DistanceBetweenTwoPoints(terroristLocation, israeli.CurrentLocation);
                Availbles[israeli] = distanceBetween;
            }

            return Availbles;
        }
        private static IsraeliSoldier GetAvailbleCloseSoldierToAttack(IntelligenceReport _intelligenceReport, Dictionary<IsraeliSoldier, double> _soldiers)
        {
            IsraeliSoldier tmpIsraeli = null;
            double distance = 1.7976931348623157E+308;

            Location terroristLocation = _intelligenceReport.TerroristPersonality.CurrentLocation;

            foreach (IsraeliSoldier israeli in _soldiers.Keys)
            {
                double specificlyDistance = _soldiers[israeli];
                bool abillity = israeli.IsAbillityToStrike(specificlyDistance, _intelligenceReport.LocationPersonality.Area);
                if (abillity && distance > specificlyDistance)
                {
                    distance = specificlyDistance;
                    tmpIsraeli = israeli;
                }
            }
            return tmpIsraeli;

        }


    }
}
