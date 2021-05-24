using EmployeeTimeSheet.Models;
using EmployeeTimeSheet.Models.DTO;
using System;
using System.Collections.Generic;

namespace EmployeeTimeSheet.Services.Interfaces
{
    public interface IPersonService
    {
        Person GetItem(Guid id);
        IEnumerable<Person> GetItemsByIndexPagination(int firstIndex, int indexCount);
        Person GetItemByName(string firstName);
        Guid CreateItem(PersonDTO sheet);
        void UpdatePerson(Guid id, PersonDTO person);
        void DeleteItem(Guid id);
    }
}
