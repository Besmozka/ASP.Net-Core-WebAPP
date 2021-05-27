using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Domain.Interfaces;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Implementation
{
    public class EmployeeManager : IEmployeeManager
    {
        private IEmployeeRepo _repo;

        public EmployeeManager(IEmployeeRepo repo)
        {
            _repo = repo;
        }

        public async Task<Guid> CreateEmployee(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Id = Guid.NewGuid(),
                UserId = employeeDTO.UserId,
                IsDeleted = false,
                Sheets = new List<Sheet>()
            };
            await _repo.Add(employee);

            return employee.Id;
        }

        public async Task<Employee> GetEmployeeById(Guid id)
        {
            return await _repo.GetItem(id);
        }

        public async Task UpdateEmployeeById(EmployeeDTO employeeDTO)
        {
            Employee employee = new Employee
            {
                Id = employeeDTO.Id,
                UserId = employeeDTO.UserId,
                IsDeleted = employeeDTO.IsDeleted
            };
            await _repo.Update(employee);
        }

        public async Task DeleteEmployee(Guid id)
        {
            await _repo.Delete(id);
        }
    }
}
