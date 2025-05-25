using System;

public class Location
{
	private double latitude;
	private double longitude;
	private string area;


	public const double minLatitudeOfGaza = 31.22;
	public const double maxLatitudeOfGaza = 31.553;

	public const double minLongitudeOfGaza = 34.2;
	public const double maxLongitudeOfGaza = 34.570;




	public double Latitude { get { return latitude; } private set { if (ValidateLatitude(value)) { latitude = value; } else { Console.WriteLine("Latitude Dosen't Exist in gaza"); } } } 
	public double Longitude { get { return longitude;} private set { if (ValidateLongitude(value)) {longitude = value; } else { Console.WriteLine("Longitude Dosen't Exist in gaza"); } } }
	
	public string Area { get { return area; } private set { if (ValidateArea(value)) { area = value; } else { Console.WriteLine("Wrong Area"); } } }
	
	public Location(double _latitude, double _longitude, string _area)
	{
		Latitude = _latitude;
		Longitude = _longitude;
		Area = _area;
	}

	public bool ValidateArea(string area)
	{
		switch (area){
			case "Home":
				return true;
			case "Car":
				return true;
			case "OpenArea":
				return true;
			default:
				return false;
				}
			

	}

	public bool ValidateLatitude(double value) 
	{
		return value >= minLatitudeOfGaza && value <= maxLatitudeOfGaza;
    }
	public bool ValidateLongitude(double value)
	{
        return value >= minLongitudeOfGaza && value <= maxLongitudeOfGaza;
    }


    public override string ToString()
    {
        return $"latitude: {latitude}, longitude: {longitude}, area: {area}";
    }
}
