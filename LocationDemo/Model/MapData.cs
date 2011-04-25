using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Device.Location;

namespace BingMapsDemo.Model
{
    /// <summary>
    /// Data-bound class for updating the map's on-screen content
    /// 
    /// Taken from Professional Windows Phone 7 Application Development by Wrox
    /// http://www.amazon.com/Professional-Windows-Phone-Application-Development/dp/0470891661/ref=sr_1_1?ie=UTF8&qid=1303764167&sr=8-1
    /// </summary>
    public class MapData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisedPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Default coordinate maps to Coloft (http://www.coloft.com/) in Santa Monica, courtesy of
        /// http://www.livephysics.com/ptools/location-to-geo-coordinates.php
        /// </summary>
        private GeoCoordinate mapCenter = new GeoCoordinate(34.020355, -118.490115);
        public GeoCoordinate MapCenter
        {
            get { return this.mapCenter; }
            set
            {
                if (mapCenter == value) return;
                mapCenter = value;
                RaisedPropertyChanged("MapCenter");
            }
        }

        /// <summary>
        /// Set a default map zoom...
        /// </summary>
        private double zoom = 14.0;
        public double Zoom
        {
            get { return zoom; }
            set
            {
                if (zoom == value) return;
                zoom = value;
                RaisedPropertyChanged("Zoom");
            }
        }

        /// <summary>
        /// Locations of some populate places around Santa Monica...
        /// </summary>
        private ObservableCollection<MapPushpin> _pins = new ObservableCollection<MapPushpin>()
                                                            {
                                                                new MapPushpin()
                                                                    {
                                                                        PinLocation =
                                                                            new GeoCoordinate(34.018200, -118.489564),
                                                                        Data = new string[] {"Swinger's Cafe", "Food"}
                                                                    },
                                                                new MapPushpin()
                                                                    {
                                                                        PinLocation = new GeoCoordinate(34.020355, -118.490115),
                                                                        Data = new string[]{"Coloft"}
                                                                    },
                                                                new MapPushpin(){
                                                                    PinLocation = new GeoCoordinate(34.024590, -118.491349),
                                                                    Data = new string[]{"NY&C", "Food", "Pizza"}
                                                                }
                                                            };

        public ObservableCollection<MapPushpin> Pins
        {
            get { return _pins; }
        }

        private MapPushpin selectedPin;
        public MapPushpin SelectedPin
        {
            get { return this.selectedPin; }
            set
            {
                if (selectedPin == value) return;
                selectedPin = value;
                RaisedPropertyChanged("SelectedPin");
            }
        }
    }
}
