using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        // Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<TblProduct> GetAllProduct()
        {
            List<TblProduct> listProduct = new List<TblProduct>();
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    listProduct = ctx.TblProducts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProduct;
        }

        public List<TblProduct> GetAllAvailableProduct()
        {
            List<TblProduct> listProduct = new List<TblProduct>();
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    listProduct = ctx.TblProducts.ToList();
                    listProduct = listProduct.Where(product => product.Quantity > 0).ToList<TblProduct>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProduct;
        }

        public List<TblProduct> GetAllProductByName(string Name)
        {
            List<TblProduct> listProduct = new List<TblProduct>();
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    listProduct = ctx.TblProducts.ToList();
                    listProduct = listProduct.Where(product => product.ProductName.ToLower().Contains(Name.ToLower())).ToList<TblProduct>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProduct;
        }

        public TblProduct GetProductByID(string productID)
        {
            TblProduct Product = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    Product = ctx.TblProducts.SingleOrDefault(product => product.ProductId.Equals(productID));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return Product;
        }

        public List<TblProduct> GetAllProductByCategory(string productID)
        {
            List<TblProduct> listProduct = new List<TblProduct>();
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    listProduct = ctx.TblProducts.ToList();
                    listProduct = listProduct.Where(product => product.CategoryId.Equals(productID)).ToList<TblProduct>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listProduct;
        }

        public void AddProduct(TblProduct newProduct)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    if (newProduct.Quantity == 0)
                    {
                        newProduct.StatusId = "OutOfStock";
                    }

                    ctx.TblProducts.Add(newProduct);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(TblProduct product)
        {
            using (var ctx = new prn211group4Context())
            {
                if (product.Quantity == 0)
                {
                    product.StatusId = "OutOfStock";
                }
                else if (product.Quantity > 0 && product.StatusId == "OutOfStock")
                {
                    product.StatusId = "Available";
                }

                ctx.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
        }

    }
}
