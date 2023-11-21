using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giaolang.CodeFirst.SqlServer
{
    public class ProductContext : DbContext  //class Cha, Con đại diện cho 1 DB mình sẽ xài
    {

        private string connectionString = @"Server=localhost,1433;Initial Catalog=ProductDB;Integrated Security=True;
                                           Trusted_Connection=true;Encrypt=false";
        public DbSet<Product> Products { get; set; }
        //tui - table Products trong tương lai sẽ chứa nhiều new Product() new Product()               

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        



    }
}
