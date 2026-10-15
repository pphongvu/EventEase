using EventEase.Models;

namespace EventEase.Services;

public class MockEventService
{
    private readonly List<EventItem> _events = new()
    {
        new EventItem
        {
            Id = 1,
            Name = "Coding Interview Prep Workshop",
            Date = DateTime.Today.AddDays(7),
            Location = "Santa Ana, CA",
            Description = "Preparation session for coding interviews."
        },
        new EventItem
        {
            Id = 2,
            Name = "Accelerate Your Job Search with AI",
            Date = DateTime.Today.AddDays(14),
            Location = "Irvine, CA",
            Description = "A workshop on leveraging AI tools to enhance your job search."
        }
    };

    private List<EventItem>? _cachedEvents;

    public List<EventItem> GetEvents()
    {
        if (_cachedEvents == null)
            _cachedEvents = _events.Where(e => e.IsValid()).ToList();

        return _cachedEvents;
    }



    public EventItem? GetEvent(int id) =>
        _events.FirstOrDefault(e => e.Id == id);

}
