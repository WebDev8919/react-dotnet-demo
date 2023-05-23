namespace webapi.Models.Users;

using System.ComponentModel.DataAnnotations;
using webapi.Entities;

public class CreateRequest
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }
}
