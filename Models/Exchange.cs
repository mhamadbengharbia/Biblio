#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class Exchange
{
    [Key]
    public int ExchangeId { get; set; }
 
    [Required(ErrorMessage = "Start Date is Required")]

    public DateTime StartDate { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "End Date is Required")]

    public DateTime EndDate { get; set; } = DateTime.Now;


}
