using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreEF.Data.Models
{
    public class Example
    {
        [Key]
        public int BrandId { get; set; }
        [Column("Brand")]
        public string BrandName { get; set; }
        public bool CMSActive { get; set; }
        public string ADGroup { get; set; }
    }
}
