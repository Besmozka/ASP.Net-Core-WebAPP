using System;

namespace Timesheets.Models.Dto
{
    public class EmployeeDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
