using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    public class Contract
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public DateTime DateEnd { get; set; }
        public string Description { get; set; }
        public List<Service> Service { get; set; }
        public List<Employee> Employee { get; set; }
    }
}
