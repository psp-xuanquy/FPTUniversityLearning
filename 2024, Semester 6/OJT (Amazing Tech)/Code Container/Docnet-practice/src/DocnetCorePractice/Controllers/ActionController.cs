﻿using DocnetCorePractice.Attribute;
using DocnetCorePractice.Data.Entity;
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

        private static List<CaffeEntity> caffes = new List<CaffeEntity>()
        {
            new CaffeEntity() 
            { 
                Id = Guid.NewGuid().ToString("N"), 
                Name = "Iced Milk Coffee", 
                Type = Enum.ProductType.A, 
                Price = 15_000, 
                Discount = 10, 
                IsActive = true 
            },
            new CaffeEntity() 
            { 
                Id = Guid.NewGuid().ToString("N"), 
                Name = "Iced Black Coffee", 
                Type = Enum.ProductType.A,
                Price = 20_000, 
                Discount = 15, 
                IsActive = true 
            },
            new CaffeEntity() 
            { 
                Id = Guid.NewGuid().ToString("N"), 
                Name = "Hot Milk Coffee",
                Type = Enum.ProductType.B,
                Price = 25_000, 
                Discount = 20, 
                IsActive = false 
            },
            new CaffeEntity() 
            { 
                Id = Guid.NewGuid().ToString("N"), 
                Name = "Mocha Coffee", 
                Type = Enum.ProductType.C, 
                Price = 30_000, 
                Discount = 25, 
                IsActive = true 
            }
        };

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

                var existCaffeId = caffes.Where(x => x.Id == caffeModel.Id).FirstOrDefault();
                var existCaffeName = caffes.Where(x => x.Name == caffeModel.Name).FirstOrDefault();

                if (existCaffeId != null || existCaffeName != null)
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
                return Ok(caffes);
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



        // 7.Viết API get all user data trả về được parse theo UserModel. nếu không có user nào thì return code 204

        // 8.Với input là ngày sinh(có kiều dữ liệu DateTime) và role(có kiểu dữ liệu Enum), Viết API get users với điều kiện:
        //      - là thành viên vip(có thể là vip1 hoặc vip2) và sinh trong tháng 6
        //  Nếu không có user nào thì return code 204



        // 9.Viết API update user với input là UserModel, kiểm tra điều kiện:
        //      - Id phải tồn tại trong UserEntity (nếu không thỏa return code 404)
        //      - ngày sinh không được nhập quá Datatime.Now (nếu không thỏa return code 400)
        //      - PhoneNumber phải đúng 10 ký tự (nếu không thỏa return code 400)
        //      - Balance hoặc TotalProduct >= 0 (nếu không thỏa return code 400)
        //  Nếu có điều kiện nào vi phạm thì không update và return code 400 cho client.

        // 10. Viết API Delete user với input là Id. User sẽ được delete nếu thỏa các điều kiện sau:
        //      - Id tồn tại trong UserEntity (nếu không thỏa return code 400)
        //      - Balance của user bằng 0 (nếu không thỏa return code 400)

        // (Lưu ý: các API phải được đặt trong try/catch, nếu APi lỗi sẽ return về code 500)

        private static List<OrderEntity> orders = new List<OrderEntity>();
        private static List<OrderItemEntity> orderItems = new List<OrderItemEntity>();

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