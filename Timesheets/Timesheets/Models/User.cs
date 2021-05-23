using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Models
{
    /// <summary>
    /// ИНформация о пользователе
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
    }
}
