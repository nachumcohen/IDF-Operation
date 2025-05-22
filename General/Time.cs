using System;
using System.Security.Cryptography.X509Certificates;

public class Times
{
	public string Format = "dd.MM.yyyy hh:mm:ss";
	
	public string Time { get; private set; }
	public Times(string _format = "")
	{
		if (_format != "")
		{
			Format = _format;
		}
		Time = CreateTimeSign();
	}

	public void ResetFormat()
	{
		Format = "dd.MM.yyyy hh.mm.ss";
    }
	public string CreateTimeSign()
	{
		return DateTime.Now.ToString(Format);
	}
    public override string ToString()
    {
        return Time;
    }

}
