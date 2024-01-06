using BookAPI.Data;
using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyApiNetCore6.Repositories;
using System.Security.Claims;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository accountRepo;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountsController(IAccountRepository repo, UserManager<ApplicationUser> userManager)
        {
            accountRepo = repo;
            this.userManager = userManager;
        }

        [HttpPost("SignUp")]
        public async Task<IActionResult> SignUp(SignUpModel signUpModel)
        {
            var result = await accountRepo.SignUpAsync(signUpModel);

            if (result.Succeeded)
            {
                return Ok(new { Success = true, Message = "User signed up successfully" });
            }

            return StatusCode(500, new { Success = false, Message = "Error signing up user" });
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn(SignInModel signInModel)
        {
            var result = await accountRepo.SignInAsync(signInModel);

            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }

            return Ok(new { Success = true, Token = result });
        }

        [Authorize]
        [HttpPut("UpdateInformation")]
        public async Task<IActionResult> UpdateInformation(UpdateInformationModel updateModel)
        {
            try
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // The [Authorize] attribute ensures that the user is authenticated,
                // so there's no need to check for null or empty userId here.

                var user = await userManager.FindByIdAsync(userId);

                if (user == null)
                {
                    // Log the issue and return NotFound
                    Console.WriteLine($"User not found with ID: {userId}");
                    return NotFound($"User not found with ID: {userId}");
                }

                user.FirstName = updateModel.FirstName;
                user.LastName = updateModel.LastName;
                user.Email = updateModel.Email;

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return Ok(new { Success = true, Message = "User information updated successfully" });
                }

                // Log the errors for debugging purposes
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Error updating user: {error.Description}");
                }

                return StatusCode(500, new { Success = false, Message = "Error updating user information" });
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine($"Error updating user: {ex.Message}");
                return StatusCode(500, new { Success = false, Message = "Error updating user information" });
            }
        }
    }
}
