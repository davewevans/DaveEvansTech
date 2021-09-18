using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaveEvansTech.Models
{
    [Table(name: "Contacts")]
    public class ContactModel
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage = "A name is required.")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string FirstName { get; set; }

        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "An email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        [StringLength(1000, ErrorMessage = "Max character length is 1,000.")]
        public string Body { get; set; }
        
        public DateTime CreatedAt { get; set; }
    }
}