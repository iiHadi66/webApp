﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebApp.Models.Entities;


namespace WebApp.Models.ViewModels
{
    public class UserRegisterViewModel
    {

        [Display(Name = "First Name *")]
        [Required(ErrorMessage = "Your must provide a first name")]
        public string FristName { get; set; } = null!;

        [Display(Name = "Laste Name *")]
        [Required(ErrorMessage = "Your must provide a laste name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "Street Name *")]
        [Required(ErrorMessage = "Your must provide a street name")]
        public string StreetName { get; set; } = null!;

        [Display(Name = "Postal Code *")]
        [Required(ErrorMessage = "Your must provide a postal code")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City *")]
        [Required(ErrorMessage = "Your must provide a city name")]
        public string City { get; set; } = null!;

        [Display(Name = "Mobile (optional)")]
        public string? Mobile { get; set; }

        [Display(Name = "Company (optional)")]
        public string? Company { get; set; }

        [Display(Name = "E-mail *")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Your must provide an e-mail address")]
       
        public string Email { get; set; } = null!;

        [Display(Name = "Password *")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Your must provide a password")]
        
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password *")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        [Required(ErrorMessage = "Your must confirm your password")]
        public string ConfirmPassword { get; set; } = null!;

        [Display(Name = "Upload Profile Image (optional)")]
        [DataType(DataType.Upload)]
        public IFormFile? ImageFile { get; set; }

        [Display(Name = "I have red and accepts the terms and conditions")]
        [Required(ErrorMessage = "Your must agree to the terms and conditions")]
        public bool TermsAndConditions { get; set; } = false;



        public static implicit operator IdentityUser(UserRegisterViewModel model)
        {
            return new IdentityUser
            {
                UserName = model.Email,
                Email = model.Email,
                PhoneNumber = model.Mobile,
            };
        }

        public static implicit operator UserProfileEntity(UserRegisterViewModel model)
        {
            return new UserProfileEntity
            {
              FirstName = model.FristName,
              LastName = model.LastName,
              StreetName = model.StreetName,
              PostalCode = model.PostalCode,
              City = model.City,
            };
        }




    }
}
