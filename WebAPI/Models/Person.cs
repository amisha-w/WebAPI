namespace WebAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Person")]
    public partial class Person
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string username { get; set; }

        
        [Column(Order = 1)]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(100)]
        public string address { get; set; }

        [StringLength(25)]
        public string name { get; set; }

        [StringLength(25)]
        public string lname { get; set; }

        [StringLength(20)]
        public string Role { get; set; }
    }
}
