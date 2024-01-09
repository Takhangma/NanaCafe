using System.ComponentModel.DataAnnotations;
namespace FinalCoffee1.Common.model;
public class UserModel:BaseModel
{
    public UserType? userType { get; set; }

    [StringLength(20, MinimumLength = 4, ErrorMessage = "UserName must be at least 4 characters long")]
    public string? Username { get; set; }

    [StringLength(20, MinimumLength = 5, ErrorMessage = "Password must be at least 5 characters long")]
    public string? Password { get; set; }

    [EmailAddress(ErrorMessage ="Invalid Email Address")]
    public string? Email{ get; set; }

    public DateTime? DiscountValidUntil { get; set; }
}