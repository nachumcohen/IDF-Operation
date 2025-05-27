using IDF_Operation.Enemy;
using System;

public class IntelligenceReport : Report
{

    public static int ReportCounts { get; private set; }

    public int Id { get;  }
    public Terrorist TerroristPersonality { get; }

    public Location LocationPersonality { get; }

    public Times TimePeronality { get; }
    public IntelligenceReport(Terrorist _terrorist, Location _location)
    {
        LocationPersonality = _location;
        TerroristPersonality = _terrorist;

        ReportCounts += 1;
        Id = ReportCounts;
    }
}
