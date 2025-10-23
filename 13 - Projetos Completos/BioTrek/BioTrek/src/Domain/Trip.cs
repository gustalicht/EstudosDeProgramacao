public class Trip
{
    public int Id { get; set; }
    public string Destination { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<string> Activities { get; set; }

    public Trip()
    {
        Activities = new List<string>();
    }
}