using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class AccountService
    {
        public Account? CheckLogin(string email, string password)
        {
            AccountRepository repo = new AccountRepository();

            Account account = repo.Get(email);

            return account != null && account.Password == password ? account : null;
        } 

    }
}
