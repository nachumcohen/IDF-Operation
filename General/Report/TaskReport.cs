using IDF_Operation.Enemy;
using System;
using System.Net.WebSockets;

public class TaskReport : Report
{

	public static int ReportId { get { return ReportId; } private set { ReportId = value;} }

	public IntelligenceReport IntelligenceReportSpecific { get { return IntelligenceReportSpecific; } private set { IntelligenceReportSpecific = value; } }
	
	public Weapon WeaponSpecific { get { return WeaponSpecific; } private set { WeaponSpecific = value; } }

	public bool Success;
	public TaskReport(IntelligenceReport _intelligenceReport, Weapon _weaponSpecicfic)
	{
		ReportId += 1;
		IntelligenceReportSpecific = _intelligenceReport;
		WeaponSpecific = _weaponSpecicfic;
	}

}
