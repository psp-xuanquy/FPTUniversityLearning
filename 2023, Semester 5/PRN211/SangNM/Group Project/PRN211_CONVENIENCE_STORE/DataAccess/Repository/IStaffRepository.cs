using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IStaffRepository
    {
        List<TblStaff> GetAllStaff();

        TblStaff GetStaffByID(string staffId);

        void Add(TblStaff staff);
        
        void Update(TblStaff staff);

        TblStaff Login(string Email, string Password);

        TblStaff GetCurrentAccount();

        TblStaff GetByName(string staffName);

        public List<TblStaff> SearchByIdAndName(string StaffId, string Fullname);

        public List<TblStaff> SearchByName(string name);
    }
}
