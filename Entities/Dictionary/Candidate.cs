namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Candidate")]
    public partial class Candidate
    {
        public Guid CandidateID { get; set; }

        [StringLength(100)]
        public string CandidateEmail { get; set; }

        [StringLength(50)]
        public string CandidatePassword { get; set; }

        [StringLength(100)]
        public string CandidateName { get; set; }

        [StringLength(10)]
        public string CandidatePhone { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        public bool? Gender { get; set; }

        [StringLength(500)]
        public string CandidateImage { get; set; }

        [StringLength(500)]
        public string CandidateAddress { get; set; }

        [StringLength(100)]
        public string Nationality { get; set; }

        [StringLength(500)]
        public string Target { get; set; }

        public int? YoExp { get; set; }

        [StringLength(100)]
        public string LevelCurrent { get; set; }

        [StringLength(100)]
        public string Degree { get; set; }

        [StringLength(100)]
        public string Language { get; set; }
    }
}
