using Microsoft.AspNetCore.Identity;
using WebApp.Models.Entities;

namespace WebApp.Models.Identity;

public class AppUser : IdentityUser
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public ICollection<UserAddressEntity> Addresses { get; set; } = new HashSet<UserAddressEntity>();
}
