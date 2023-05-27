using WebApp.Models.Entities;
using WebApp.Models.Contexts;

namespace WebApp.Helpers.Repos;

public class AddressRepository : Repository<AddressEntity>
{
    public AddressRepository(IdentityContext context) : base(context)
    {
    }
}