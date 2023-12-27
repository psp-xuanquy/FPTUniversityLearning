using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using Ilogger = Serilog.ILogger;

namespace CRMCarManagement.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly Ilogger _logger;

        public CarsController()
        {
            _logger = Log.Logger;
        }

        private static List<Car> cars = new List<Car>()
        {
            new Car() { Id = 1, Name = "Lexus", Brand = "Toyota", Price = 100000 },
            new Car() { Id = 2, Name = "Daihatsu", Brand = "Toyota", Price = 200000 },
            new Car() { Id = 3, Name = "BMW", Brand = "BMW Group", Price = 300000 },
        };

        [HttpGet]   //SELECT
        [Route("/api/[controller]/get-all-car")]
        public IActionResult GetAllCar()
        {
            return Ok(cars);
        }

        [HttpPost]  //CREATE
        [Route("/api/[controller]/add-car")]
        public IActionResult AddNewCar([FromBody] Car car)
        {
            var existCar = cars.Where(x => x.Id == car.Id).FirstOrDefault();
            if (existCar != null)
            {
                return BadRequest($"Car has Id = {car.Id} is existed");
            }
            cars.Add(car);
            var jsonCar = JsonConvert.SerializeObject(car);
            _logger.Information(jsonCar);
            return Ok(cars);
        }

        [HttpPut]   //UPDATE
        [Route("/api/[controller]/update-car")]
        public IActionResult UpdateCar([FromBody] Car car)
        {
            _logger.Information("Update Car");
            //var existCar = cars.Where(x => x.Id == car.Id).FirstOrDefault();
            //if (existCar == null)
            //{
            //    return BadRequest("Car is not existed");
            //}

            //for (int i = 0; i < cars.Count; i++)
            //{
            //    if (car.Id == cars[i].Id)
            //    {
            //        cars[i].Name = car.Name;
            //        cars[i].Price = car.Price;
            //        cars[i].Brand = car.Brand;
            //    }
            //}

            var car1 = cars.Where(x => x.Id == car.Id).SingleOrDefault();
            if (car1 == null)
            {
                return BadRequest("Car is not existed");
            }
            car1.Name = car.Name;
            car1.Price = car.Price;
            car1.Brand = car.Brand;

            var jsonCar = JsonConvert.SerializeObject(car);
            _logger.Information(jsonCar);
            return Ok(cars);
        }

        [HttpDelete]    //DELETE
        [Route("/api/[controller]/delete-car/{id}")]
        public IActionResult deleteCar(int id)
        {
            var car = cars.Where(x => x.Id == id).SingleOrDefault();
            if (car == null)
            {
                return BadRequest("Car is not found");
            }

            cars.Remove(car);
            return Ok(cars);
        }

        [HttpGet]
        [Route("api/[controller]/get-car-by-id/{id}")]
        public IActionResult GetCarById(int id)
        {
            return Ok(cars.Where(_ => _.Id == id).SingleOrDefault());
        }
    }
}
