using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTimeSheet.Repositories
{
    public interface IRepository<T>
    {
        T GetItem(Guid id);
        T SearchByName(string name);
        IEnumerable<T> GetItems(int firstIndex, int itemsCount);
        void Add(T item);
        void Update(Guid id);
        void Delete(Guid id);
    }
}
