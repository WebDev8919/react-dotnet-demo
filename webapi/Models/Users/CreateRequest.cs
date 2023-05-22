﻿namespace webapi.Models.Users;

using System.ComponentModel.DataAnnotations;
using webapi.Entities;

public class CreateRequest
{
    [Required]
    public string? Title { get; set; }

    [Required]
    public string? FirstName { get; set;}

    [Required]
    public string? LastName { get; set;}

    [Required]
    [EnumDataType(typeof(Role))]
    public string? Role { get; set;}

    [Required]
    [EmailAddress]
    public string? Email { get; set;}

    [Required]
    [MinLength(6)]
    public string? Password { get; set;}

    [Required]
    [Compare("Password")]
    public string? PasswordConfirmation { get; set; }
}