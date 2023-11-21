using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.FAP.V2.Repositories
{
    public class UserAccountRepositoryMySQL : IUserAccountRepository
    {

        private List<UserAccount> _users = new List<UserAccount>()
        {
            new UserAccount() {UserName = "hoang", Password = "ngoctrinh"},
            new UserAccount() {UserName = "jack", Password = "5to?i"}
        };
        public UserAccount Search(string username)
        {
            return _users.SingleOrDefault(x => x.UserName == username);
        }
    }
}
