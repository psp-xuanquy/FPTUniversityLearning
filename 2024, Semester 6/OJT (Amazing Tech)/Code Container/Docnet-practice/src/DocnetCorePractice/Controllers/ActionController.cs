using DocnetCorePractice.Attribute;
using DocnetCorePractice.Data.Entity;
using DocnetCorePractice.Enum;
using DocnetCorePractice.Model;
using DocnetCorePractice.Service;
using DocnetCorePractice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using Ilogger = Serilog.ILogger;

namespace DocnetCorePractice.Controllers
{
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly Ilogger _logger;
        private readonly IAuthenticationService _authenticationService;
        public IUserService _userService;
        public ActionController(IServiceProvider serviceProvider)
        {
            _authenticationService = serviceProvider.GetRequiredService<IAuthenticationService>();
            _userService = serviceProvider.GetRequiredService<IUserService>();
            _logger = Log.Logger;
        }

        private static List<UserEntity> users = new List<UserEntity>()
        {
            new UserEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                FirstName = "huy",
                LastName = "nguyen",
                Sex = Enum.Sex.Male,
                Address = "Ho chi Minh",
                Balance = 100000,
                DateOfBirth = DateTime.Now,
                PhoneNumber = "0123456789",
                Roles = Enum.Roles.Basic,
                TotalProduct = 0,
                IsActive = true
            }
        };

        private static List<CaffeEntity> caffes = new List<CaffeEntity>()
        {
            new CaffeEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                Name = "Ca phe sua",
                Price = 20000,
                Discount = 10,
                Type = Enum.ProductType.A,
                IsActive = true
            }
        };

        private static List<OrderItemEntity> orderItems = new List<OrderItemEntity>();
        private static List<OrderEntity> orders = new List<OrderEntity>();

        [HttpPost]
        [Route("/api/[controller]/login")]
        public IActionResult Login(RequestLoginModel request)
        {
            return Ok(_authenticationService.Authenticator(request));
        }

        [ApiKey]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("/api/[controller]/getalluser")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAllUser();
            return Ok(result);
        }


        [HttpPost("/api/[controller]/adduser")]
        public IActionResult AddUser([FromBody] UserModel model)
        {
            var result = _userService.AddUser(model);
            return Ok(result);
        }


        // 1. Viết API insert thêm caffe mới vào menu với input là CaffeModel, kiểm tra điều kiện:
        //      - Name và Id không tồn tại trong CaffeEntity (nếu không thỏa return code 400)
        //      - Price hoặc discount >= 0 (nếu không thỏa return code 400)
        //   Nếu có điều kiện nào vi phạm thì không insert và return failed.
        [HttpPost]
        [Route("/api/[controller]/insert-caffe")]
        public IActionResult InsertCaffe([FromBody] CaffeModel caffeModel)
        {
            try
            {
                _logger.Information("Start Inserting new caffe");

                var existCaffeId = caffes.Any(x => x.Id == caffeModel.Id);
                var existCaffeName = caffes.Any(x => x.Name == caffeModel.Name);

                if (existCaffeId || existCaffeName)
                {
                    return BadRequest("Caffe Name or Id has already existed in the menu.");
                }

                if (caffeModel.Price < 0 || caffeModel.Discount < 0)
                {
                    return BadRequest("Price or Discount cannot be negative.");
                }

                var newCaffe = new CaffeEntity
                {
                    Id = caffeModel.Id,
                    Name = caffeModel.Name,
                    Type = caffeModel.Type,
                    Price = caffeModel.Price,
                    Discount = caffeModel.Discount,
                    IsActive = true
                };
                caffes.Add(newCaffe);

                var jsonCaffe = JsonConvert.SerializeObject(caffes);
                _logger.Information(jsonCaffe);
                return Ok(new { Message = "Caffe inserted successfully", CaffeId = newCaffe.Id });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during Caffe insertion");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 2. Viết API get all caffe có IsActive = true theo CaffeModel. nếu không có caffe nào thì return code 204
        [HttpGet]
        [Route("/api/[controller]/get-all-active-caffe")]
        public IActionResult GetAllActiveCaffe()
        {
            try
            {
                _logger.Information("Start retrieving all active caffes");

                var activeCaffes = caffes.Where(x => x.IsActive).ToList();

                if (activeCaffes.Count == 0)
                {
                    return NoContent();
                }

                var jsonCaffe = JsonConvert.SerializeObject(activeCaffes);
                _logger.Information(jsonCaffe);
                return Ok(jsonCaffe);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during retrieving active caffes");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 3. Viết API get detail caffe có input là Id với điều kiện isActive bằng true. Nếu không có user nào thì return code 204
        [HttpGet]
        [Route("/api/[controller]/get-all-detail-caffe-by-id/{id}")]
        public IActionResult GetCaffeById(string id)
        {
            try
            {
                _logger.Information($"Start retrieving caffe with Id {id}");

                var selectedCaffe = caffes.FirstOrDefault(x => x.Id == id && x.IsActive);

                if (selectedCaffe == null)
                {
                    return NoContent();
                }

                var jsonCaffe = JsonConvert.SerializeObject(selectedCaffe);
                _logger.Information("Caffe found: {JsonCaffe}", jsonCaffe);
                return Ok(jsonCaffe);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error during retrieving caffe with Id: {id}");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 4. Viết API update caffe với input là Id, price và discount. kiểm tra điều kiện:
        //      - Id tồn tại trong CaffeEntity (nếu không thỏa return code 404)
        //      - Price hoặc discount >= 0 (nếu không thỏa return code 400)
        //   Nếu có điều kiện nào vi phạm thì không insert và return failed.
        [HttpPut]
        [Route("/api/[controller]/update-caffe/{id}")]
        public IActionResult UpdateCaffe(string id, [FromBody] CaffeEntity updatedCaffe)
        {
            try
            {
                _logger.Information($"Start updating caffe with Id {id}");

                var existedCaffe = caffes.FirstOrDefault(x => x.Id == id);

                if (existedCaffe == null)
                {
                    return NotFound($"Caffe with Id {id} not found.");
                }

                if (updatedCaffe.Price < 0 || updatedCaffe.Discount < 0)
                {
                    return BadRequest("Price or Discount cannot be negative.");
                }

                existedCaffe.Price = updatedCaffe.Price;
                existedCaffe.Discount = updatedCaffe.Discount;

                var jsonCaffe = JsonConvert.SerializeObject(existedCaffe);
                _logger.Information($"Caffe with Id {id} updated successfully: {jsonCaffe}");
                return Ok(existedCaffe);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error during updating caffe with Id: {id}");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 5. Viết API Delete caffe với input là Id. Caffe sẽ được delete nếu thỏa điều kiện sau:
        //      - Id tồn tại trong CaffeEntity (nếu không thỏa return code 400)
        [HttpDelete]
        [Route("/api/[controller]/delete-caffe/{id}")]
        public IActionResult DeleteCaffe(string id)
        {
            try
            {
                _logger.Information($"Start deleting caffe with Id {id}");

                var deleteCaffe = caffes.FirstOrDefault(x => x.Id == id);

                if (deleteCaffe == null)
                {
                    return NotFound($"Caffe with Id {id} not found.");
                }

                caffes.Remove(deleteCaffe);
                _logger.Information($"Caffe with Id {id} deleted successfully");
                return Ok(new { DeletedCoffee = deleteCaffe, UpdatedCoffees = caffes });
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error during deleting caffe with Id: {id}");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 6.Viết API insert thêm user mới với input là UserModel, kiểm tra điều kiện:
        //      - PhoneNumber và Id không tồn tại trong UserEntity (nếu không thỏa return code 400)
        //      - ngày sinh không được nhập quá Datatime.Now (nếu không thỏa return code 400)
        //      - PhoneNumber phải đúng 10 ký tự (nếu không thỏa return code 400)
        //      - Balance hoặc TotalProduct >= 0 (nếu không thỏa return code 400)
        //  Nếu có điều kiện nào vi phạm thì không insert và return failed.
        [HttpPost]
        [Route("/api/[controller]/insert-user")]
        public IActionResult InsertUser([FromBody] UserModel userModel)
        {
            try
            {
                _logger.Information("Start inserting new user");

                if (users.Any(user => user.PhoneNumber == userModel.PhoneNumber || user.Id == userModel.Id))
                {
                    return BadRequest("PhoneNumber or Id already exists in UserEntity.");
                }

                if (userModel.DateOfBirth > DateTime.Now)
                {
                    return BadRequest("Date of birth cannot be in the future.");
                }

                if (userModel.PhoneNumber.Length != 10)
                {
                    return BadRequest("PhoneNumber must have exactly 10 characters.");
                }

                if (userModel.Balance < 0 || userModel.TotalProduct < 0)
                {
                    return BadRequest("Balance or TotalProduct cannot be negative.");
                }

                users.Add(new UserEntity
                {
                    Id = userModel.Id,
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    Sex = userModel.Sex,
                    DateOfBirth = userModel.DateOfBirth,
                    Address = userModel.Address,
                    PhoneNumber = userModel.PhoneNumber,
                    Balance = userModel.Balance,
                    TotalProduct = userModel.TotalProduct,
                    IsActive = true
                });

                _logger.Information($"User with Id {userModel.Id} inserted successfully");
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during user insertion");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 7.Viết API get all user data trả về được parse theo UserModel. nếu không có user nào thì return code 204
        [HttpGet]
        [Route("/api/[controller]/get-all-users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                _logger.Information("Start retrieving all users");

                if (users.Any())
                {
                    var listUserModel = users.Select(user => new UserModel
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Sex = user.Sex,
                        DateOfBirth = user.DateOfBirth,
                        Address = user.Address,
                        PhoneNumber = user.PhoneNumber,
                        Balance = user.Balance,
                        TotalProduct = user.TotalProduct
                    }).ToList();

                    return Ok(listUserModel);
                }
                else return NotFound("No users found.");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during retrieving all users");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 8.Với input là ngày sinh(có kiều dữ liệu DateTime) và role(có kiểu dữ liệu Enum), Viết API get users với điều kiện:
        //      - là thành viên vip(có thể là vip1 hoặc vip2) và sinh trong tháng 6
        //  Nếu không có user nào thì return code 204
        [HttpGet]
        [Route("/api/[controller]/get-vip-users-in-june")]
        public IActionResult GetVipUsersInJune()
        {
            try
            {
                _logger.Information("Start retrieving VIP users born in June");

                var vipUsersInJune = users
                    .Where(user => (user.Roles == Roles.Vip1 || user.Roles == Roles.Vip2) &&
                                   user.DateOfBirth.Month == 6)
                    .ToList();

                if (vipUsersInJune.Any())
                {
                    var listUserModel = vipUsersInJune.Select(user => new UserModel
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Sex = user.Sex,
                        DateOfBirth = user.DateOfBirth,
                        Address = user.Address,
                        PhoneNumber = user.PhoneNumber,
                        Balance = user.Balance,
                        TotalProduct = user.TotalProduct
                    }).ToList();

                    return Ok(listUserModel);
                }
                else
                {
                    return NoContent(); // 204 No Content
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error during retrieving VIP users born in June");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // 9.Viết API update user với input là UserModel, kiểm tra điều kiện:
        //      - Id phải tồn tại trong UserEntity (nếu không thỏa return code 404)
        //      - ngày sinh không được nhập quá Datatime.Now (nếu không thỏa return code 400)
        //      - PhoneNumber phải đúng 10 ký tự (nếu không thỏa return code 400)
        //      - Balance hoặc TotalProduct >= 0 (nếu không thỏa return code 400)
        //  Nếu có điều kiện nào vi phạm thì không update và return code 400 cho client.
        // Cập nhật thông tin người dùng
        [HttpPut]
        [Route("/api/[controller]/update-user")]
        public IActionResult UpdateUser([FromBody] UserModel userModel)
        {
            try
            {
                _logger.Information($"Start updating user with Id {userModel.Id}");

                var existingUser = users.FirstOrDefault(user => user.Id == userModel.Id);

                if (existingUser == null)
                {
                    return NotFound($"User with Id {userModel.Id} not found.");
                }

                if (userModel.DateOfBirth > DateTime.Now)
                {
                    return BadRequest("Date of birth cannot be in the future.");
                }

                if (userModel.PhoneNumber.Length != 10)
                {
                    return BadRequest("Phone number must be 10 characters long.");
                }

                if (userModel.Balance < 0 || userModel.TotalProduct < 0)
                {
                    return BadRequest("Balance or TotalProduct cannot be negative.");
                }

                existingUser.FirstName = userModel.FirstName;
                existingUser.LastName = userModel.LastName;
                existingUser.Sex = userModel.Sex;
                existingUser.DateOfBirth = userModel.DateOfBirth;
                existingUser.Address = userModel.Address;
                existingUser.PhoneNumber = userModel.PhoneNumber;
                existingUser.Balance = userModel.Balance;
                existingUser.TotalProduct = userModel.TotalProduct;

                var jsonUser = JsonConvert.SerializeObject(existingUser);
                _logger.Information($"User with Id {userModel.Id} updated successfully: {jsonUser}");
                return Ok(existingUser);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error during updating user with Id: {userModel.Id}");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }


        // 10. Viết API Delete user với input là Id. User sẽ được delete nếu thỏa các điều kiện sau:
        //      - Id tồn tại trong UserEntity (nếu không thỏa return code 400)
        //      - Balance của user bằng 0 (nếu không thỏa return code 400)
        [HttpDelete]
        [Route("/api/[controller]/delete-user/{id}")]
        public IActionResult DeleteUser(string id)
        {
            try
            {
                _logger.Information($"Start deleting user with Id {id}");

                var deleteUser = users.FirstOrDefault(user => user.Id == id);

                if (deleteUser == null)
                {
                    return NotFound($"User with Id {id} not found.");
                }

                if (deleteUser.Balance != 0)
                {
                    return BadRequest($"Cannot delete user with non-zero balance.");
                }

                users.Remove(deleteUser);

                _logger.Information($"User with Id {id} deleted successfully");
                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error during deleting user with Id: {id}");
                return StatusCode(500, "An internal server error occurred. Please check the logs for details.");
            }
        }

        // (Lưu ý: các API phải được đặt trong try/catch, nếu APi lỗi sẽ return về code 500)


        // 11. Tạo CreateOrderRequest model để nhập các thông tin cho việc insert một order mới theo json:
        //{
        //  "userId": "string",
        //  "items": [
        //    {
        //      "caffeeId": "string",
        //      "volumn": 0,
        //    }
        //  ]
        //}

        // 12. Tạo CreateOrderResponse model để trả về thông tin cho việc insert một order mới theo json:
        //{
        //  "userId": "string",
        //  "orderId": "string",
        //  "total": 0,
        //  "items": [
        //    {
        //      "name": "string",
        //      "unitPrice": 0,
        //      "volumn": 0,
        //      "discount": 0,
        //      "price": 0
        //    }
        //  ]
        //}

        // 13. Viết function tính tổng tiền của một order với input là  CreateOrderResponse model.
        public class OrderHelper
        {
            public static decimal CalculateTotalAmount(CreateOrderResponse order)
            {
                decimal totalAmount = 0;

                if (order != null && order.Items != null)
                {
                    foreach (var item in order.Items)
                    {
                        totalAmount += (decimal)item.Price;
                    }
                }

                return totalAmount;
            }
        }

        // 14. Viết API tạo 1 order mới với input là CreateOrderRequest model được tạo ở bài 11. Yêu cầu:
        //        - Kiểm tra nếu userId nếu không tồn tại thì return code 404
        //        - Kiểm tra nếu list Items là rỗng thì return code 400
        //        - khởi tạo một order và insert vào OrderEntity với status là WaitToPay
        //        - lần lượt insert các item vào OrderItemEntity
        //        - Dùng function trong bài 13 để tính TotalPrice và update vào OrderEntity
        //        - Return code 200 theo CreateOrderResponse model.
        

        // 15. Tạo UpdateOrderRequest model để nhập các thông tin cho việc update một order theo json:
        //{
        //  "orderId": "string",
        //  "addItems": [
        //    {
        //      "caffeeId": "string",
        //      "volumn": 0,
        //    }
        //  ],
        //  "updateItems": [
        //    {
        //      "orderItemId": "string",
        //      "volumn": 0
        //    }
        //  ],
        //  "removeItems": [
        //    {
        //      "orderItemId": "string"
        //    }
        //  ]
        //}

        // 16. Viết API update 1 order với input là UpdateOrderRequest model được tạo ở bài 15. Yêu cầu:
        //       - Kiểm tra nếu orderId nếu không tồn tại thì return code 404
        //       - Kiểm tra Order, nếu Status không phải là WaitToPay => return code 400
        //       - Thực hiện thêm các items từ list addItems vào OrderItemEntity
        //       - Thực hiện update các items và tính lại ItemPrice từ list updateItems vào OrderItemEntity
        //       - Thực hiện xóa các items từ list removeItems vào OrderItemEntity bằng cách thay đổi IsDeleted = true
        //       - Thực hiện tính toán lại Totalprice và cập nhật lại OrderEntity.
        //       - Return code 202

        // 17 Viết API approved order với input là orderId. Yêu cầu:
        //       - Kiểm tra nếu orderId nếu không tồn tại thì return code 404
        //       - Kiểm tra Order, nếu Status không phải là WaitToPay => return code 400
        //       - Kiểm tra Balance của User, nếu Balance < TotalPrice=> return code 400
        //       - Thực hiện tính toán lại balance cho user
        //       - Update lại status cho Order => Success
        //       - Return code 200

    }
}
