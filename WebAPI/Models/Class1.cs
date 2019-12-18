using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace WebAPI.Models
{
    public class Class1
    {

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string username { get; set; }


        [Column(Order = 1)]
        [StringLength(50)]
        public string password { get; set; }
    }
}