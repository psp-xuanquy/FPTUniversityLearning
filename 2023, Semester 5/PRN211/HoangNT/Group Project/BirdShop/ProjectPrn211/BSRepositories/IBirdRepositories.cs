using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public interface IBirdRepositories
    {
        List<TbBird> GetAvailableBirds();
        List<TbBird> GetAllBirds();
        public List<TbBird> GetAllBirdByCategories(string species);
        bool AddBird(TbBird newBird);
        bool UpdateBird(TbBird updatedBird);
        bool DeleteBird(string birdId);
        List<TbBird> SearchBirdsByCriteria(string birdName, string birdSpeciesId, decimal maxPrice);
        List<TbBirdCategory> GetAllBirdCategories();
        public TbBird GetBirdById(string id);
        public TbBird GetTbBirdById(string id);
    }
}
