using BusinessObject;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        //Singleton
        private static MemberDAO instance;
        private static readonly object lockObject = new object();
        private List<Member> members;

        //New List ở constructor
        private MemberDAO()
        {
            members = new List<Member>();
        }

        public static MemberDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                }
                return instance;
            }
        }
      

        public IEnumerable<Member> GetMembers()
        {
            using var dbContext = new FStoreContext();
            return dbContext.Members.ToList();
        }
        public Member GetMemberByID(int memberId)
        {
            using var dbContext = new FStoreContext();
            return dbContext.Members.SingleOrDefault(member => member.MemberId == memberId);
        }
        public void InsertMember(Member member)
        {
            using (var dbContext = new FStoreContext())
            {
                dbContext.Members.Add(member);
                dbContext.SaveChanges();
            }
        }
        public void DeleteMember(int memberId)
        {
            using(var dbContext = new FStoreContext())
            {
                Member deletedMember = dbContext.Members.SingleOrDefault(m => m.MemberId == memberId);
                if(deletedMember != null)
                {
                    dbContext.Members.Remove(deletedMember);
                    dbContext.SaveChanges();
                }
            }
        }   
        public void UpdateMember(Member member)
        {
            using( var dbContext = new FStoreContext())
            {
                dbContext.Update(member);
            }
        }


    }
}
