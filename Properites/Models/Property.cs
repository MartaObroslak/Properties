namespace Properites.Models
{
    public class Property
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public required string Thumbnail { get; set; }
        public IEnumerable<string> Photos { get; set; } = [];
        public required string Location { get; set; }
        public int SquareMeters { get; set; }
        public required string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
