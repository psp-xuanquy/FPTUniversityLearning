using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserAccountRepository
    {
        private BookManagementDbContext _context;
        //xài đâu new đấy

        //tạm thời hok có select tất cả user như bên Category
        //CategoryRepo select hết để đổ vào combo, dropdown
        //BookRepo select hết để đổ vào grid

        //Ở đây ta select đúng cái row thoả email và pass hoặc là ko thấy
        public UserAccount? GetAccount(string email, string password)
        {
            _context = new();
            //_context.UserAccounts.  .Where(đưa vào hàm Lambda nhận vào 1 Acc trả về true/false) -> trả về list user thoả điều kiện nào đó
            //                        .Select(đưa vào Lambda trả về) list Acc
            //                        .FirstOrDefault(Lambda) trả về 1 dòng
            //                        hoặc null ko tìm thấy theo tiêu chí Lamda

            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x)
            //{
            //    if (x.Email == email && x.Password == password)
            //        return true;
            //    return false;
            //});

            //return _context.UserAccounts.FirstOrDefault(delegate (UserAccount x)
            //{
            //    return x.Email == email && x.Password == password;                   
            //});

            return _context.UserAccounts.FirstOrDefault(x => x.Email == email && x.Password == password);

        }
    }
}
