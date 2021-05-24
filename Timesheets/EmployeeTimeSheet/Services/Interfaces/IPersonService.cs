using EmployeeTimeSheet.Models;
using EmployeeTimeSheet.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTimeSheet.Services.Interfaces
{
    public interface IPersonService
    {
        Person GetItem(Guid id);
        Person GetItemByName(string firstName);
        Guid CreateItem(PersonDTO sheet);
        void UpdatePerson();
        void DeleteItem(Guid id);
    }
}
