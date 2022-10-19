#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class Comment
{
    [Key]
    public int CommentId { get; set; }
    [Required(ErrorMessage = "Content is Required")]
    public string Content { get; set; }



    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;














}
