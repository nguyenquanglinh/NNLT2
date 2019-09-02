using Google.Maps;
using Google.Maps.Geocoding;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ggMaps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //always need to use YOUR_API_KEY for requests.  Do this in App_Start.
            GoogleSigned.AssignAllServices(new GoogleSigned("AIzaSyBwDcXW2x5Ekk8o5wCKVyc-vv5LgWURYGo"));

            var request = new GeocodingRequest();
            request.Address = "hanoi";
            var response = new GeocodingService().GetResponse(request);

            //The GeocodingService class submits the request to the API web service, and returns the
            //response strongly typed as a GeocodeResponse object which may contain zero, one or more results.

            //Assuming we received at least one result, let's get some of its properties:
            if (response.Status == ServiceResponseStatus.Ok && response.Results.Count() > 0)
            {
                var result = response.Results.First();

                Console.WriteLine("Full Address: " + result.FormattedAddress);         // "1600 Pennsylvania Ave NW, Washington, DC 20500, USA"
                Console.WriteLine("Latitude: " + result.Geometry.Location.Latitude);   // 38.8976633
                Console.WriteLine("Longitude: " + result.Geometry.Location.Longitude); // -77.0365739
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Unable to geocode.  Status={0} and ErrorMessage={1}", response.Status, response.ErrorMessage);
            }
        }
    }
}
