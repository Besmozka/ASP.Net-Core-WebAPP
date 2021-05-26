using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Models;
using Timesheets.Models.Dto;

namespace Timesheets.Domain.Interfaces
{
    public interface IEmployeeManager
    {
        /// <summary> Возвращает пользователя по ID </summary>
        Task<Employee> GetEmployeeById(Guid id);

        /// <summary> Создает нового пользователя </summary>
        Task<Guid> CreateEmployee(EmployeeDTO employeeDTO);

        /// <summary> Обновляет данные пользователя по ID </summary>
        Task UpdateEmployeeById(EmployeeDTO employeeDTO);
        
        /// <summary> Удаляет пользователя через ID </summary>
        Task DeleteEmployee(Guid id);
    }
}