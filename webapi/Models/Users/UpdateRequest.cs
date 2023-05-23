namespace webapi.Models.Users;

using System.ComponentModel.DataAnnotations;
using webapi.Entities;

public class UpdateRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    [EmailAddress]
    public string? Email { get; set; }


    private string? replaceEmptyWithNull(string value)
    {
        return string.IsNullOrEmpty(value) ? null : value;
    }
}
