namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        public Guid PostID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Requirement { get; set; }

        [StringLength(500)]
        public string Benefit { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expire { get; set; }

        public Guid? EmployerID { get; set; }

        public Guid? JobCategoryID { get; set; }

        public Guid? FieldID { get; set; }
    }
}
