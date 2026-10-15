using EventEase.Models;

namespace EventEase.Services;

public class AttendanceService
{
    private readonly List<AttendanceRecord> _records = new();

    public void MarkAttendance(int eventId, string userName)
    {
        _records.Add(new AttendanceRecord
        {
            EventId = eventId,
            UserName = userName,
            Timestamp = DateTime.Now
        });
    }

    public List<AttendanceRecord> GetAttendance(int eventId)
    {
        return _records.Where(r => r.EventId == eventId).ToList();
    }
}
