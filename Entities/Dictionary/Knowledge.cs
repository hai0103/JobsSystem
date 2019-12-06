namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Knowledge")]
    public partial class Knowledge
    {
        public Guid KnowledgeID { get; set; }

        [StringLength(100)]
        public string College { get; set; }

        public bool? Graduated { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public Guid? CandidateID { get; set; }
    }
}
