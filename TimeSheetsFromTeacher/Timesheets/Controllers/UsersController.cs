using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var response = await _userManager.CreateUser(request);

            return Ok(response);
        }

        [HttpGet("[controller]/{id}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid id)
        {
            var response = await _userManager.GetUserById(id);

            return Ok(response);
        }

        [HttpPut("[controller]/update")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDTO user)
        {
            await _userManager.UpdateUserById(user);

            return Ok();
        }

        [HttpDelete("[controller]/delete/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            await _userManager.DeleteUser(id);

            return Ok();
        }
    }
}