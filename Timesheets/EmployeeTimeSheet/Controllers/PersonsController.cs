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
        /// <summary>
        /// GET /persons/?skip={5}&take={10} — получение списка людей с пагинацией
        /// PUT /persons — обновление существующей персоны в коллекции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet ("/{id}")]
        public IActionResult GetItem([FromRoute] Guid id)
        {
            var result = _personService.GetItem(id);
            return Ok(result);
        }


        [HttpGet ("/")]
        public IActionResult GetItems([FromRoute] int firstIndex, int itemsCount)
        {
            return Ok();
        }


        [HttpGet("/search")]
        public IActionResult SearchItem([FromQuery] string searchTerm)
        {
            var result = _personService.GetItemByName(searchTerm);
            return Ok(result);
        }


        [HttpPost ("/")]
        public IActionResult CreateItem([FromBody] PersonDTO sheet)
        {
            var id = _personService.CreateItem(sheet);
            return Ok(id);
        }


        [HttpPut]
        public IActionResult UpdateItem([FromBody] PersonDTO sheet)
        {
            var result = _personService.UpdatePerson(id);
            return Ok(result);
        }


        [HttpDelete ("/delete/{id}")]
        public IActionResult DeleteItem([FromRoute] Guid id)
        {
            _personService.DeleteItem(id);
            return Ok();
        }
    }
}
