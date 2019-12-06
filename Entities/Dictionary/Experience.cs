namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Experience")]
    public partial class Experience
    {
        [Key]
        public Guid ExpID { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        [StringLength(100)]
        public string Position { get; set; }

        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public Guid? CandidateID { get; set; }
    }
}
