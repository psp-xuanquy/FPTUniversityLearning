using Repositories.Models;
using System.Collections.Generic;

namespace Repositories
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetByID(int Id);
        void InsertMember(Member mem);
        void UpdateMember(Member mem);
        void DeleteMember(int Id);
    }
}
