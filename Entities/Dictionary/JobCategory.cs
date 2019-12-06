namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobCategory")]
    public partial class JobCategory
    {
        public Guid JobCategoryID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Guid? FieldID { get; set; }
    }
}
