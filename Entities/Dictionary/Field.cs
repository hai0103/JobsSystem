namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Field")]
    public partial class Field
    {
        public Guid FieldID { get; set; }

        [StringLength(100)]
        public string FieldName { get; set; }
    }
}
