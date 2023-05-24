using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApp.Models.Contexts;
using WebApp.Models.Entities;
using WebApp.Models.ViewModels;
namespace WebApp.Models.Services;

public class AuthServive
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IdentityContext _identityContext;

    public AuthServive(UserManager<IdentityUser> userManager, IdentityContext identityContext)
    {
        _userManager = userManager;
        _identityContext = identityContext;
    }

    public async Task<bool> RegAsync(UserRegisterViewModel model)
    {
        try
        {
            IdentityUser identityUser = model;
            await _userManager.CreateAsync(identityUser, model.Password);

            UserProfileEntity userProfileEntity = model;
            userProfileEntity.UserId = identityUser.Id;
           

            _identityContext.UserProfiles.Add(userProfileEntity);
            await _identityContext.SaveChangesAsync();
            return true;
        }
        catch { return false; }
    }



}

