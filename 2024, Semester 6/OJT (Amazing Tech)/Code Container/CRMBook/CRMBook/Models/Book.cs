using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMBook.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int Book_id { get; set; }
        public string? Name { get; set; }
        public string? Author { get; set; }
        public string Description { get; set; } = null!;
        public string? Category { get; set; }
        public decimal? Price { get; set; }

        [ForeignKey("User")]
        public string Book_Accout_id { get; set; }

        public  User User { get ; set; }  
    }
}
