using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Models;
using Timesheets.Models.DTO;

namespace Timesheets.Services.Interfaces
{
    public interface ISheetManager
    {
        Sheet GetItem(Guid id);
        Guid Create(SheetDto sheet);
    }
}
