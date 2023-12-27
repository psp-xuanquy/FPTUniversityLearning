using Serilog;
using Serilog.Core;

namespace CRMCarManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //Log.Logger = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .WriteTo.File(path: "logs/CRMCarManagement/log-.log", 
            //                outputTemplate: "{Timestamp:o} [{Level:u3}] ({SourceContext}) {Message}{NewLine}{Exception}", 
            //                rollingInterval: RollingInterval.Day)
            //    .MinimumLevel.Debug()
            //    .CreateLogger();
            
            var builder = WebApplication.CreateBuilder(args);
                _ = builder.Host.UseSerilog((httpHost, config) =>
                _ = config.ReadFrom.Configuration(builder.Configuration));

            // Add services to the container.
            var connectionstring = builder.Configuration.GetConnectionString("DefaultConnectStrings");
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen( option =>
            {
                option.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "CRMCarManagement.API", Version = "v1" });
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.UseSwagger();
            //    app.UseSwaggerUI();
            //}
            if (true)
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            List<Car> cars = new List<Car>()
            {
                new Car() { Id = 1, Name = "Lexus", Brand = "Toyota", Price = 100000 },
                new Car() { Id = 2, Name = "Daihatsu", Brand = "Toyota", Price = 200000 },
                new Car() { Id = 3, Name = "BMW", Brand = "BMW Group", Price = 300000 },
            };

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.MapGet("api/minimal/getallcar", () =>
            {
                Results.Ok(cars);
            });

            app.MapPost("api/minimal/addcar", (Car car) =>
            {
                cars.Add(car);
                return Results.Ok(cars);
            });

            app.Run();
        }
    }
}
