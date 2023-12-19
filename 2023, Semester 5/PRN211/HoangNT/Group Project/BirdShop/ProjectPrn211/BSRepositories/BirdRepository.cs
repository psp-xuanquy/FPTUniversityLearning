using BSDAO;
using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public class BirdRepository : IBirdRepositories
    {
        public List<TbBird> GetAvailableBirds()
        {
            try
            {
                return BirdDAO.Instance.GetAvailableBird();
            }
            catch (Exception ex)
            {
                throw new Exception("Error get available bird: " + ex.Message);
            }
        }

        public bool AddBird(TbBird newBird)
        {
            try
            {

                return BirdDAO.Instance.AddBird(newBird);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding bird: " + ex.Message);
            }
        }

        public bool DeleteBird(string birdId)
        {
            try
            {

                return BirdDAO.Instance.DeleteBird(birdId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting bird: " + ex.Message);
            }
        }

        public List<TbBird> GetAllBirds()
        {
            try
            {
                return BirdDAO.Instance.GetAllBird();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting birds: " + ex.Message);
            }
        }

        public List<TbBirdCategory> GetAllBirdCategories()
        {
            try
            {

                return BirdDAO.Instance.GetAllBirdCategories();
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting bird categories: " + ex.Message);
            }
        }

        public List<TbBird> SearchBirdsByCriteria(string birdName, string birdSpeciesId, decimal maxPrice)
        {
            try
            {

                return BirdDAO.Instance.SearchBirdsByCriteria(birdName, birdSpeciesId, maxPrice);
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching birds: " + ex.Message);
            }
        }

        public bool UpdateBird(TbBird updatedBird)
        {
            try
            {

                return BirdDAO.Instance.UpdateBird(updatedBird);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating bird: " + ex.Message);
            }
        }

        public List<TbBird> GetAllBirdByCategories(string species)
        {
            try
            {
                return BirdDAO.Instance.GetAllBirdByCategories(species);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get available bird: " + ex.Message);
            }
        }

        public TbBird GetBirdById(string id)
        {
            try
            {
                return BirdDAO.Instance.GetBirdById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get bird: " + ex.Message);
            }
        }

        public TbBird GetTbBirdById(string id)
        {
            try
            {
                return BirdDAO.Instance.GetTbBirdById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error get bird: " + ex.Message);
            }
        }
    }
}
