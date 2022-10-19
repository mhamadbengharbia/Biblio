#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class UserBook
{
    [Key]
    public int UserBookId { get; set; }
    [Required(ErrorMessage = "Serial Number is Required")]
    public int SerialNumber { get; set; }
    [Required(ErrorMessage = "Status is Required")]
    public String Status { get; set; }
    [Required(ErrorMessage = "Description is Required")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Picture is Required")]
    public string Picture { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}
