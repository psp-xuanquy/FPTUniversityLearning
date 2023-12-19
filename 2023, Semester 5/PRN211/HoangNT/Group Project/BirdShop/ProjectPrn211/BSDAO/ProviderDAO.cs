using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDAO
{
    public class ProviderDAO
    {
        private static ProviderDAO instance = null;

        public ProviderDAO()
        {
        }
        public static ProviderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProviderDAO();
                }
                return instance;
            }
        }

        public List<TbProvider> GetProviders()
        {
            var db = new BirdFarmShopContext();
            return db.TbProviders.ToList();
        }
    }
}
