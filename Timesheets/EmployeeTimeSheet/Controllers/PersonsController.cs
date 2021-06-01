using EmployeeTimeSheet.Models.DTO;
using EmployeeTimeSheet.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeTimeSheet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;


        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }


        [HttpGet ("/{id}")]
        public IActionResult GetItem([FromRoute] Guid id)
        {
            var result = _personService.GetItem(id);
            return Ok(result);
        }


        [HttpGet ("/get")]
        public IActionResult GetItems([FromQuery] int skip, int take)
        {
            var result = _personService.GetItemsByIndexPagination(skip, take);
            return Ok(result);
        }


        [HttpGet("/search")]
        public IActionResult SearchItem([FromQuery] string searchTerm)
        {
            var result = _personService.GetItemByName(searchTerm);
            return Ok(result);
        }


        [HttpPost ("/create")]
        public IActionResult CreateItem([FromBody] PersonDTO person)
        {
            var id = _personService.CreateItem(person);
            return Ok(id);
        }


        [HttpPut("/update/id/{id}")]
        public IActionResult UpdateItem([FromRoute] Guid id, [FromBody] PersonDTO person)
        {
            _personService.UpdatePerson(id, person);
            return Ok();
        }


        [HttpDelete ("/delete/{id}")]
        public IActionResult DeleteItem([FromRoute] Guid id)
        {
            _personService.DeleteItem(id);
            return Ok();
        }
    }
}
