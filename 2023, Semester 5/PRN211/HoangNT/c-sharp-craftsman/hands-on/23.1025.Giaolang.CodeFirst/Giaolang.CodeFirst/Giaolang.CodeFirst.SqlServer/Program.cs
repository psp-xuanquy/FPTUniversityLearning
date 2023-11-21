namespace Giaolang.CodeFirst.SqlServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new ProductContext())
            //{
            //    //db.Database.EnsureCreated(); //tạo database nếu nó chưa tồn tại
            //    var prod = new Product() { Name = "Sting Dâu Xanh", Description = "Nước tăng lực xanh..." };
            //    db.Products.Add(prod);
            //    db.Products.Add(new Product() { Name = "Lipovitan", Description = "Nước tăng lực mật ong..." });
            //    db.Products.Add(new Product() { Name = "Cafe Chú Long", Description = "Cà phê muối vừa đủ..." });
            //    db.SaveChanges();
            //    Console.WriteLine("Insert successfully!!!");
            //}

            //lấy data show ra, dùng Linq
            using (var db = new ProductContext())
            {
                var result = db.Products.Where(s => true).ToList(); //select *
               
                Console.WriteLine("All of products from DB");

                result.ForEach(s => Console.WriteLine(s.Id + " | " 
                                                      + s.Name + " | " +
                                                        s.Description));
            }

        }
    }
}