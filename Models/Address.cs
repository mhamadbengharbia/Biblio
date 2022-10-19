#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BiblioApp.Models;

public class Address
{
    [Key]
    public int AddressId { get; set; }
    [Required(ErrorMessage = "Country is Required")]
    public string Country { get; set; }
    [Required(ErrorMessage = "State is Required")]
    public String State { get; set; }
    [Required(ErrorMessage = "ZipCode is Required")]
    [Range(1000, 9999, ErrorMessage = "ZipCode is not valid")]
    public int ZipCode { get; set; }
    [Required(ErrorMessage = "Street is Required")]
    public string Street { get; set; }
    [Required(ErrorMessage = "House Number is Required")]
    public int HouseNumber { get; set; }


}
