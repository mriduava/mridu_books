using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MriduBooks.Models
{
    public class User: IdentityUser
    {
        //internal int id;

        //[Key]
        //public int Id { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        //[Required]
        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name ="Confirm password")]
        //[Compare("Password",
        //    ErrorMessage="Password doesn't match!")]
        //public string ConfirmPassword { get; set; }
    }
}
