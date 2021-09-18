using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaveEvansTech.Models
{
    [Table(name: "Feedback")]
    public class FeedbackModel
    {
        [Key]
        public int FeedbackID { get; set; }

        public Guid Guid { get; set; }

        public int Rating { get; set; }
        
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Company/Organization is required.")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string Company { get; set; }
        
        [Required(ErrorMessage = "Title is required.")]
        [StringLength(128, ErrorMessage = "Max character length is 128.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Message is required.")]
        [StringLength(1000, ErrorMessage = "Max character length is 1,000.")]
        public string Message { get; set; }

        public bool PermissionForPromoUse { get; set; }

        public string ImageFileName { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        [ForeignKey("ClientModel")]
        public int? ClientID { get; set; }

        public ClientModel Client { get; set; }
    }
}