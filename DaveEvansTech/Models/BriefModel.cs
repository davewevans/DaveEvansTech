using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DaveEvansTech.Enums;

namespace DaveEvansTech.Models
{
    [Table(name: "Briefs")]
    public class BriefModel
    {
        [Key]
        public int BriefID { get; set; }

        public Guid Guid { get; set; } = Guid.NewGuid();

        public ProjectType ProjectType { get; set; }

        public string AppType { get; set; }

        public bool IsComplete { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [StringLength(100, ErrorMessage = "Max character length is 100.")]
        public string FirstName { get; set; } = "";

        [StringLength(100, ErrorMessage = "Max character length is 100.")]
        public string LastName { get; set; } = "";

        [StringLength(100, ErrorMessage = "Max character length is 100.")]
        public string CompanyName { get; set; } = "";

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string ProjectSummary { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string AboutCompany { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string TargetAudience { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string Goals { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string Competitors { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string LookAndFeel { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string Features { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string InHouseRequirements { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string Content { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string Hosting { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string OnGoingSupport { get; set; } = "";

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string OnlineMarketing { get; set; } = "";
        
        public DateTime? Deadline { get; set; }

        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string MeasuringSuccess { get; set; } = "";

        [StringLength(10, ErrorMessage = "Max character length is 10.")]
        public string BudgetMinimum { get; set; } = "";
        
        [StringLength(10, ErrorMessage = "Max character length is 10.")]
        public string BudgetMaximum { get; set; } = "";
        
        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string TargetPlatforms { get; set; } = "";
        
        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string DatabaseIntegration { get; set; } = "";
        
        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string BackendDevelopment { get; set; } = "";
        
        [StringLength(10000, ErrorMessage = "Max character length is 10,000.")]
        public string LogoDesign { get; set; } = "";
        
        public DateTime CreatedAt { get; set; }

        [ForeignKey("ClientModel")]
        public int ClientID { get; set; }

        public ClientModel Client { get; set; } = new();
    }
}