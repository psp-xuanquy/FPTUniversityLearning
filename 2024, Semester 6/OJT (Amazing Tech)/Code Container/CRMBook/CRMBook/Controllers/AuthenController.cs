using CRMBook.Repo;
using CRMBook.Sevices;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Ilogger = Serilog.ILogger;

namespace CRMBook.Controllers
{
    public class AuthenController : Controller
    {
        private readonly Ilogger _logger;
        private readonly IAuthencationServices _authencationServices;

        public AuthenController(IServiceProvider serviceProvider)
        {
            _logger = Log.Logger;
            _authencationServices = serviceProvider.GetRequiredService<IAuthencationServices>();
        }

        [HttpPost]
        [Route("/api/[Controller]/login")]
        public IActionResult login(RequestLoginModel request)
        {
            
            return Ok(_authencationServices.Authencation(request));
        }

        [HttpPost]
        [Route("/api/[Controller]/register")]
        public IActionResult register(RequestRegisterModel model)
        {
            _authencationServices.Register(model);
            return Ok();
        }
    }
}
