using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class StaffMemberRepository : IStaffMemberRepository
    {
        public StaffMember CheckLogin(string username, string password) => StaffMemberDAO.Instance.CheckLogin(username, password);
    }
}
