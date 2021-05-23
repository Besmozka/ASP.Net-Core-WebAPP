using System;

namespace Timesheets.Models
{
    public class Employee
    {
        /// <summary>
        /// Информация о сотруднике
        /// </summary>
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}