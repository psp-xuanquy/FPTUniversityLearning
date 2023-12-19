using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public interface IAccountRepository
    {
        TbAccount GetAccountByUsername(string username);
        List<TbAccount> GetAllAccounts();
        void RegistraionAccount(TbUser user);
        TbUser GetAccountById(string id);
        public void DeleteAccount(string id);
        public List<TbAccount> GetAccountByFullName(string fullName);
        public void UpdateAccount(TbUser user);
    }
}
