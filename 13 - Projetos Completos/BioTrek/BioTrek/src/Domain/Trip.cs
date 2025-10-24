namespace BioTrek.Domain
{
    public class Trip
    {
        public int Id { get; set; }
        public string Destination { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<string> Activities { get; set; }

        public Trip()
        {
            Activities = new List<string>();
        }
    }
}