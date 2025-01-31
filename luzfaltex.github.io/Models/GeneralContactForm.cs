using System.ComponentModel.DataAnnotations;

namespace luzfaltex.github.io.Models;

/// <summary>
/// Defines the backing data for a general contact form.
/// </summary>
public class GeneralContactForm
{
    /// <summary>
    /// Gets or sets the date that the form is submitted.
    /// </summary>
    public DateTimeOffset SubmittedAt { get; set; }
    
    /// <summary>
    /// Gets or sets the name of the person contacting us.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the type of question
    /// </summary>
    [Required(ErrorMessage = "A contact type is required.")]
    public string Type { get; set; } = "";
    
    [Required(ErrorMessage = "A subject is required.")]
    [MinLength(3, ErrorMessage = "The subject must be at least 3 characters.")]
    public string Subject { get; set; }
    
    /// <summary>
    /// Gets or sets the priority of the ticket.
    /// </summary>
    [Required]
    public string Priority { get; set; }
    
    /// <summary>
    /// Gets or sets the user's email.
    /// </summary>
    [Required]
    [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
    public string Email { get; set; }
    
    [Required]
    [MinLength(30, ErrorMessage = "The email address must be at least 30 characters.")]
    [DataType(DataType.MultilineText)]
    public string Message { get; set; }
    
    /// <summary>
    /// Gets or sets a value indicating whether the submitter attests their message is not spam.
    /// </summary>
    [Required]
    public bool NotSpam { get; set; }
}