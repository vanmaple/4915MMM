using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDP_EntityModels;
using Project.Data;
using Project.Models;
using Project.Services;

namespace Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAuthService _authService;

        public AuthController(AppDbContext context, IAuthService authService)
        {
            _context = context;
            _authService = authService;
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Password))
            {
                return BadRequest(new { Success = false, Message = "Username and password are required" });
            }


            IUser user = null;
            if (model.IsUser)
            {
                user = await _context.Customers
                    .FirstOrDefaultAsync(u => u.customerName == model.Username);
            }
            else
            {
                user = await _context.Admins
                    .FirstOrDefaultAsync(u => u.adminName == model.Username);
            }

            if (user == null || string.IsNullOrEmpty(user.Password) ||
                !_authService.VerifyPassword(model.Password, user.Password))
            {
                return Unauthorized(new { Success = false, Message = "Invalid username or password" });
            }


            var token = _authService.GenerateToken(user);


            return Ok(new LoginResponse
            {
                Success = true,
                Message = "Login successful",
                Token = token,
                User = new UserDto
                {
                    Id = model.IsUser ? ((Customer)user).customerID : ((Admin)user).adminID,
                    Username = user.Username,
                    IsUser = model.IsUser
                }
            });
        }
    }
}