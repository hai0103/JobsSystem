namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employer")]
    public partial class Employer
    {
        public Guid EmployerID { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(100)]
        public string EmployerEmail { get; set; }

        [StringLength(50)]
        public string EmployerPassword { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public Guid? FieldID { get; set; }

        [StringLength(100)]
        public string Website { get; set; }

        public int? Rating { get; set; }

        [StringLength(500)]
        public string Logo { get; set; }
    }
}
