using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMBook.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public string Accout_id { get; set; } 
        public string Name { get; set; }
        public string? Password { get; set; }
        public string? Username { get; set; }
        public String Email { get; set; }
        public String? VerificationToken { get; set; }
        public String? ResetToken {  get; set; } 
        public DateTime? ResetTokenExpire { get; set; }

        public  ICollection<Book> Books { get; set; }

        public ICollection<RefeshTokens> RefeshTokens { get; set; }
    }
}
