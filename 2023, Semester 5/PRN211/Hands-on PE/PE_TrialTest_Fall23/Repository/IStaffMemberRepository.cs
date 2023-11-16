using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStaffMemberRepository
    {
        StaffMember CheckLogin(string username, string password);
    }
}
