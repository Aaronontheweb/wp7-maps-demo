using System.Device.Location;

namespace BingMapsDemo.Model
{
    /// <summary>
    /// Class used to contain data for pinning areas of interest on a Bing Maps control
    /// 
    /// Taken from Professional Windows Phone 7 Application Development by Wrox
    /// http://www.amazon.com/Professional-Windows-Phone-Application-Development/dp/0470891661/ref=sr_1_1?ie=UTF8&qid=1303764167&sr=8-1
    /// </summary>
    public class MapPushpin
    {
        public GeoCoordinate PinLocation { get; set; }
        public string[] Data { get; set; }

        public string PinContent
        {
            get
            {
                return Data == null ? "0" : Data.Length.ToString();
            }
        }
    }
}
