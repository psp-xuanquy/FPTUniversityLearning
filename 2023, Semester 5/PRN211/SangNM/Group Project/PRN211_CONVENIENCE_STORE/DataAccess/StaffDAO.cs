using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    class StaffDAO
    {
        //// THIS IS SINGLETON PATTERN ////

        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();
        private StaffDAO() { }
        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }

        // THIS IS GET ALL STAFF

        public List<TblStaff> GetAll()
        {
            List<TblStaff> staffs = new List<TblStaff>();
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    staffs = ctx.TblStaffs.ToList();
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffs;
        }

        // THIS IS GET STAFF BY ID

        public TblStaff GetByID(string staffId)
        {
            TblStaff staff = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    staff = ctx.TblStaffs.SingleOrDefault(staff => staff.StaffId.Equals(staffId));
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }

        // THIS IS GET STAFF BY NAME

        public TblStaff GetByName(string staffName)
        {
            TblStaff staff = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    staff = ctx.TblStaffs.SingleOrDefault(staff => staff.FullName.Equals(staffName));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staff;
        }


        // THIS IS ADD NEW STAFF

        public void Add(TblStaff staff)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.TblStaffs.Add(staff);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // THIS IS UPDATE STAFF

        public void Update(TblStaff staff)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.Entry(staff).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex) { 
                throw new Exception(ex.Message); 
            }
        }

        // THIS IS GET CURRENT LOGIN ACCOUNT

        private TblStaff CurrentAccount { get; set; }
        public TblStaff GetCurrentAccount() => CurrentAccount;

        public TblStaff Login(string Email, string Password) 
        { 
            try
            {
                TblStaff staff = null;
                using (var ctx = new prn211group4Context())
                {
                    staff = ctx.TblStaffs.SingleOrDefault(staff => staff.Email.Equals(Email) && staff.Password.Equals(Password) && staff.StatusId.Equals("Active"));
                }

                if (staff != null)
                {
                    CurrentAccount = staff;
                } else
                {
                    CurrentAccount = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return CurrentAccount;
        }

        // THIS IS SEARCH STAFF BY ID AND NAME

        public List<TblStaff> SearchByIdAndName(string StaffId, string Fullname)
        {
            try
            {
                List<TblStaff> staffs = null;
                using (var ctx = new prn211group4Context())
                {
                    staffs = ctx.TblStaffs.Where(staff => staff.StaffId.Equals(StaffId) && staff.FullName.Contains(Fullname)).ToList<TblStaff>();
                }
                if(staffs != null)
                {
                    return staffs;
                }
            } catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return null;
        }

        // THIS IS EARCH BY NAME

        public List<TblStaff> SearchByName(string name)
        {
            List< TblStaff> staffs = null;
            try
            {
                using(var ctx = new prn211group4Context())
                {
                    staffs = ctx.TblStaffs.Where(staff => staff.FullName.Contains(name)).ToList<TblStaff>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return staffs;
        }
    }
}
