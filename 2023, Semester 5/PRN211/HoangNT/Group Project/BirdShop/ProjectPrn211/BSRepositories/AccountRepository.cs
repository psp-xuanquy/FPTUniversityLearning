using BSDAO;
using BusinessObject;
using BusinessObject.Models;

namespace BSRepositories
{
    public class AccountRepository : IAccountRepository
    {
        public void DeleteAccount(string id) => AccountDAO.Instance.DeleteAccount(id);

        public List<TbAccount> GetAccountByFullName(string fullName) => AccountDAO.Instance.GetAccountByFullName(fullName);

        public TbUser GetAccountById(string id) => AccountDAO.Instance.GetAccountById(id);

        public TbAccount GetAccountByUsername(string username) => AccountDAO.Instance.GetAccountByUsername(username);

        public List<TbAccount> GetAllAccounts() => AccountDAO.Instance.GetAllAccounts();

        public void RegistraionAccount(TbUser user) => AccountDAO.Instance.RegistraionAccount(user);

        public void UpdateAccount(TbUser user) => AccountDAO.Instance.UpdateAccount(user);

    }
}