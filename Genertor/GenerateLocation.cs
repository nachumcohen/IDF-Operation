using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.Genertor
{
    public class GenerateLocation
    {
        public static Location Generate()
        {
            Random RandomLocation = new Random();


            int minLongi = (int)(Location.minLongitudeOfGaza * 1000);
            int maxLongi = (int)(Location.maxLongitudeOfGaza * 1000);


            double Longi = (double)RandomLocation.Next(minLongi, maxLongi) / 1000;



            int minLati = (int)(Location.minLatitudeOfGaza * 1000);
            int maxLati = (int)(Location.maxLatitudeOfGaza * 1000);


            double Lati = (double)RandomLocation.Next(minLati, maxLati) / 1000;


            string[] areas = { "Building", "Car", "OpenArea", "People" };

            Random areaRandom = new Random();
            string area = areas[areaRandom.Next(0, 3)];
            return new Location(Lati, Longi, area);
        }

        public static Location CopyLocation(Location _location)
        {
            return new Location(_location.Latitude,_location.Longitude, _location.Area);
        }
    }
}
