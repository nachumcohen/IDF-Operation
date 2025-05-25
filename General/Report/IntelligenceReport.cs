using IDF_Operation.Enemy;
using System;

public class IntelligenceReport : Report
{

    public static int ReportId { get { return ReportId; } private set { ReportId = value; } }

    public Terrorist TerroristPersonality { get; }

    public Location LocationPersonality { get; }

    public Times TimePeronality { get; }
    public IntelligenceReport(int id, Terrorist _terrorist, Location _location)
    {
        LocationPersonality = _location;
        TerroristPersonality = _terrorist;
        ReportId += 1;
    }
}
