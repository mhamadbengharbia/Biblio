#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class Like
{
    [Key]
    public int LikeID { get; set; }
    [DefaultValue(0)]
    public int Value { get; set; }


}
