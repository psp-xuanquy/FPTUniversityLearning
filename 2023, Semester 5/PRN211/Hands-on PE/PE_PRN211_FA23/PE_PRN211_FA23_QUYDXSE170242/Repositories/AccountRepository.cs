using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository
    {
        public Account? Get(string email)
        {
            Sunglasses2023DbContext db = new Sunglasses2023DbContext();
            return db.Accounts.FirstOrDefault(x => x.MemberEmail == email);             
        }

    }
}
