using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDAO
{
    public class BirdDAO
    {
        private static BirdDAO instance = null;

        private BirdDAO()
        {
        }

        public static BirdDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BirdDAO();
                }
                return instance;
            }
        }
        public List<TbBird> GetAllBird()
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                return dbContext.TbBirds.Include(b => b.BirdSpecies).ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        public bool AddBird(TbBird newBird)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                int birdCount = dbContext.TbBirds.Count();
                string newBirdId = "BIRD" + Guid.NewGuid().ToString();

                newBird.BirdId = newBirdId;
                dbContext.TbBirds.Add(newBird);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding bird: " + ex.Message);
            }
        }
        public bool UpdateBird(TbBird updatedBird)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                dbContext.TbBirds.Update(updatedBird);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating bird: " + ex.Message);
            }
        }
        public bool DeleteBird(string birdId)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                var birdToDelete = dbContext.TbBirds.Find(birdId);
                if (birdToDelete != null)
                {
                    dbContext.TbBirds.Remove(birdToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting bird: " + ex.Message);
            }
        }
        public List<TbBird> SearchBirdsByCriteria(string birdName, string birdSpeciesId, decimal maxPrice)
        {
            var dbContext = new BirdFarmShopContext();
            var query = dbContext.TbBirds.AsQueryable();

            if (!string.IsNullOrEmpty(birdName))
            {
                query = query.Where(b => b.Name.Contains(birdName));
            }

            if (!string.IsNullOrEmpty(birdSpeciesId))
            {
                query = query.Where(b => b.BirdSpeciesId == birdSpeciesId);
            }

            if (maxPrice > 0)
            {
                query = query.Where(b => b.Price <= maxPrice);
            }

            return query.ToList();
        }
        public List<TbBirdCategory> GetAllBirdCategories()
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                return dbContext.TbBirdCategories.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting bird categories: " + ex.Message);
            }
        }
        public List<TbBird> GetAllBirdByCategories(string species)
        {
            var birds = new BirdFarmShopContext();
            var availableBirdsSpecies = birds.TbBirds
                .Include(b => b.BirdSpecies)
                .Where(b => b.StatusSold == false && b.BirdSpecies.BirdSpeciesName == species)
                .ToList();

            return availableBirdsSpecies;
        }
        public List<TbBird> GetAvailableBird()
        {
            var birds = new BirdFarmShopContext();
            var availableBirds = birds.TbBirds
                .Include(b => b.BirdSpecies)
                .Where(b => b.StatusSold == false)
                .ToList();

            return availableBirds;
        }
        public TbBird GetBirdById(string id)
        {
            var dbContext = new BirdFarmShopContext();
            var bird = dbContext.TbBirds
                .Include(b => b.BirdSpecies)
                .FirstOrDefault(b => b.BirdId == id);

            return bird;
        }
        public TbBird GetTbBirdById(string id)
        {
            var dbContext = new BirdFarmShopContext();
            return dbContext.TbBirds.SingleOrDefault(b => b.BirdId == id);
        }
    }
}
