using BSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public class ProviderRepository : IProviderRepositories
    {
        public List<TbProvider> GetProviders() => ProviderDAO.Instance.GetProviders();

    }
}
