using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DaveEvansTech.Enums;

namespace DaveEvansTech.Models
{
    [Table(name: "Projects")]
    public class ProjectModel
    {
        [Key]
        public int ProjectID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ProjectStatus Status { get; set; }
        
        public DateTime CreatedAt { get; set; }

        [ForeignKey("BriefModel")]
        public int BriefID { get; set; }

        public BriefModel Brief { get; set; }

        [ForeignKey("ClientModel")]
        public int? ClientID { get; set; }

        public ClientModel Client { get; set; }

        public List<ProgressReportModel> ProgressReports { get; set; }
        public ProposalPDFModel ProposalPDF { get; set; }
    }
}