using Microsoft.AspNetCore.Identity;
//this is the using statement reqired to make users
using System.ComponentModel.DataAnnotations;

public class AppUser : IdentityUser
{

}
// this method is adds the create users class to the app users model
public class CreateUser
{
  [Required]
  public string Name { get; set; }
  [Required]
  public string Email { get; set; }
  [Required]
  public string Password { get; set; }
}