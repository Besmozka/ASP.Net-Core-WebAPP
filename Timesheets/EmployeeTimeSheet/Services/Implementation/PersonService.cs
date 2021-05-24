using EmployeeTimeSheet.Models;
using EmployeeTimeSheet.Models.DTO;
using EmployeeTimeSheet.Repositories.Interfaces;
using EmployeeTimeSheet.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTimeSheet.Services.Implementation
{
    public class PersonService : IPersonService
    {
        private IPersonRepository _repository;


        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }


        public Guid CreateItem(PersonDTO sheet)
        {
            var result = new Person
            {
                Id = new Guid(),
                Age = sheet.Age,
                FirstName = sheet.FirstName,
                LastName = sheet.LastName,
                Company = sheet.Company,
                Email = sheet.Email
            };
            _repository.Add(result);

            return result.Id;
        }

        public Person GetItem(Guid id)
        {
            return _repository.GetItem(id);
        }

        public Person GetItemByName(string firstName)
        {
            var person = new Person
            {
                FirstName = firstName
            };
            return _repository.Search(person);
        }

        public void DeleteItem(Guid id)
        {
            _repository.Delete(id);
        }

        public void UpdatePerson()
        {
            throw new NotImplementedException();
        }
    }
}
