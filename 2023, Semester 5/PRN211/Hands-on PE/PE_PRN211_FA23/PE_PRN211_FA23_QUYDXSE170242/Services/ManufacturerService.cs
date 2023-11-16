using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{

    /// <summary>
    /// Class này cung cấp dữ liệu từ table Category cho UI, và ngược lại
    /// Class này sẽ xài CategoryRepo vừa tạo, Repo thì lại gọi đến DbContex
    /// </summary>
    public class ManufacturerService
    {

        private ManufacturerRepository _repo;
        public List<Manufacturer> GetAllCategories()
        {
            _repo = new ManufacturerRepository();
            return _repo.GetAll();
        }

    }
}
