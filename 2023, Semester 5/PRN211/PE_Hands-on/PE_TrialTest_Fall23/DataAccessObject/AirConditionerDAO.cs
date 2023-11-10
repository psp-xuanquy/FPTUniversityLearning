using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class AirConditionerDAO
    {
        // Using Singleton Pattern
        private static AirConditionerDAO instance = null;
        private static readonly object objLock = new object();

        private AirConditionerDAO() { }

        public static AirConditionerDAO Instance
        {
            get
            {
                lock (objLock)
                {
                    if (instance == null)
                    {
                        instance = new AirConditionerDAO();
                    }
                    return instance;
                }
            }
        }

        public List<AirConditioner> GetAirConditioners()
        {
            using var db = new AirConditionerShop2023DBContext();
            return db.AirConditioners.Include(f => f.Supplier).ToList();
        }

        public AirConditioner GetAirConditionerByID(int id)
        {
            var temp = GetAirConditioners().SingleOrDefault(m => m.AirConditionerID == id);
            return temp;
        }

        public List<SupplierCompany> GetSupplierCompanies()
        {
            using var db = new AirConditionerShop2023DBContext();
            return db.SupplierCompanies.ToList();
        }

        public void Save(AirConditioner a)
        {
            using var db = new AirConditionerShop2023DBContext();
            db.AirConditioners.Add(a);
            db.SaveChanges();
        }

        public void Update(AirConditioner a)
        {
            using var db = new AirConditionerShop2023DBContext();
            db.AirConditioners.Update(a);
            db.SaveChanges();
        }

        public void Delete(AirConditioner a)
        {
            using var db = new AirConditionerShop2023DBContext();
            var a1 = db.AirConditioners.SingleOrDefault(m => m.AirConditionerID == a.AirConditionerID);
            db.AirConditioners.Remove(a1);
            db.SaveChanges();
        }
    }
}
       