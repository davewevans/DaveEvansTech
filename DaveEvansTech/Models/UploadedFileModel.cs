using System;
using System.ComponentModel.DataAnnotations;

namespace DaveEvansTech.Models
{
    public class UploadedFileModel
    {
        [Key]
        public int UploadedFileID { get; set; }

        public Guid Guid { get; set; }

        public string OriginalFileName { get; set; }

        public string BlobFileName { get; set; }

        public string ContentType { get; set; }

        public long Length { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}