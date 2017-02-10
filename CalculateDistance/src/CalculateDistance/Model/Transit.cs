using CalculateDistance.Domain;

namespace CalculateDistance.Model
{
    public class Transit
    {
        private Address origin;
        private Address destination;

        public Address Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public Address Destination
        {
            get { return destination; }
            set { destination = value; }
        }
    }
}
