using System.ComponentModel.DataAnnotations;

namespace EventEase.Models;

public class Registration
{
    public int EventId { get; set; }

    [Required(ErrorMessage = "Your name is required.")]
    [MinLength(2, ErrorMessage = "Name must be at least 2 characters.")]
    public string UserName { get; set; } = "";

    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = "";

    [Range(1, 20, ErrorMessage = "Attendee count must be between 1 and 20.")]
    public int AttendeeCount { get; set; } = 1;
}
