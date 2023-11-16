using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ManufacturerRepository
    {
        public List<Manufacturer> GetAll()
        {
            return new Sunglasses2023DbContext().Manufacturers.ToList();
        }
    }
}
