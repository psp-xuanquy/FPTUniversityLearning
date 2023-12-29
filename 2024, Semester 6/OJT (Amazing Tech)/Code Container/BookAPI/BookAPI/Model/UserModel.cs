using BookAPI.Enum;

namespace BookAPI.Model
{
    public class UserModel
    {
        public string MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Balance { get; set; }
        public int TotalProduct { get; set; }
    }
}
