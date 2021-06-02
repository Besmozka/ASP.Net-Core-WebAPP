using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeDTO request)
        {
            var response = await _employeeManager.CreateEmployee(request);

            return Ok(response);
        }

        [Authorize(Roles = "admin,client")]
        [HttpGet("[controller]/{id}")]
        public async Task<IActionResult> GetEmployee([FromRoute] Guid id)
        {
            var response = await _employeeManager.GetEmployeeById(id);

            return Ok(response);
        }

        [Authorize(Roles = "admin")]
        [HttpPut("[controller]/update")]
        public async Task<IActionResult> UpdateEmployee([FromBody] EmployeeDTO employee)
        {
            await _employeeManager.UpdateEmployeeById(employee);

            return Ok();
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("[controller]/delete/{id}")]
        public async Task<IActionResult> DeleteEmployee([FromRoute] Guid id)
        {
            await _employeeManager.DeleteEmployee(id);

            return Ok();
        }
    }
}