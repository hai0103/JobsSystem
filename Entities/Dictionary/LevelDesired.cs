namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LevelDesired")]
    public partial class LevelDesired
    {
        public Guid LevelDesiredID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
