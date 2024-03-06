using CRMBook;
using Serilog;
using Microsoft.EntityFrameworkCore;
using CRMBook.Repo;
using CRMBook.Models;
using CRMBook.Sevices;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;
using Microsoft.OpenApi.Models;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(path: "logs/crmBook/log-.log",
                  outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}",
                  rollingInterval: RollingInterval.Day)
    .MinimumLevel.Debug()
    .CreateLogger();
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnectstrings");
builder.Services.AddDbContext<cmdBookContext>(option =>
{
    option.UseSqlServer(connectionString);
}
);
builder.Services.AddScoped<IBookRepo, BookRepo>();
builder.Services.AddScoped<IAuthencationServices, AuthencationServices>();
// Add services to the container.
_ = builder.Host.UseSerilog((httpHost, config) =>
   _ = config.ReadFrom.Configuration(builder.Configuration));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
                                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                                {
                                    In = ParameterLocation.Header,
                                    Description = "Insert JWT Token",
                                    Name = "Authorization",
                                    Type = SecuritySchemeType.Http,
                                    BearerFormat = "JWT",
                                    Scheme = "bearer",
                                }));
builder.Services.AddSwaggerGen(W =>
         W.AddSecurityRequirement(
             new OpenApiSecurityRequirement {
                 {
                     new OpenApiSecurityScheme
                     {
                         Reference = new OpenApiReference
                         {
                             Type = ReferenceType.SecurityScheme,
                             Id = "Bearer"
                         }
                     },

                     new String[]{}
                 } 
             }));
builder.Services.AddAuthentication("Bearer").AddJwtBearer(o =>
{
    o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("hgfashdasjdgkjashdjkhasjkdhaadasda"))

    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Book_id = 0,
                Name = "chùm nho thịnh nộ",
                Author = "John Steinbeck",
                Category = "Fiction, Nobel",
                Description = "Câu chuyện xảy ra gần một thế kỷ trước: Gia đình Joad bỏ nhà cửa, ruộng đồng, mồ mả tổ tiên ở Oklahoma, tìm mọi cách chạy qua California để khỏi chết đói. ",
                Price = (decimal?)242.250,
            }
        };


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseAuthentication();

app.MapGet("api/minimal/getallbook", () =>
{
    Results.Ok(Books);
});
app.Run();
