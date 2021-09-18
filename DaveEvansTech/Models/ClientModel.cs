using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaveEvansTech.Models
{
    [Table(name: "Clients")]
    public class ClientModel
    {
        [Key]
        public int ClientID { get; set; }

        [StringLength(128, ErrorMessage = "Max character limit is 128.")]
        public string CompanyName { get; set; } = "";

        [StringLength(128, ErrorMessage = "Max character limit is 128.")]
        public string CompanyWebsite { get; set; }

        public DateTime CreatedAt { get; set; }
        
        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }

        //public ApplicationUser ApplicationUser { get; set; }

        public List<BriefModel> Briefs { get; set; }

        public List<ProjectModel> Projects { get; set; }

        public List<FeedbackModel> Feedbacks { get; set; }

        public List<ProposalPDFModel> PdfProposals { get; set; }
    }
}