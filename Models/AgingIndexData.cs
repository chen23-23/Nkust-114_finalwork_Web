
namespace AgingIndexWeb.Models
{
    public class AgingIndexData
    {
        public string Country { get; set; } = string.Empty;
        public int Year { get; set; }
        public int RepublicYear { get; set; }
        public string Category { get; set; } = string.Empty;
        public double AgingIndex { get; set; }
    }
}
