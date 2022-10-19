#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class Collection
{
    [Key]
    public int CollectionID { get; set; }
    [Required(ErrorMessage = "Description is Required")]
    public string Description { get; set; }
    [Required(ErrorMessage = "Title is Required")]
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;


}
