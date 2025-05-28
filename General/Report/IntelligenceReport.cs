using IDF_Operation.Enemy;
using System;

public class IntelligenceReport : Report
{

    public static int ReportCounts { get; private set; }

    public int Id { get;  }
    public Terrorist TerroristPersonality { get; }

    public Location LocationPersonality { get; }

    public Times TimePersonality { get; }
    public IntelligenceReport(Terrorist _terrorist, Location _location)
    {
        LocationPersonality = _location;
        TerroristPersonality = _terrorist;

        ReportCounts += 1;
        Id = ReportCounts;

        TimePersonality = new Times();
    }
    public override string ToString()
    {
        return $"Id: {Id}. Terrorist: {TerroristPersonality}. Time: {TimePersonality}";
    }
}
