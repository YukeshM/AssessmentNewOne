namespace Feedback.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        public int FeedbackId { get; set; }

        public int SatisfactoryId { get; set; }

        [Required]
        [StringLength(250)]
        public string Reason { get; set; }

        public byte[] FeedbackFile { get; set; }

        public virtual Satisfactory Satisfactory { get; set; }
    }
}
