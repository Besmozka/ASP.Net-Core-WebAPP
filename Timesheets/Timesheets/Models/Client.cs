using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    /// <summary>
    /// Информация о владелце контракта
    /// </summary>
    public class Client
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
    }
}
