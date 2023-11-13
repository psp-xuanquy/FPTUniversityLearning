using Repositories;
using Repositories.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class MemberDAO
    {
        MemberRepository repository;
        public MemberDAO()
        {
            repository = new MemberRepository();
        }
        public List<Member> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(Member obj)
        {
            repository.Create(obj);
        }
        public void Update(Member obj)
        {
            repository.Update(obj);
        }
        public void Delete(Member obj)
        {
            repository.Delete(obj);
        }
    }
}
