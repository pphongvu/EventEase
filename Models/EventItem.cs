namespace EventEase.Models;

public class EventItem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime Date { get; set; }
    public string Location { get; set; } = "";
    public string Description { get; set; } = "";

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Name)
            && !string.IsNullOrWhiteSpace(Location)
            && Date > DateTime.MinValue;
    }

}
