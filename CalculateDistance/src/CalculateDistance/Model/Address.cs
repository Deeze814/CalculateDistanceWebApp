
namespace CalculateDistance.Model
{
    public class Address
    {
        private string streetNumber;
        private string streetName;
        private string streetSuffix;
        private string city;
        private string state;
        private string zip;
        private string latitude;
        private string longitude;

        public string StreetNumber
        {
            get { return streetNumber; }
            set { streetNumber = value; }
        }

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public string StreetSuffix
        {
            get { return streetSuffix; }
            set { streetSuffix = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }

        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
    }
}
