namespace EventEase.Models;

public class AttendanceRecord
{
    public int EventId { get; set; }
    public string UserName { get; set; } = "";
    public DateTime Timestamp { get; set; } = DateTime.Now;
}
