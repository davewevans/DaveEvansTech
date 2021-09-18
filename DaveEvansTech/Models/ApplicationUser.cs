using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace DaveEvansTech.Models
{
    public class ApplicationUser : IdentityUser
    {
        [DisplayName("First Name")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string LastName { get; set; }

        public ClientModel Client { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}