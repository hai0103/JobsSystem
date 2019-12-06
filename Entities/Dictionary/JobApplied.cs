namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobApplied")]
    public partial class JobApplied
    {
        [Key]
        [Column(Order = 0)]
        public Guid CandidateID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid PostID { get; set; }
    }
}
