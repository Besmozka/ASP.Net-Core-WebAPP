using EmployeeTimeSheet.Models;
using EmployeeTimeSheet.Models.DTO;
using EmployeeTimeSheet.Repositories.Interfaces;
using EmployeeTimeSheet.Services.Interfaces;
using System;
using System.Collections.Generic;

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
                Id = Guid.NewGuid(),
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

        public IEnumerable<Person> GetItemsByIndexPagination(int firstIndex, int indexCount)
        {
            return _repository.GetItems(firstIndex, indexCount);
        }

        public Person GetItemByName(string firstName)
        {
            return _repository.SearchByName(firstName);
        }

        public void DeleteItem(Guid id)
        {
            _repository.Delete(id);
        }

        public void UpdatePerson(Guid id, PersonDTO person)
        {
            Person repositoryPerson = new Person
            {
                Id = id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age,
                Company = person.Company,
                Email = person.Email,
            };
            _repository.Update(repositoryPerson);
        }
    }
}
