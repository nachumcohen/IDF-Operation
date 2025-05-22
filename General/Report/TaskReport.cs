using IDF_Operation.Enemy;
using System;
using System.Net.WebSockets;

public class TaskReport : Report
{
	public override int ReportId { get { return ReportId; } set { if (ReportId == null) { ReportId = value; } } }

	public Terrorist TerroristPersonality { get; }

	public Location LocationPersonality { get; }

	public Time TimePeronality { get; }
	public TaskReport(int id, Terrorist _terrorist, Location _location)
	{
		LocationPersonality = _location;
		TerroristPersonality = _terrorist;
		ReportId = id;
	}

}
