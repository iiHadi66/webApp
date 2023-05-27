using WebApp.Helpers.Repos;
using WebApp.Models.Entities;
using WebApp.Models.Identity;

namespace WebApp.Helpers.Services;

public class AddressService
{
    private readonly AddressRepository _addressRepo;
    private readonly UserAddressRepo _userAddressRepo;
    public AddressService(AddressRepository addressRepo, UserAddressRepo userAddressRepo)
    {
        _addressRepo = addressRepo;
        _userAddressRepo = userAddressRepo;

    }
    public async Task<AddressEntity> GetOrCreateAsync(AddressEntity addressEntity)
    {
        var entity = await _addressRepo.GetAsync(x =>
        x.StreetName == addressEntity.StreetName &&
        x.PostalCode == addressEntity.PostalCode &&
        x.City == addressEntity.City
        );

        entity ??= await _addressRepo.AddAsync(addressEntity);
        return entity!;

    }
    public async Task AddAddressAsync(AppUser user, AddressEntity addressEntity)
    {
        await _userAddressRepo.AddAsync(new UserAddressEntity
        {
            UserId = user.Id,
            AddressId = addressEntity.Id,
        });
    }
}
