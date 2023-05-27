using WebApp.Models.Contexts;
using WebApp.Models.Entities;

namespace WebApp.Helpers.Repos;

public class UserAddressRepo : Repository<UserAddressEntity>
{
    public UserAddressRepo(IdentityContext context) : base(context)
    {
    }
}
