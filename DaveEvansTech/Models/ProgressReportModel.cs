using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaveEvansTech.Models
{
    [Table(name: "ProgressReports")]
    public class ProgressReportModel
    {
        [Key]
        public int ProgressReportID { get; set; }

        public string Report { get; set; }

        public DateTime CreatedAt { get; set; }
        
        [ForeignKey("ClientModel")]
        public int ClientID { get; set; }

        public ClientModel Client { get; set; }

        [ForeignKey("ProjectModel")]
        public int? ProjectID { get; set; }

        public ProjectModel Project { get; set; }
    }
}