using Giaolang.FAP.V2.Repositories;
using System.Runtime.Serialization;

namespace Giaolang.FAP.V2.Business
{
    public class UserAccountService
    {

        //xài CSDL ở tầng DAL
        private IUserAccountRepository _repo = new UserAccountRepositoryMySQL();
        //UI nhìn: em đưa anh username/pass, anh cho em biết nó đúng ko
        public bool CheckLogin(string username, string password)
        {
            UserAccount userAccount = _repo.Search(username);
            if (userAccount != null)
                if (userAccount.Password == password)
                    return true;

            return false;
        }
    }
}