using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Waless.API.Data;
using Waless.API.Dtos;

namespace Waless.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Email = userForRegisterDto.Email.ToLower();

            if(await _repo.UserExists(userForRegisterDto.Email)) return BadRequest("Email already exists");

            if(!ModelState.IsValid) return BadRequest(ModelState);

            var userToCreate = new Models.User
            {
                Email = userForRegisterDto.Email
            };

            var createUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}