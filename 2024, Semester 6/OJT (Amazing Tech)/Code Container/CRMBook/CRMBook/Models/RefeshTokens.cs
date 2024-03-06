using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMBook.Models
{
    public class RefeshTokens
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string Refresh_Accout_id { get; set; }
        public String? Token { get; set; }
        public DateTime Expires { get; set; }
        public bool IsActive { get; set; }

        public User User { get; set; }
    
    }
}
