using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSDAO
{
    public class NestDAO
    {
        private static NestDAO instance = null;

        public NestDAO()
        {
        }

        public static NestDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NestDAO();
                }
                return instance;
            }
        }

        public List<TbNest> GetAllNests()
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                return dbContext.TbNests.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting nests: " + ex.Message);
            }
        }

        public List<TbNest> GetAllNestsByCategories(string species)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                return dbContext.TbNests
                    .Where(n => n.Status == false && n.BirdSpecies == species)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting nests: " + ex.Message);
            }
        }

        public List<TbNest> GetAllNestsAvailable()
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                return dbContext.TbNests
                    .Where(n => n.Status == false)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting nests: " + ex.Message);
            }
        }

        public bool AddNest(TbNest newNest)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                dbContext.TbNests.Add(newNest);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding nest: " + ex.Message);
            }
        }

        public bool UpdateNest(TbNest updatedNest)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                dbContext.TbNests.Update(updatedNest);
                dbContext.SaveChanges();
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating nest: " + ex.Message);
            }
        }

        public bool DeleteNest(string nestId)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                var nestToDelete = dbContext.TbNests.Find(nestId);
                if (nestToDelete != null)
                {
                    dbContext.TbNests.Remove(nestToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting nest: " + ex.Message);
            }
        }

        public List<TbNest> SearchNestsByCriteria(string nestName, decimal maxPrice)
        {
            var dbContext = new BirdFarmShopContext();
            var query = dbContext.TbNests.AsQueryable();

            if (!string.IsNullOrEmpty(nestName))
            {
                query = query.Where(n => n.Name.Contains(nestName));
            }

            if (maxPrice > 0)
            {
                query = query.Where(n => n.Price <= maxPrice);
            }

            return query.ToList();
        }

        public TbNest GetNestById(string id)
        {
            var dbContext = new BirdFarmShopContext();
            return dbContext.TbNests
                .Include(n => n.BirdIdMaleNavigation.BirdSpecies)
                .Include(n => n.BirdIdFemaleNavigation.BirdSpecies)
                .Include(n => n.BirdIdMaleNavigation)
                .Include(n => n.BirdIdFemaleNavigation)
                .FirstOrDefault(n => n.NestId == id);
        }
    }
}
