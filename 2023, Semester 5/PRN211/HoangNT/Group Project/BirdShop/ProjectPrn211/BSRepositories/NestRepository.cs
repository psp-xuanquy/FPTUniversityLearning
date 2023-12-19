using BSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSRepositories
{
    public class NestRepository : INestRepositories
    {
        public bool AddNest(TbNest newNest)
        {
            try
            {

                return NestDAO.Instance.AddNest(newNest);
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding nest: " + ex.Message);
            }
        }

        public bool DeleteNest(string nestId)
        {
            try
            {

                return NestDAO.Instance.DeleteNest(nestId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting nest: " + ex.Message);
            }
        }

        public List<TbNest> GetAllNests()
        {
            try
            {

                return NestDAO.Instance.GetAllNests();
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

                return NestDAO.Instance.GetAllNestsAvailable();
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

                return NestDAO.Instance.GetAllNestsByCategories(species);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting nests: " + ex.Message);
            }
        }

        public TbNest GetNestById(string id)
        {
            try
            {

                return NestDAO.Instance.GetNestById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error getting nest: " + ex.Message);
            }
        }

        public List<TbNest> SearchNestsByCriteria(string nestName, decimal maxPrice)
        {
            try
            {

                return NestDAO.Instance.SearchNestsByCriteria(nestName, maxPrice);
            }
            catch (Exception ex)
            {
                throw new Exception("Error searching nests: " + ex.Message);
            }
        }

        public bool UpdateNest(TbNest updatedNest)
        {
            try
            {

                return NestDAO.Instance.UpdateNest(updatedNest);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating nest: " + ex.Message);
            }
        }
    }
}
