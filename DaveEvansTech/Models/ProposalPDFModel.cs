using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DaveEvansTech.Models
{
    [Table(name: "ProposalPDFs")]
    public class ProposalPDFModel
    {
        [Key]
        public string ProposalPdfID { get; set; }

        public string PdfFileName { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("ClientModel")]
        public int ClientID { get; set; }

        public ClientModel Client { get; set; }

        [ForeignKey("ProjectModel")]
        public int? ProjectID { get; set; }

        public ProjectModel Project { get; set; }
    }
}