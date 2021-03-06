using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Timesheets.Data.Ef;
using Timesheets.Data.Interfaces;
using Timesheets.Models;

namespace Timesheets.Data.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private TimesheetDbContext _context;

        public EmployeeRepo(TimesheetDbContext context)
        {
            _context = context;
        }


        public async Task Add(Employee item)
        {
            await _context.Employees.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> GetItem(Guid id)
        {
            var result = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);

            return result;
        }

        public async Task<IEnumerable<Employee>> GetItems()
        {
            var result = await _context.Employees.ToListAsync();

            return result;
        }

        public async Task Update(Employee item)
        {
            Employee employeeToUpdate = await _context.Employees.FirstAsync(x => x.Id == item.Id);
            employeeToUpdate.UserId = item.UserId;
            employeeToUpdate.IsDeleted = item.IsDeleted;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var employeeToDelete = await _context.Employees.FirstOrDefaultAsync(x => x.Id == id);
            _context.Employees.Remove(employeeToDelete);
            await _context.SaveChangesAsync();
        }
    }
}