using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace BSDAO
{
    public class AccountDAO
    {
        private static AccountDAO instance = null;

        public AccountDAO()
        {
        }
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
        }
        public TbAccount GetAccountByUsername(string username)
        {
            try
            {

                var db = new BirdFarmShopContext();
                return db.TbAccounts.SingleOrDefault(m => m.Username.Equals(username));

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public List<TbAccount> GetAllAccounts()
        {
            try
            {
                var db = new BirdFarmShopContext();
                return db.TbAccounts.Include(a => a.User).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void RegistraionAccount(TbUser user)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                List<TbAccount> accountList = GetAllAccounts();

                foreach (var existingAccount in accountList)
                {
                    if (existingAccount.Username == user.TbAccount.Username)
                    {
                        throw new Exception("Id or Username is duplicated");
                    }
                }

                dbContext.TbUsers.Add(user);
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Error creating user: " + ex.Message);
            }
        }

        public void DeleteAccount(string id)
        {
            var dbContext = new BirdFarmShopContext();
            var user = GetAccountById(id);
            dbContext.TbAccounts.Remove(user.TbAccount);
            dbContext.TbUsers.Remove(user);
            dbContext.SaveChanges();
        }

        public TbUser GetAccountById(string id)
        {
            var dbContext = new BirdFarmShopContext();
            return dbContext.TbUsers.Include(a => a.TbAccount).FirstOrDefault(a => a.UserId == id);
        }

        public List<TbAccount> GetAccountByFullName(string fullName)
        {
            try
            {
                var db = new BirdFarmShopContext();
                if (fullName == null)
                {
                    return GetAllAccounts();
                }
                return db.TbAccounts.Include(u => u.User).Where(m => m.User.FullName.ToLower().Contains(fullName.ToLower())).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }

        public void UpdateAccount(TbUser user)
        {
            var dbContext = new BirdFarmShopContext();
            dbContext.TbUsers.Update(user);
            dbContext.SaveChanges();
        }
    }
}