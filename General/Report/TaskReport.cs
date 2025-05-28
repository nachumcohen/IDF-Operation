using IDF_Operation.Enemy;
using IDF_Operation.General.WeaponFolder.NonRealWeapons;
using System;
using System.Net.WebSockets;

public class TaskReport : Report
{
	private int reportId;
	private bool success;
	public static int ReportCounts { get; private set; }
    private IntelligenceReport intelligenceReportSpecific;
	private Weapon weaponSpecific;
    public int Id { get { return reportId; } private set { reportId = value;} }

    public IntelligenceReport IntelligenceReportSpecific { get { return intelligenceReportSpecific; } private set { intelligenceReportSpecific = value; } }
	
	public Weapon WeaponSpecific { get { return weaponSpecific; } private set { weaponSpecific = value; } }

	public bool Success { get { return success; } set { if (value) { success = true; IntelligenceReportSpecific.TerroristPersonality.IsAlive = false; } } }
	public double Distance { get; private set; }
	public TaskReport(IntelligenceReport _intelligenceReport, Weapon _weaponSpecicfic, double _distance)
	{
		ReportCounts += 1;
		reportId = ReportCounts;
		IntelligenceReportSpecific = _intelligenceReport;
		WeaponSpecific = _weaponSpecicfic;
		Distance = _distance;
	}
    public override string ToString()
    {
        return $"Report Id is: {Id}\n" +
			$"Intelligence Report is: {IntelligenceReportSpecific}\n" +
			$"The man that will attack will be: {WeaponSpecific.UniqueSoldier.Name}, with the weapon {WeaponSpecific.Name}" +
			$"He is in {Distance}KM from the Target.\n";
    }

}
