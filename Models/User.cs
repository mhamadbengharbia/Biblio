#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BiblioApp.Models;
public class User
{
    [Key]
    public int UserId { get; set; }
    [Required(ErrorMessage = "FirstName is Required")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "LastName is Required")]
    public string LastName { get; set; }
    [Required(ErrorMessage = "Email is Required ")]
    [EmailAddress]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is very Reaquired ")]
    [MinLength(8, ErrorMessage = "Password must be more than 8 characters ")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [NotMapped]
    [Required(ErrorMessage = "Confirm Password is Required ")]
    [Compare("Password", ErrorMessage = "Password Don't match ")]
    [DataType(DataType.Password)]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Phone Number is Required")]
    public string PhoneNumber { get; set; }

    [DefaultValue(0)]
    public int Score { get; set; }

    [Required(ErrorMessage = "CIN is Required")]
    [Range(10000000,999999999,ErrorMessage ="Please insert a valid Cart Number")]
    public int Cin { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
 

}