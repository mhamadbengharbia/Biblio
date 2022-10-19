#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BiblioApp.Models;

public class Banned
{
    [Key]
    public int BannedId { get; set; }
    [Required(ErrorMessage = "Status is Required")]
    public int Status { get; set; }
    [Required(ErrorMessage = "Start date is Required")]
    public DateTime StartDate { get; set; }
    [Required(ErrorMessage = "End date is Required")]
    public DateTime EndDate { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;






    /*   public ValidationResult FutureDate()
       {

           return DateTime.Compare(StartDate, DateTime.Today) < 0 ? new ValidationResult("Date cannot be in the Past") : ValidationResult.Success
           || DateTime.Compare(StartDate, EndDate) > 0 ? new ValidationResult("Date cannot be in the Past") : ValidationResult.Success;
       }*/











}
