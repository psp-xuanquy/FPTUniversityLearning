using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAirConditionerRepository
    {
        List<AirConditioner> GetAirConditioners();
        List<SupplierCompany> GetSupplierCompanies();
        AirConditioner GetAirConditionerByID(int id);
        void Delete(AirConditioner airConditioner);
        void Update(AirConditioner airConditioner);
        void Save(AirConditioner airConditioner);   
    }
}
