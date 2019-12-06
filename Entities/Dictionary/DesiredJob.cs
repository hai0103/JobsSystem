namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DesiredJob")]
    public partial class DesiredJob
    {
        public Guid DesiredJobID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public Guid? LevelDesiredID { get; set; }

        public decimal? Salary { get; set; }

        public Guid? FieldID { get; set; }

        public Guid? JobCategoryID { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        public Guid? CandidateID { get; set; }
    }
}
