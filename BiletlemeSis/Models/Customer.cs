namespace BiletlemeSis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        //[ExplicitKey]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string TelephoneNumber { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(50)]
        public string Male { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }
    }
}
