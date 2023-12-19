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
    public class ViewProductUltils
    {
        private readonly BirdFarmShopContext _context;

        public ViewProductUltils(BirdFarmShopContext context)
        {
            _context = context;
        }
        public ViewProduct GetProductById(string productId)
        {

            if (productId.StartsWith("BIRD"))
            {
                var bird = _context.TbBirds
                        .Include(b => b.BirdSpecies)
                        .FirstOrDefault(b => b.BirdId == productId);
                if (bird != null)
                {
                    return new ViewProduct
                    {
                        ProductId = productId,
                        ProductName = bird.Name,
                        ProductSpecies = bird.BirdSpecies.BirdSpeciesName,
                        ProductType = "Bird",
                        Price = bird.Price
                    };
                }
            }
            else if (productId.StartsWith("NEST"))
            {
                var nest = _context.TbNests
                        .FirstOrDefault(n => n.NestId == productId);
                if (nest != null)
                {
                    return new ViewProduct
                    {
                        ProductId = productId,
                        ProductName = nest.Name,
                        ProductSpecies = nest.BirdSpecies,
                        ProductType = "Bird",
                        Price = nest.Price
                    };
                }
            }
            //else if (productId.StartsWith("BREED"))
            //{
            //    var breed = _context.TbBreedings
            //             .FirstOrDefault(b => b.BreedId == productId);
            //    if (breed != null)
            //    {
            //        return new ViewProduct
            //        {
            //            ProductId = productId,
            //            ProductSpecies = breed.BirdSpecies,
            //            ProductType = "Breeding",
            //            ProductImage = "https://picturecontainer.blob.core.windows.net/breedingimage/giao_phoi_tuong_trung.jpg",
            //            Price = 1000000,
            //        };
            //    }
            //}

            return null;
        }
    }
}
