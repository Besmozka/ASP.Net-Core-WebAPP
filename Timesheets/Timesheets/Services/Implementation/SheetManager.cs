using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Data.Interfaces;
using Timesheets.Models;
using Timesheets.Models.DTO;
using Timesheets.Services.Interfaces;

namespace Timesheets.Services.Implementation
{
    public class SheetManager : ISheetManager
    {
        private readonly ISheetRepository _sheetRepository;

        public SheetManager(ISheetRepository sheetRepository)
        {
            _sheetRepository = sheetRepository;
        }

        public Guid Create(SheetDto sheetRequest)
        {
            var sheet =  new Sheet
            {
                Id = Guid.NewGuid(),
                Amount = sheetRequest.Amount,
                ContractId = sheetRequest.ContractId,
                Date = sheetRequest.Date,
                EmployeeId = sheetRequest.EmployeeId,
                ServiceId = sheetRequest.ServiceId,
            };
            _sheetRepository.Add(sheet);
            return sheet.Id;
        }

        public Sheet GetItem(Guid id)
        {
            return _sheetRepository.GetItem(id);
        }
    }
}
