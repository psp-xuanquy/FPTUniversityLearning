using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class StaffMemberDAO
    {
        // Using Singleton Pattern
        private static StaffMemberDAO instance = null;
        private static object lockObject = new object();

        private StaffMemberDAO() { }

        public static StaffMemberDAO Instance
        {
            get
            {
                    if (instance == null)
                    {
                        instance = new StaffMemberDAO();
                    }
                    return instance;
            }
        }

        public StaffMember CheckLogin(string email, string password)
        {
            using var db = new AirConditionerShop2023DBContext();
            return db.StaffMembers.SingleOrDefault(m => m.EmailAddress.Equals(email) &&
                                                        m.Password.Equals(password));
        }
    }
}
