

namespace IDF_Operation.IDF
{
    public static class Strike
    {
        
        public static TaskReport AnalyzeAttack(IntelligenceReport _intelligenceReport, List<IsraeliSoldier> _soldiers)
        {
            var distances = SoldiersDistances(_intelligenceReport, _soldiers);
            var Availble = GetAvailbleCloseSoldierToAttack(_intelligenceReport, distances);
            Console.WriteLine(_intelligenceReport);
            if(Availble is null)
            {
                throw new Exception("There is no one that can do it");
            }
            return new TaskReport(_intelligenceReport, Availble.Weapons[0], distances[Availble]);
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
                //needs to fix the abillity of the soldiers
                bool abillity = israeli.IsAbillityToStrike(specificlyDistance, _intelligenceReport.LocationPersonality.Area);
                if (abillity&& distance > specificlyDistance)
                {
                    distance = specificlyDistance;
                    tmpIsraeli = israeli;
                }
                //if (tmpIsraeli is null) { Console.WriteLine("Here is THE Problem\n" + abillity); }
            }
            return tmpIsraeli;

        }


    }
}
