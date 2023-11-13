using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        void IProductRepository.Add(TblProduct newProduct) => ProductDAO.Instance.AddProduct(newProduct);

        List<TblProduct> IProductRepository.GetAllAvailableProduct() => ProductDAO.Instance.GetAllAvailableProduct();

        List<TblProduct> IProductRepository.GetAllProduct() => ProductDAO.Instance.GetAllProduct();

        List<TblProduct> IProductRepository.GetAllProductByCategory(string categoryID) => ProductDAO.Instance.GetAllProductByCategory(categoryID);

        void IProductRepository.Update(TblProduct product) => ProductDAO.Instance.UpdateProduct(product);

        public TblProduct GetProductByID(string productID) => ProductDAO.Instance.GetProductByID(productID);

        public List<TblProduct> GetAllProductByName(string Name) => ProductDAO.Instance.GetAllProductByName(Name);
    }
}
