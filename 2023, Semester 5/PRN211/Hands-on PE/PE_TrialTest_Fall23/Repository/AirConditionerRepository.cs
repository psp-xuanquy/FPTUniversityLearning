using BusinessObject;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AirConditionerRepository : IAirConditionerRepository
    {  
        public List<AirConditioner> GetAirConditioners() => AirConditionerDAO.Instance.GetAirConditioners();
        public List<SupplierCompany> GetSupplierCompanies() => AirConditionerDAO.Instance.GetSupplierCompanies();
        public AirConditioner GetAirConditionerByID(int id) => AirConditionerDAO.Instance.GetAirConditionerByID(id);
        public void Delete(AirConditioner airConditioner) => AirConditionerDAO.Instance.Delete(airConditioner);
        public void Update(AirConditioner airConditioner) => AirConditionerDAO.Instance.Update(airConditioner);
        public void Save(AirConditioner airConditioner) => AirConditionerDAO.Instance.Save(airConditioner);
    }
}
