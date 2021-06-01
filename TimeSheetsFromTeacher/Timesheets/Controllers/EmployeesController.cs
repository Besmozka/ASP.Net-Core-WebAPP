using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Timesheets.Domain.Interfaces;
using Timesheets.Models.Dto;

namespace Timesheets.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeesController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] EmployeeDTO request)
        {
            var response = await _employeeManager.CreateEmployee(request);

            return Ok(response);
        }

        [HttpGet("[controller]/{id}")]
        public async Task<IActionResult> GetUser([FromRoute] Guid id)
        {
            var response = await _employeeManager.GetEmployeeById(id);

            return Ok(response);
        }

        [HttpPut("[controller]/update")]
        public async Task<IActionResult> UpdateUser([FromBody] EmployeeDTO employee)
        {
            await _employeeManager.UpdateEmployeeById(employee);

            return Ok();
        }

        [HttpDelete("[controller]/delete/{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] Guid id)
        {
            await _employeeManager.DeleteEmployee(id);

            return Ok();
        }
    }
}