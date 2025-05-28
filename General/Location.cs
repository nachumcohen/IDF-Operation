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
			case "Building":
				return true;
			case "Car":
				return true;
			case "OpenArea":
				return true;
			case "People":
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

	public static double DistanceBetweenTwoPoints(Location loca1, Location loca2)
	{

		double lat1 = loca1.Latitude;
		double lon1 = loca1.Longitude;
		double lat2 = loca2.Latitude;
		double lon2 = loca2.Longitude;



        double R = 6371;
		double ToRaidans = Math.PI / 180;
		double dLat = (lat2 - lat1) * ToRaidans;
		double dLon = (lon2 - lon1) * ToRaidans;


		double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
			  Math.Cos(lat1) * Math.Cos(lat2) *
			  Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

		double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
		return R * c;
	}

    public override string ToString()
    {
        return $"latitude: {latitude}, longitude: {longitude}, area: {area}";
    }
}
