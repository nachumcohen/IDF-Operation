using IDF_Operation.Enemy;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Net.WebSockets;

public class TaskReport : Report
{
	public static int ReportCounts { get; }
	public  int Id { get { return Id; } private set { Id = value;} }

	public IntelligenceReport IntelligenceReportSpecific { get { return IntelligenceReportSpecific; } private set { IntelligenceReportSpecific = value; } }
	
	public Weapon WeaponSpecific { get { return WeaponSpecific; } private set { WeaponSpecific = value; } }

	public bool Success;
	public TaskReport(IntelligenceReport _intelligenceReport, Weapon _weaponSpecicfic)
	{
		Id += 1;
		IntelligenceReportSpecific = _intelligenceReport;
		WeaponSpecific = _weaponSpecicfic;
	}

}
