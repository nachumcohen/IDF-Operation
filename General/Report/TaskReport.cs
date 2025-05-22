using IDF_Operation.Enemy;
using System;
using System.Net.WebSockets;

public class TaskReport : Report
{

	public static int ReportId { get { return ReportId; } private set { ReportId = value;} }

	
	public TaskReport()
	{
		ReportId += 1;
	}

}
