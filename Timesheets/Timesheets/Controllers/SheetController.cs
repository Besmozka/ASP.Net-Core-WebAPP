using Microsoft.AspNetCore.Mvc;
using System;
using Timesheets.Models;
using Timesheets.Models.DTO;
using Timesheets.Services.Interfaces;

namespace Timesheets.Controllers
{
    public class SheetController : ControllerBase
    {
        private readonly ISheetManager _sheetManager;

        public SheetController(ISheetManager sheetManager)
        {
            _sheetManager = sheetManager;
        }

        [HttpGet]
        public IActionResult GetItem(Guid id)
        {
            var result = _sheetManager.GetItem(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateItem([FromBody] SheetDto sheet)
        {
            var id = _sheetManager.Create(sheet);
            return Ok(id);
        }
    }
}
