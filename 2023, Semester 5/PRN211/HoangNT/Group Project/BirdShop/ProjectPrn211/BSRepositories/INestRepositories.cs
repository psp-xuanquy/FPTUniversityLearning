using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public interface INestRepositories
    {
        List<TbNest> GetAllNests();
        List<TbNest> GetAllNestsAvailable();
        public List<TbNest> GetAllNestsByCategories(string species);
        bool AddNest(TbNest newNest);
        bool UpdateNest(TbNest updatedNest);
        bool DeleteNest(string nestId);
        List<TbNest> SearchNestsByCriteria(string nestName, decimal maxPrice);

        public TbNest GetNestById(string id);
    }
}
